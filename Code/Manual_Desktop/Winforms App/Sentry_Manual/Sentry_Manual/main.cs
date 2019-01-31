using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentry_Manual
{
    public partial class main : Form
    {
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

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
            {
                buttonUp.BackColor = Color.White;
                up_press();
            }
            if (e.KeyData == Keys.A)
            {
                buttonLeft.BackColor = Color.White;
            }
            if (e.KeyData == Keys.S)
            {
                buttonDown.BackColor = Color.White;
            }
            if (e.KeyData == Keys.D)
            {
                buttonRight.BackColor = Color.White;
            }
        }

        private void main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.W)
                buttonUp.BackColor = default(Color);
            if (e.KeyData == Keys.A)
                buttonLeft.BackColor = default(Color);
            if (e.KeyData == Keys.S)
                buttonDown.BackColor = default(Color);
            if (e.KeyData == Keys.D)
                buttonRight.BackColor = default(Color);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            up_press();
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

        void up_press()
        {
            serialPortSentry.Write("test");
        }

        private void comboBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
