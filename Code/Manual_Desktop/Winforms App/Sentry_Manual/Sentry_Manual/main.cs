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

namespace Sentry_Manual
{
    public partial class main : Form
    {
        int speed = 50;

        bool upKeyHold = false;
        bool downKeyHold = false;
        bool leftKeyHold = false;
        bool rightKeyHold = false;

        string serialString = "";

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            serialPortSentry.Open();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timerSerial_Tick(object sender, EventArgs e)
        {
            if (upKeyHold && !downKeyHold)
            {
                serialString = "50";
            }
            if (downKeyHold && !upKeyHold)
            {
                serialString = "-50";
            }
            if (leftKeyHold && !rightKeyHold)
            {
                serialPortSentry.WriteLine(speed.ToString() + "e");
            }
            if (rightKeyHold && !leftKeyHold)
            {
                serialPortSentry.WriteLine("-" + speed.ToString() + "e");
            }

            serialPortSentry.WriteLine(serialString + "e");
            serialString = "";
        }

        private void main_KeyDown(object sender, KeyEventArgs e)
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
        }

        private void main_KeyUp(object sender, KeyEventArgs e)
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
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
