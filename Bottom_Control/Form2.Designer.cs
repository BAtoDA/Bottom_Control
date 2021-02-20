
namespace Bottom_Control
{
    partial class Form2
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
            this.daPond1 = new Bottom_Control.基本控件.DAPond();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.daConduit1 = new Bottom_Control.基本控件.DAConduit();
            this.daRotor1 = new Bottom_Control.基本控件.DARotor();
            this.daProcessWave1 = new Bottom_Control.基本控件.DAProcessWave();
            this.daProcessEllipse1 = new Bottom_Control.基本控件.DAProcessEllipse();
            this.daBottle1 = new Bottom_Control.基本控件.DABottle();
            this.daLedBulb1 = new Bottom_Control.基本控件.DALedBulb();
            this.SuspendLayout();
            // 
            // daPond1
            // 
            this.daPond1.Control_Text = "0";
            this.daPond1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.daPond1.Location = new System.Drawing.Point(12, 12);
            this.daPond1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.daPond1.Name = "daPond1";
            this.daPond1.PLC_Address = "0";
            this.daPond1.PLC_Contact = "D";
            this.daPond1.PLC_Enable = true;
            this.daPond1.Size = new System.Drawing.Size(150, 50);
            this.daPond1.TabIndex = 0;
            this.daPond1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.daPond1.WallColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daPond1.WallWidth = 2;
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Interval = 500;
            this.plC_Open_Time1.Mitsubishi_Open = true;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            // 
            // daConduit1
            // 
            this.daConduit1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daConduit1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daConduit1.ConduitColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daConduit1.ConduitStyle = HZH_Controls.Controls.ConduitStyle.Horizontal_None_None;
            this.daConduit1.ConduitWidth = 50;
            this.daConduit1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.daConduit1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.Forward;
            this.daConduit1.LiquidSpeed = 100;
            this.daConduit1.Location = new System.Drawing.Point(12, 83);
            this.daConduit1.Name = "daConduit1";
            this.daConduit1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daConduit1.PLC_Address = "15";
            this.daConduit1.PLC_Contact = "Y";
            this.daConduit1.PLC_Enable = true;
            this.daConduit1.Size = new System.Drawing.Size(171, 53);
            this.daConduit1.TabIndex = 1;
            // 
            // daRotor1
            // 
            this.daRotor1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daRotor1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daRotor1.Location = new System.Drawing.Point(12, 160);
            this.daRotor1.Name = "daRotor1";
            this.daRotor1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daRotor1.PLC_Address = "15";
            this.daRotor1.PLC_Contact = "Y";
            this.daRotor1.PLC_Enable = true;
            this.daRotor1.RotorAround = HZH_Controls.Controls.RotorAround.None;
            this.daRotor1.RotorColor = System.Drawing.Color.Black;
            this.daRotor1.Size = new System.Drawing.Size(150, 150);
            this.daRotor1.Speed = 100;
            this.daRotor1.TabIndex = 2;
            // 
            // daProcessWave1
            // 
            this.daProcessWave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.daProcessWave1.ConerRadius = 0;
            this.daProcessWave1.Control_Text = "0";
            this.daProcessWave1.FillColor = System.Drawing.Color.Empty;
            this.daProcessWave1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.daProcessWave1.ForeColor = System.Drawing.Color.White;
            this.daProcessWave1.IsRadius = false;
            this.daProcessWave1.IsRectangle = false;
            this.daProcessWave1.IsShowRect = false;
            this.daProcessWave1.Location = new System.Drawing.Point(13, 277);
            this.daProcessWave1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daProcessWave1.MaxValue = 100;
            this.daProcessWave1.Name = "daProcessWave1";
            this.daProcessWave1.PLC_Address = "70";
            this.daProcessWave1.PLC_Contact = "D";
            this.daProcessWave1.PLC_Enable = true;
            this.daProcessWave1.RectColor = System.Drawing.Color.White;
            this.daProcessWave1.RectWidth = 4;
            this.daProcessWave1.Size = new System.Drawing.Size(150, 150);
            this.daProcessWave1.TabIndex = 3;
            this.daProcessWave1.Value = 0;
            this.daProcessWave1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // daProcessEllipse1
            // 
            this.daProcessEllipse1.BackEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.daProcessEllipse1.Control_Text = "0";
            this.daProcessEllipse1.CoreEllipseColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.daProcessEllipse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.daProcessEllipse1.ForeColor = System.Drawing.Color.White;
            this.daProcessEllipse1.IsShowCoreEllipseBorder = true;
            this.daProcessEllipse1.Location = new System.Drawing.Point(189, 12);
            this.daProcessEllipse1.MaxValue = 100;
            this.daProcessEllipse1.Name = "daProcessEllipse1";
            this.daProcessEllipse1.PLC_Address = "70";
            this.daProcessEllipse1.PLC_Contact = "D";
            this.daProcessEllipse1.PLC_Enable = true;
            this.daProcessEllipse1.ShowType = HZH_Controls.Controls.ShowType.Ring;
            this.daProcessEllipse1.Size = new System.Drawing.Size(150, 150);
            this.daProcessEllipse1.TabIndex = 4;
            this.daProcessEllipse1.Value = 0;
            this.daProcessEllipse1.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daProcessEllipse1.ValueMargin = 5;
            this.daProcessEllipse1.ValueType = HZH_Controls.Controls.ValueType.Percent;
            this.daProcessEllipse1.ValueWidth = 30;
            // 
            // daBottle1
            // 
            this.daBottle1.BottleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daBottle1.BottleMouthColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.daBottle1.Control_Text = "50";
            this.daBottle1.Direction = HZH_Controls.Controls.Direction.Down;
            this.daBottle1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.daBottle1.Location = new System.Drawing.Point(219, 160);
            this.daBottle1.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.daBottle1.Name = "daBottle1";
            this.daBottle1.NO = null;
            this.daBottle1.PLC_Address = "70";
            this.daBottle1.PLC_Contact = "D";
            this.daBottle1.PLC_Enable = true;
            this.daBottle1.Size = new System.Drawing.Size(100, 150);
            this.daBottle1.TabIndex = 5;
            this.daBottle1.Title = "瓶子1";
            this.daBottle1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // daLedBulb1
            // 
            this.daLedBulb1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daLedBulb1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daLedBulb1.Location = new System.Drawing.Point(257, 316);
            this.daLedBulb1.Name = "daLedBulb1";
            this.daLedBulb1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daLedBulb1.PLC_Address = "20";
            this.daLedBulb1.PLC_Contact = "Y";
            this.daLedBulb1.PLC_Enable = true;
            this.daLedBulb1.Size = new System.Drawing.Size(32, 32);
            this.daLedBulb1.TabIndex = 6;
            this.daLedBulb1.Text = "daLedBulb1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daLedBulb1);
            this.Controls.Add(this.daBottle1);
            this.Controls.Add(this.daProcessEllipse1);
            this.Controls.Add(this.daProcessWave1);
            this.Controls.Add(this.daRotor1);
            this.Controls.Add(this.daConduit1);
            this.Controls.Add(this.daPond1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private 基本控件.DAPond daPond1;
        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private 基本控件.DAConduit daConduit1;
        private 基本控件.DARotor daRotor1;
        private 基本控件.DAProcessWave daProcessWave1;
        private 基本控件.DAProcessEllipse daProcessEllipse1;
        private 基本控件.DABottle daBottle1;
        private 基本控件.DALedBulb daLedBulb1;
    }
}