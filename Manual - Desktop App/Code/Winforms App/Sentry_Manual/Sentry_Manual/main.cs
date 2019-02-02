using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Management;
using System.IO;

using AForge.Video;
using AForge.Video.DirectShow;

namespace Sentry_Manual
{
    public partial class main : Form
    {
        //Camera variables
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        //Serial connection variables
        bool isConnected = false;
        String[] ports;
        SerialPort port;

        string serialStringVertical = "";
        string serialStringHorizontal = "";
        string serialString = "";

        //Turret variables
        int speed = 30;//Initial value reflected in scroll bar

        bool upKeyHold = false;
        bool downKeyHold = false;
        bool leftKeyHold = false;
        bool rightKeyHold = false;
        bool speedIncrease = false;
        bool speedDecrease = false;

        int masterOffset = 10;

        public main()
        {
            InitializeComponent();

            //Search for serial connections
            ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBoxPort.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBoxPort.SelectedItem = ports[0];
                }
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            //Initialize object values
            comboBoxPort.DropDownStyle = ComboBoxStyle.DropDownList;
            hScrollBarSpeed.Value = 30;
            speed = hScrollBarSpeed.Value + masterOffset;

            //Button animation effects
            buttonUp.BackColor = default(Color);
            buttonLeft.BackColor = default(Color);
            buttonDown.BackColor = default(Color);
            buttonRight.BackColor = default(Color);

            //Restore calibration data from .txt file
            string calibrationData = File.ReadAllText("calibration_data.txt");
            string[] calibrationDataSplit = calibrationData.Split(' ');

            Globals.xSpeedMultiplier = Convert.ToDouble(calibrationDataSplit[0]);
            Globals.xTrim = Convert.ToDouble(calibrationDataSplit[1]);
            Globals.ySpeedMultiplier = Convert.ToDouble(calibrationDataSplit[2]);
            Globals.yTrim = Convert.ToDouble(calibrationDataSplit[3]);

            //Load video display
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCamera.Items.Add(device.Name);
            }

