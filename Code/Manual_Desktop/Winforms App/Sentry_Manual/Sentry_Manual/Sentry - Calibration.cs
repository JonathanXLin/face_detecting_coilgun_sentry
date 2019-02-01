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
    public partial class Sentry___Calibration : Form
    {
        public Sentry___Calibration()
        {
            InitializeComponent();
        }

        private void Sentry___Calibration_Load(object sender, EventArgs e)
        {
            hScrollBarXSpeedMultiplier.Value = Convert.ToInt32(Globals.xSpeedMultiplier * 100);
            hScrollBarXTrim.Value = Convert.ToInt32(Globals.xTrim*4);

            hScrollBarYSpeedMultiplier.Value = Convert.ToInt32(Globals.ySpeedMultiplier * 100);
            hScrollBarYTrim.Value = Convert.ToInt32(Globals.yTrim*4);
        }

        private void hScrollBarXSpeedMultiplier_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.xSpeedMultiplier = Convert.ToDouble(hScrollBarXSpeedMultiplier.Value / 100.0);
        }

        private void hScrollBarXTrim_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.xTrim = Convert.ToDouble(hScrollBarXTrim.Value/4);
        }

        private void hScrollBarYSpeedMultiplier_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.ySpeedMultiplier = Convert.ToDouble(hScrollBarYSpeedMultiplier.Value / 100.0);
        }

        private void hScrollBarYTrim_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.yTrim = Convert.ToDouble(hScrollBarYTrim.Value/4);
        }
    }
}
