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

            hScrollBarYSpeedMultiplier.Value = Convert.ToInt32(Globals.ySpeedMultiplier * 100);
        }

        private void hScrollBarXSpeedMultiplier_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.xSpeedMultiplier = Convert.ToDouble(hScrollBarXSpeedMultiplier.Value / 100.0);
        }

        private void hScrollBarYSpeedMultiplier_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.ySpeedMultiplier = Convert.ToDouble(hScrollBarYSpeedMultiplier.Value / 100.0);
        }
    }
}
