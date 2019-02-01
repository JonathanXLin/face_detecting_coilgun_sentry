namespace Sentry_Manual
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.serialPortSentry = new System.IO.Ports.SerialPort(this.components);
            this.timerSerial = new System.Windows.Forms.Timer(this.components);
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.hScrollBarSpeed = new System.Windows.Forms.HScrollBar();
            this.groupBoxMovement = new System.Windows.Forms.GroupBox();
            this.groupBoxSerialConnection = new System.Windows.Forms.GroupBox();
            this.groupBoxTurretSpeeds = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCalibrate = new System.Windows.Forms.Button();
            this.groupBoxMovement.SuspendLayout();
            this.groupBoxSerialConnection.SuspendLayout();
            this.groupBoxTurretSpeeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(81, 85);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(60, 60);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.TabStop = false;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseDown);
            this.buttonDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDown_MouseUp);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(147, 85);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 60);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.TabStop = false;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseDown);
            this.buttonRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonRight_MouseUp);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(15, 85);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 60);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.TabStop = false;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseDown);
            this.buttonLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseUp);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(81, 19);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(60, 60);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.TabStop = false;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseDown);
            this.buttonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseUp);
            // 
            // serialPortSentry
            // 
            this.serialPortSentry.PortName = "COM7";
            // 
            // timerSerial
            // 
            this.timerSerial.Enabled = true;
            this.timerSerial.Interval = 10;
            this.timerSerial.Tick += new System.EventHandler(this.timerSerial_Tick);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(106, 25);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(85, 21);
            this.comboBoxPort.TabIndex = 6;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(10, 20);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(86, 28);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // hScrollBarSpeed
            // 
            this.hScrollBarSpeed.Location = new System.Drawing.Point(11, 35);
            this.hScrollBarSpeed.Name = "hScrollBarSpeed";
            this.hScrollBarSpeed.Size = new System.Drawing.Size(181, 22);
            this.hScrollBarSpeed.TabIndex = 7;
            this.hScrollBarSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarSpeed_Scroll);
            // 
            // groupBoxMovement
            // 
            this.groupBoxMovement.Controls.Add(this.buttonDown);
            this.groupBoxMovement.Controls.Add(this.buttonUp);
            this.groupBoxMovement.Controls.Add(this.buttonRight);
            this.groupBoxMovement.Controls.Add(this.buttonLeft);
            this.groupBoxMovement.Location = new System.Drawing.Point(227, 299);
            this.groupBoxMovement.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMovement.Name = "groupBoxMovement";
            this.groupBoxMovement.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMovement.Size = new System.Drawing.Size(221, 167);
            this.groupBoxMovement.TabIndex = 9;
            this.groupBoxMovement.TabStop = false;
            this.groupBoxMovement.Text = "Movement";
            // 
            // groupBoxSerialConnection
            // 
            this.groupBoxSerialConnection.Controls.Add(this.buttonConnect);
            this.groupBoxSerialConnection.Controls.Add(this.comboBoxPort);
            this.groupBoxSerialConnection.Location = new System.Drawing.Point(12, 408);
            this.groupBoxSerialConnection.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSerialConnection.Name = "groupBoxSerialConnection";
            this.groupBoxSerialConnection.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSerialConnection.Size = new System.Drawing.Size(202, 58);
            this.groupBoxSerialConnection.TabIndex = 10;
            this.groupBoxSerialConnection.TabStop = false;
            this.groupBoxSerialConnection.Text = "Serial Connection";
            // 
            // groupBoxTurretSpeeds
            // 
            this.groupBoxTurretSpeeds.Controls.Add(this.label7);
            this.groupBoxTurretSpeeds.Controls.Add(this.button1);
            this.groupBoxTurretSpeeds.Controls.Add(this.buttonCalibrate);
            this.groupBoxTurretSpeeds.Controls.Add(this.hScrollBarSpeed);
            this.groupBoxTurretSpeeds.Location = new System.Drawing.Point(12, 299);
            this.groupBoxTurretSpeeds.Name = "groupBoxTurretSpeeds";
            this.groupBoxTurretSpeeds.Size = new System.Drawing.Size(202, 104);
            this.groupBoxTurretSpeeds.TabIndex = 11;
            this.groupBoxTurretSpeeds.TabStop = false;
            this.groupBoxTurretSpeeds.Text = "TurretSpeed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Speed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "[   ]";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCalibrate
            // 
            this.buttonCalibrate.Location = new System.Drawing.Point(11, 64);
            this.buttonCalibrate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCalibrate.Name = "buttonCalibrate";
            this.buttonCalibrate.Size = new System.Drawing.Size(86, 28);
            this.buttonCalibrate.TabIndex = 12;
            this.buttonCalibrate.Text = "Calibrate";
            this.buttonCalibrate.UseVisualStyleBackColor = true;
            this.buttonCalibrate.Click += new System.EventHandler(this.buttonCalibrate_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 477);
            this.Controls.Add(this.groupBoxTurretSpeeds);
            this.Controls.Add(this.groupBoxSerialConnection);
            this.Controls.Add(this.groupBoxMovement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentry - Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.main_KeyUp);
            this.groupBoxMovement.ResumeLayout(false);
            this.groupBoxSerialConnection.ResumeLayout(false);
            this.groupBoxTurretSpeeds.ResumeLayout(false);
            this.groupBoxTurretSpeeds.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.IO.Ports.SerialPort serialPortSentry;
        private System.Windows.Forms.Timer timerSerial;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.HScrollBar hScrollBarSpeed;
        private System.Windows.Forms.GroupBox groupBoxMovement;
        private System.Windows.Forms.GroupBox groupBoxSerialConnection;
        private System.Windows.Forms.GroupBox groupBoxTurretSpeeds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCalibrate;
        private System.Windows.Forms.Label label7;
    }
}