            videoSource = new VideoCaptureDevice();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.Items.Count == 0)
            { }
            else if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            buttonConnect.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Close();
            buttonConnect.Text = "Connect";
        }

        private void timerSerial_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialStringHorizontal = "0";
                serialStringVertical = "0";

                if (speedIncrease && !speedDecrease)
                {
                    if (hScrollBarSpeed.Value < 100)
                    {
                        speed += 1;
                        hScrollBarSpeed.Value += 1;
                        hScrollBarSpeed.Refresh();
                    }
                }
                if (speedDecrease && !speedIncrease)
                {
                    if (hScrollBarSpeed.Value > 0)
                    {
                        speed -= 1;
                        hScrollBarSpeed.Value -= 1;
                        hScrollBarSpeed.Refresh();
                    }
                }
                if (upKeyHold && !downKeyHold)
                {
                    serialStringVertical = ((speed - Globals.yTrim) * Globals.ySpeedMultiplier).ToString();
                }
                if (downKeyHold && !upKeyHold)
                {
                    serialStringVertical = ((speed + Globals.yTrim) * Globals.ySpeedMultiplier * -1).ToString();
                }
                if (leftKeyHold && !rightKeyHold)
                {
                    serialStringHorizontal = ((speed - Globals.xTrim) * Globals.xSpeedMultiplier).ToString();
                }
                if (rightKeyHold && !leftKeyHold)
                {
                    serialStringHorizontal = ((speed + Globals.xTrim) * Globals.xSpeedMultiplier * -1).ToString();
                }

                serialString = "X" + serialStringHorizontal + "Y" + serialStringVertical + "E";
                port.WriteLine(serialString);
                Console.Write(serialString);
            }
        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                if (e.KeyData == Keys.W)
                {
                    upKeyHold = true;

                    buttonUp.BackColor = Color.White;
                }
                if (e.KeyData == Keys.A)
                {
                    leftKeyHold = true;

                    buttonLeft.BackColor = Color.White;
                }
                if (e.KeyData == Keys.S)
                {
                    downKeyHold = true;

                    buttonDown.BackColor = Color.White;
                }
                if (e.KeyData == Keys.D)
                {
                    rightKeyHold = true;

                    buttonRight.BackColor = Color.White;
                }
                if (e.KeyData == Keys.Q)
                {
                    speedDecrease = true;
                }
                if (e.KeyData == Keys.E)
                {
                    speedIncrease = true;
                }
            }
        }

        private void main_KeyUp(object sender, KeyEventArgs e)
        {
            if (isConnected)
            {
                if (e.KeyData == Keys.W)
                {
                    upKeyHold = false;

                    buttonUp.BackColor = default(Color);
                }
                if (e.KeyData == Keys.A)
                {
                    leftKeyHold = false;

                    buttonLeft.BackColor = default(Color);
                }
                if (e.KeyData == Keys.S)
                {
                    downKeyHold = false;

                    buttonDown.BackColor = default(Color);
                }
                if (e.KeyData == Keys.D)
                {
                    rightKeyHold = false;

                    buttonRight.BackColor = default(Color);
                }
                if (e.KeyData == Keys.Q)
                {
                    speedDecrease = false;
                }
                if (e.KeyData == Keys.E)
                {
                    speedIncrease = false;
                }
            }
        }

        private void buttonUp_MouseDown(object sender, MouseEventArgs e)
        {
            upKeyHold = true;
        }

        private void buttonUp_MouseUp(object sender, MouseEventArgs e)
        {
            upKeyHold = false;
        }

        private void buttonLeft_MouseDown(object sender, MouseEventArgs e)
        {
            leftKeyHold = true;
        }

        private void buttonLeft_MouseUp(object sender, MouseEventArgs e)
        {
            leftKeyHold = false;
        }

        private void buttonDown_MouseDown(object sender, MouseEventArgs e)
        {
            downKeyHold = true;
        }

        private void buttonDown_MouseUp(object sender, MouseEventArgs e)
        {
            downKeyHold = false;
        }

        private void buttonRight_MouseDown(object sender, MouseEventArgs e)
        {
            rightKeyHold = true;
        }

        private void buttonRight_MouseUp(object sender, MouseEventArgs e)
        {
            rightKeyHold = false;
        }

        private void hScrollBarSpeed_Scroll(object sender, ScrollEventArgs e)
        {
            speed = Convert.ToInt32(hScrollBarSpeed.Value) + masterOffset;
        }

        private void buttonCalibrate_Click(object sender, EventArgs e)
        {
            Sentry___Calibration sentryCalibration = new Sentry___Calibration();
            sentryCalibration.ShowDialog();
        }

        private void buttonControls_Click(object sender, EventArgs e)
        {
            Sentry___Controls sentryControls = new Sentry___Controls();
            sentryControls.ShowDialog();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
                videoSource.Stop();

            string fileName = "calibration_data.txt";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream file = File.Create(fileName))
                {
                    string calibrationData = Globals.xSpeedMultiplier.ToString() + " " + Globals.xTrim.ToString() + " " + Globals.ySpeedMultiplier.ToString() + " " + Globals.yTrim.ToString();
                    byte[] info = new UTF8Encoding(true).GetBytes(calibrationData);
                    file.Write(info, 0, info.Length);
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

            Application.Exit();
        }

        private void buttonActivateCamera_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pictureBoxCamera.Image = null;
                pictureBoxCamera.Invalidate();
            }
            else
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCamera.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                videoSource.Start();
            }
        }

        void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxCamera.Image = image;
        }
    }

    public static class Globals
    {
        public static double xSpeedMultiplier;
        public static double xTrim;
        public static double ySpeedMultiplier;
        public static double yTrim;
    }
}
