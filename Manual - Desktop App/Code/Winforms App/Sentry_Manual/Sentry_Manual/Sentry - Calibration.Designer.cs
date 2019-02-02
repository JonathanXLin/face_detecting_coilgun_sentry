namespace Sentry_Manual
{
    partial class Sentry___Calibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sentry___Calibration));
            this.hScrollBarYSpeedMultiplier = new System.Windows.Forms.HScrollBar();
            this.groupBoxVerticalServo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSpeedMultiplierMarkings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBarYTrim = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hScrollBarXTrim = new System.Windows.Forms.HScrollBar();
            this.hScrollBarXSpeedMultiplier = new System.Windows.Forms.HScrollBar();
            this.groupBoxVerticalServo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hScrollBarYSpeedMultiplier
            // 
            this.hScrollBarYSpeedMultiplier.Location = new System.Drawing.Point(10, 50);
            this.hScrollBarYSpeedMultiplier.Maximum = 150;
            this.hScrollBarYSpeedMultiplier.Minimum = 50;
            this.hScrollBarYSpeedMultiplier.Name = "hScrollBarYSpeedMultiplier";
            this.hScrollBarYSpeedMultiplier.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarYSpeedMultiplier.TabIndex = 0;
            this.hScrollBarYSpeedMultiplier.Value = 50;
            this.hScrollBarYSpeedMultiplier.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarYSpeedMultiplier_Scroll);
            // 
            // groupBoxVerticalServo
            // 
            this.groupBoxVerticalServo.Controls.Add(this.label3);
            this.groupBoxVerticalServo.Controls.Add(this.labelSpeedMultiplierMarkings);
            this.groupBoxVerticalServo.Controls.Add(this.label2);
            this.groupBoxVerticalServo.Controls.Add(this.label1);
            this.groupBoxVerticalServo.Controls.Add(this.hScrollBarYTrim);
            this.groupBoxVerticalServo.Controls.Add(this.hScrollBarYSpeedMultiplier);
            this.groupBoxVerticalServo.Location = new System.Drawing.Point(238, 12);
            this.groupBoxVerticalServo.Name = "groupBoxVerticalServo";
            this.groupBoxVerticalServo.Size = new System.Drawing.Size(220, 128);
            this.groupBoxVerticalServo.TabIndex = 1;
            this.groupBoxVerticalServo.TabStop = false;
            this.groupBoxVerticalServo.Text = "Vertical Servo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Up                 Center             Down";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpeedMultiplierMarkings
            // 
            this.labelSpeedMultiplierMarkings.AutoSize = true;
            this.labelSpeedMultiplierMarkings.Location = new System.Drawing.Point(30, 35);
            this.labelSpeedMultiplierMarkings.Name = "labelSpeedMultiplierMarkings";
            this.labelSpeedMultiplierMarkings.Size = new System.Drawing.Size(163, 13);
            this.labelSpeedMultiplierMarkings.TabIndex = 4;
            this.labelSpeedMultiplierMarkings.Text = "0.5                    1                    1.5";
            this.labelSpeedMultiplierMarkings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trim";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed Multiplier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarYTrim
            // 
            this.hScrollBarYTrim.Location = new System.Drawing.Point(10, 100);
            this.hScrollBarYTrim.Maximum = 50;
            this.hScrollBarYTrim.Minimum = -50;
            this.hScrollBarYTrim.Name = "hScrollBarYTrim";
            this.hScrollBarYTrim.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarYTrim.TabIndex = 1;
            this.hScrollBarYTrim.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarYTrim_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.hScrollBarXTrim);
            this.groupBox1.Controls.Add(this.hScrollBarXSpeedMultiplier);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horizontal Servo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Left                Center             Right";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "0.5                    1                    1.5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Trim";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Speed Multiplier";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hScrollBarXTrim
            // 
            this.hScrollBarXTrim.Location = new System.Drawing.Point(10, 100);
            this.hScrollBarXTrim.Maximum = 50;
            this.hScrollBarXTrim.Minimum = -50;
            this.hScrollBarXTrim.Name = "hScrollBarXTrim";
            this.hScrollBarXTrim.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarXTrim.TabIndex = 1;
            this.hScrollBarXTrim.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarXTrim_Scroll);
            // 
            // hScrollBarXSpeedMultiplier
            // 
            this.hScrollBarXSpeedMultiplier.Location = new System.Drawing.Point(10, 50);
            this.hScrollBarXSpeedMultiplier.Maximum = 150;
            this.hScrollBarXSpeedMultiplier.Minimum = 50;
            this.hScrollBarXSpeedMultiplier.Name = "hScrollBarXSpeedMultiplier";
            this.hScrollBarXSpeedMultiplier.Size = new System.Drawing.Size(200, 17);
            this.hScrollBarXSpeedMultiplier.TabIndex = 0;
            this.hScrollBarXSpeedMultiplier.Value = 59;
            this.hScrollBarXSpeedMultiplier.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarXSpeedMultiplier_Scroll);
            // 
            // Sentry___Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 152);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxVerticalServo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sentry___Calibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentry - Calibration";
            this.Load += new System.EventHandler(this.Sentry___Calibration_Load);
            this.groupBoxVerticalServo.ResumeLayout(false);
            this.groupBoxVerticalServo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBarYSpeedMultiplier;
        private System.Windows.Forms.GroupBox groupBoxVerticalServo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBarYTrim;
        private System.Windows.Forms.Label labelSpeedMultiplierMarkings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HScrollBar hScrollBarXTrim;
        private System.Windows.Forms.HScrollBar hScrollBarXSpeedMultiplier;
    }
}