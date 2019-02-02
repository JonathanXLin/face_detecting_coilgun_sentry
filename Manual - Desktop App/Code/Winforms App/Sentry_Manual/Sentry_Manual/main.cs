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
using System.Threading;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

using AForge.Video;
using AForge.Video.DirectShow;

namespace Sentry_Manual
{
    public partial class main : Form
    {
        //Camera variables
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        bool isConnectedCamera;
        int cameraNumber;

        //Serial connection variables
        bool isConnectedSerial = false;
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

            //Load connected webcam data
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCamera.Items.Add(device.Name);
            }

            if (comboBoxCamera.Items.Count != 0)
            {
                comboBoxCamera.SelectedIndex = 0;
            }

            bool noCameras = false;
            try
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCamera.SelectedIndex].MonikerString);
            }
            catch
            {
                noCameras = true;
            }

            if (!noCameras)
            {
                labelNoConnection.Visible = false;
                labelNoConnection.Refresh();
            }
            else
            {
                labelNoConnection.Visible = true;
                labelNoConnection.Refresh();
            }

            new Thread(() =>
            {
                var vc = new Capture(cameraNumber);

                int totalFrames = (int)vc.GetCaptureProperty(CapProp.FrameCount);
                UMat lastFrame = null;
                Mat frame;

                while ((frame = vc.QuerySmallFrame()) != null && !IsDisposed && !disconnectCamera)
                {
                    lastFrame?.Dispose();
                    lastFrame = frame.ToUMat(AccessType.Fast);
                    frame.Dispose();

                    draw_face_box(lastFrame, 1.1, 10);

                    try
                    {
                        imageBoxCamera.Image = lastFrame;
                    }
                    catch (Exception f)
                    { }
                }
                lastFrame?.Dispose();
                vc.Stop();
                vc.Dispose();
                if (!IsDisposed)
                {
                    imageBoxCamera.Image = null;
                    BeginInvoke((MethodInvoker)(() =>
                    {
                        labelNoConnection.Visible = true;
                    }));
                }
            }).Start();

            disconnectCamera = false;
            isConnectedCamera = true;

            labelNoConnection.Visible = false;
        }

        private void draw_face_box(UMat source, double scale, int sensitivity)
        {
            var adjustment = new RectangleF(1f / 8, 1f / 8, 6f / 8, 6f / 8);
            var faces = classifier.DetectMultiScale(source, scale, sensitivity, Size.Empty);

            foreach (var face in faces)
            {
                Rectangle adjusted = new Rectangle(
                    (int)(face.X + face.Width * adjustment.X), (int)(face.Y + face.Height * adjustment.Y),
                    (int)(face.Width * adjustment.Width), (int)(face.Height * adjustment.Height));

                using (var resizedOverlay = new UMat())
                {
                    using (var addableOverlay = new UMat())
                    {
                        //CvInvoke.CvtColor(resizedOverlay, addableOverlay, ColorConversion.Bgra2Bgr);

                        CvInvoke.Rectangle(source, adjusted, new MCvScalar(255,0,0,255), 2,LineType.EightConnected, 0);
                        CvInvoke.Line(source, new Point(0, 0), new Point(face.X + face.Width/2, face.Y + face.Width/2), new MCvScalar(255, 0, 0, 255), 2, LineType.EightConnected, 0);
                        //using (var overlayAlphaChannel = new UMat())
                        //{
                        //    CvInvoke.ExtractChannel(resizedOverlay, overlayAlphaChannel, 3);

                        //    using (var roi = new UMat(source, adjusted))
                        //    {
                        //        var k = adjusted.Width / 8;
                        //        if (k % 2 == 0) k++;
                        //        CvInvoke.GaussianBlur(roi, roi, new Size(k, k), 0, 0, BorderType.Reflect101);
                        //        roi.SetTo(new MCvScalar(0, 0, 0), overlayAlphaChannel);
                        //        CvInvoke.Add(roi, addableOverlay, roi, overlayAlphaChannel);
                        //    }
                        //}
                    }
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.Items.Count == 0)
            { }
            else if (!isConnectedSerial)
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
            isConnectedSerial = true;
            string selectedPort = comboBoxPort.GetItemText(comboBoxPort.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            buttonSerialConnect.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnectedSerial = false;
            port.Close();
            buttonSerialConnect.Text = "Connect";
        }

        private void timerSerial_Tick(object sender, EventArgs e)
        {
            if (isConnectedSerial)
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
            if (isConnectedSerial)
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
            if (isConnectedSerial)
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

        Boolean disconnectCamera = false;

        private void buttonActivateCamera_Click(object sender, EventArgs e)
        {
            if (isConnectedCamera)
            {
                disconnectCamera = true;
                isConnectedCamera = false;
            }
            else
            {
                new Thread(() =>
                {
                    var vc = new Capture(cameraNumber);

                    int totalFrames = (int)vc.GetCaptureProperty(CapProp.FrameCount);
                    UMat lastFrame = null;
                    Mat frame;

                    while ((frame = vc.QuerySmallFrame()) != null && !IsDisposed && !disconnectCamera)
                    {
                        lastFrame?.Dispose();
                        lastFrame = frame.ToUMat(AccessType.Fast);
                        frame.Dispose();

                        draw_face_box(lastFrame, 1.1, 10);

                        try
                        {
                            imageBoxCamera.Image = lastFrame;
                        }
                        catch (Exception f)
                        { }
                    }
                    lastFrame?.Dispose();
                    vc.Stop();
                    vc.Dispose();
                    if (!IsDisposed)
                    {
                        imageBoxCamera.Image = null;
                        BeginInvoke((MethodInvoker)(() =>
                        {
                            labelNoConnection.Visible = true;
                        }));
                    }
                }).Start();

                disconnectCamera = false;
                isConnectedCamera = true;

                labelNoConnection.Visible = false;
            }
        }

        CascadeClassifier classifier = new CascadeClassifier(Application.StartupPath + "/haarcascade_frontalface_default.xml");

        private void comboBoxCameraResolutions_SelectedIndexChanged(object sender, EventArgs e)
        {

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
