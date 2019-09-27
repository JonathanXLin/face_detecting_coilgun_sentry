namespace Sentry_Manual
{
    partial class Sentry___PID_Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sentry___PID_Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGainIntegral = new System.Windows.Forms.Label();
            this.labelGainProportional = new System.Windows.Forms.Label();
            this.hScrollBarGainIntegralX = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGainProportionalX = new System.Windows.Forms.HScrollBar();
            this.groupBoxVerticalServo = new System.Windows.Forms.GroupBox();
            this.hScrollBarGainIntegralY = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGainProportionalY = new System.Windows.Forms.HScrollBar();
            this.labelGainDerivative = new System.Windows.Forms.Label();
            this.hScrollBarGainDerivativeX = new System.Windows.Forms.HScrollBar();
            this.hScrollBarGainDerivativeY = new System.Windows.Forms.HScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBoxVerticalServo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelGainDerivative);
            this.groupBox1.Controls.Add(this.hScrollBarGainDerivativeX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelGainIntegral);
            this.groupBox1.Controls.Add(this.labelGainProportional);
            this.groupBox1.Controls.Add(this.hScrollBarGainIntegralX);
            this.groupBox1.Controls.Add(this.hScrollBarGainProportionalX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 187);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horizontal Servo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0.0                    0.5                    1.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0.0                    0.5                    1.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGainIntegral
            // 
            this.labelGainIntegral.AutoSize = true;
            this.labelGainIntegral.Location = new System.Drawing.Point(84, 70);
            this.labelGainIntegral.Name = "labelGainIntegral";
            this.labelGainIntegral.Size = new System.Drawing.Size(67, 13);
            this.labelGainIntegral.TabIndex = 3;
            this.labelGainIntegral.Text = "Integral Gain";
            this.labelGainIntegral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGainProportional
            // 
            this.labelGainProportional.AutoSize = true;
            this.labelGainProportional.Location = new System.Drawing.Point(75, 20);
            this.labelGainProportional.Name = "labelGainProportional";
            this.labelGainProportional.Size = new System.Drawing.Size(88, 13);
            this.labelGainProportional.TabIndex = 2;
            this.labelGainProportional.Text = "Proportional Gain";
            this.labelGainProportional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarGainIntegralX
            // 
            this.hScrollBarGainIntegralX.Location = new System.Drawing.Point(10, 100);
            this.hScrollBarGainIntegralX.Name = "hScrollBarGainIntegralX";
            this.hScrollBarGainIntegralX.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainIntegralX.TabIndex = 1;
            this.hScrollBarGainIntegralX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainIntegralX_Scroll);
            // 
            // hScrollBarGainProportionalX
            // 
            this.hScrollBarGainProportionalX.Location = new System.Drawing.Point(10, 50);
            this.hScrollBarGainProportionalX.Name = "hScrollBarGainProportionalX";
            this.hScrollBarGainProportionalX.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainProportionalX.TabIndex = 0;
            this.hScrollBarGainProportionalX.Value = 59;
            this.hScrollBarGainProportionalX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainProportionalX_Scroll);
            // 
            // groupBoxVerticalServo
            // 
            this.groupBoxVerticalServo.Controls.Add(this.label1);
            this.groupBoxVerticalServo.Controls.Add(this.hScrollBarGainDerivativeY);
            this.groupBoxVerticalServo.Controls.Add(this.label2);
            this.groupBoxVerticalServo.Controls.Add(this.hScrollBarGainIntegralY);
            this.groupBoxVerticalServo.Controls.Add(this.label3);
            this.groupBoxVerticalServo.Controls.Add(this.label7);
            this.groupBoxVerticalServo.Controls.Add(this.hScrollBarGainProportionalY);
            this.groupBoxVerticalServo.Controls.Add(this.label8);
            this.groupBoxVerticalServo.Controls.Add(this.label9);
            this.groupBoxVerticalServo.Location = new System.Drawing.Point(238, 12);
            this.groupBoxVerticalServo.Name = "groupBoxVerticalServo";
            this.groupBoxVerticalServo.Size = new System.Drawing.Size(220, 187);
            this.groupBoxVerticalServo.TabIndex = 7;
            this.groupBoxVerticalServo.TabStop = false;
            this.groupBoxVerticalServo.Text = "Vertical Servo";
            // 
            // hScrollBarGainIntegralY
            // 
            this.hScrollBarGainIntegralY.Location = new System.Drawing.Point(10, 100);
            this.hScrollBarGainIntegralY.Name = "hScrollBarGainIntegralY";
            this.hScrollBarGainIntegralY.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainIntegralY.TabIndex = 1;
            this.hScrollBarGainIntegralY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainIntegralY_Scroll);
            // 
            // hScrollBarGainProportionalY
            // 
            this.hScrollBarGainProportionalY.Location = new System.Drawing.Point(10, 50);
            this.hScrollBarGainProportionalY.Name = "hScrollBarGainProportionalY";
            this.hScrollBarGainProportionalY.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainProportionalY.TabIndex = 0;
            this.hScrollBarGainProportionalY.Value = 50;
            this.hScrollBarGainProportionalY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainProportionalY_Scroll);
            // 
            // labelGainDerivative
            // 
            this.labelGainDerivative.AutoSize = true;
            this.labelGainDerivative.Location = new System.Drawing.Point(79, 119);
            this.labelGainDerivative.Name = "labelGainDerivative";
            this.labelGainDerivative.Size = new System.Drawing.Size(80, 13);
            this.labelGainDerivative.TabIndex = 7;
            this.labelGainDerivative.Text = "Derivative Gain";
            this.labelGainDerivative.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarGainDerivativeX
            // 
            this.hScrollBarGainDerivativeX.Location = new System.Drawing.Point(10, 149);
            this.hScrollBarGainDerivativeX.Name = "hScrollBarGainDerivativeX";
            this.hScrollBarGainDerivativeX.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainDerivativeX.TabIndex = 6;
            this.hScrollBarGainDerivativeX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainDerivativeX_Scroll);
            // 
            // hScrollBarGainDerivativeY
            // 
            this.hScrollBarGainDerivativeY.Location = new System.Drawing.Point(10, 149);
            this.hScrollBarGainDerivativeY.Name = "hScrollBarGainDerivativeY";
            this.hScrollBarGainDerivativeY.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarGainDerivativeY.TabIndex = 9;
            this.hScrollBarGainDerivativeY.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarGainDerivativeY_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "0.0                    0.5                    1.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "0.0                    0.5                    1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Derivative Gain";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "0.0                    0.5                    1.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "0.0                    0.5                    1.0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Integral Gain";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Proportional Gain";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sentry___PID_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVerticalServo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sentry___PID_Settings";
            this.Text = "Sentry - PID Settings";
            this.Load += new System.EventHandler(this.Sentry___PID_Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxVerticalServo.ResumeLayout(false);
            this.groupBoxVerticalServo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelGainIntegral;
        private System.Windows.Forms.Label labelGainProportional;
        private System.Windows.Forms.HScrollBar hScrollBarGainIntegralX;
        private System.Windows.Forms.HScrollBar hScrollBarGainProportionalX;
        private System.Windows.Forms.GroupBox groupBoxVerticalServo;
        private System.Windows.Forms.HScrollBar hScrollBarGainIntegralY;
        private System.Windows.Forms.HScrollBar hScrollBarGainProportionalY;
        private System.Windows.Forms.Label labelGainDerivative;
        private System.Windows.Forms.HScrollBar hScrollBarGainDerivativeX;
        private System.Windows.Forms.HScrollBar hScrollBarGainDerivativeY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}