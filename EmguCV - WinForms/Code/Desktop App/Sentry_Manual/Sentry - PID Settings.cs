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
    public partial class Sentry___PID_Settings : Form
    {
        public Sentry___PID_Settings()
        {
            InitializeComponent();
        }

        private void Sentry___PID_Settings_Load(object sender, EventArgs e)
        {
            hScrollBarGainProportionalX.Value = Convert.ToInt16(Globals.gainProportionalX*100);
            hScrollBarGainProportionalX.Refresh();
            hScrollBarGainIntegralX.Value = Convert.ToInt16(Globals.gainIntegralX * 100);
            hScrollBarGainIntegralX.Refresh();
            hScrollBarGainDerivativeX.Value = Convert.ToInt16(Globals.gainDerivativeX * 100);
            hScrollBarGainDerivativeX.Refresh();

            hScrollBarGainProportionalY.Value = Convert.ToInt16(Globals.gainProportionalY * 100);
            hScrollBarGainProportionalY.Refresh();
            hScrollBarGainIntegralY.Value = Convert.ToInt16(Globals.gainIntegralY * 100);
            hScrollBarGainIntegralY.Refresh();
            hScrollBarGainDerivativeY.Value = Convert.ToInt16(Globals.gainDerivativeY * 100);
            hScrollBarGainDerivativeY.Refresh();
        }

        private void hScrollBarGainProportionalX_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainProportionalX = Convert.ToDouble(hScrollBarGainProportionalX.Value) / 100.0;
        }

        private void hScrollBarGainIntegralX_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainIntegralX = Convert.ToDouble(hScrollBarGainIntegralX.Value) / 100.0;
        }

        private void hScrollBarGainDerivativeX_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainDerivativeX = Convert.ToDouble(hScrollBarGainDerivativeX.Value) / 100.0;
        }

        private void hScrollBarGainProportionalY_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainProportionalY = Convert.ToDouble(hScrollBarGainProportionalY.Value) / 100.0;
        }

        private void hScrollBarGainIntegralY_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainIntegralY = Convert.ToDouble(hScrollBarGainIntegralY.Value) / 100.0;
        }

        private void hScrollBarGainDerivativeY_Scroll(object sender, ScrollEventArgs e)
        {
            Globals.gainDerivativeY = Convert.ToDouble(hScrollBarGainDerivativeX.Value) / 100.0;
        }
    }
}
