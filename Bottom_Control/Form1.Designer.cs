
namespace Bottom_Control
{
    partial class Form1
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
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.ucWaveChart1 = new HZH_Controls.Controls.UCWaveChart();
            this.ucValve1 = new HZH_Controls.Controls.UCValve();
            this.ucConveyor1 = new HZH_Controls.Controls.UCConveyor();
            this.daButton1 = new Bottom_Control.DAButton();
            this.SuspendLayout();
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Interval = 500;
            this.plC_Open_Time1.Mitsubishi_Open = true;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            this.plC_Open_Time1.siemensPLCS = HslCommunication.Profinet.SiemensPLCS.S200Smart;
            // 
            // ucWaveChart1
            // 
            this.ucWaveChart1.ConerRadius = 10;
            this.ucWaveChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucWaveChart1.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.GridLineTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.IsRadius = true;
            this.ucWaveChart1.IsShowRect = true;
            this.ucWaveChart1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucWaveChart1.LineTension = 0.5F;
            this.ucWaveChart1.Location = new System.Drawing.Point(752, 14);
            this.ucWaveChart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucWaveChart1.Name = "ucWaveChart1";
            this.ucWaveChart1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucWaveChart1.RectWidth = 1;
            this.ucWaveChart1.Size = new System.Drawing.Size(300, 200);
            this.ucWaveChart1.SleepTime = 1000;
            this.ucWaveChart1.TabIndex = 1;
            this.ucWaveChart1.WaveWidth = 50;
            // 
            // ucValve1
            // 
            this.ucValve1.AsisBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.LiquidColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.ucValve1.LiquidDirection = HZH_Controls.Controls.LiquidDirection.Forward;
            this.ucValve1.LiquidSpeed = 100;
            this.ucValve1.Location = new System.Drawing.Point(664, 418);
            this.ucValve1.Name = "ucValve1";
            this.ucValve1.Opened = true;
            this.ucValve1.Size = new System.Drawing.Size(120, 100);
            this.ucValve1.SwitchColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucValve1.TabIndex = 5;
            this.ucValve1.ValveColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucValve1.ValveStyle = HZH_Controls.Controls.ValveStyle.Horizontal_Top;
            // 
            // ucConveyor1
            // 
            this.ucConveyor1.ConveyorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucConveyor1.ConveyorDirection = HZH_Controls.Controls.ConveyorDirection.Forward;
            this.ucConveyor1.ConveyorHeight = 50;
            this.ucConveyor1.ConveyorSpeed = 100;
            this.ucConveyor1.Inclination = 0D;
            this.ucConveyor1.Location = new System.Drawing.Point(664, 342);
            this.ucConveyor1.Name = "ucConveyor1";
            this.ucConveyor1.Size = new System.Drawing.Size(300, 50);
            this.ucConveyor1.TabIndex = 10;
            // 
            // daButton1
            // 
            this.daButton1.BackColor = System.Drawing.Color.Transparent;
            this.daButton1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton1.DownBack = null;
            this.daButton1.Location = new System.Drawing.Point(138, 128);
            this.daButton1.MouseBack = null;
            this.daButton1.Name = "daButton1";
            this.daButton1.NormlBack = null;
            this.daButton1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daButton1.PLC_Address = "0";
            this.daButton1.PLC_Contact = "X";
            this.daButton1.PLC_Enable = false;
            this.daButton1.Size = new System.Drawing.Size(132, 86);
            this.daButton1.TabIndex = 11;
            this.daButton1.Text = "daButton1";
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 563);
            this.Controls.Add(this.daButton1);
            this.Controls.Add(this.ucConveyor1);
            this.Controls.Add(this.ucValve1);
            this.Controls.Add(this.ucWaveChart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private HZH_Controls.Controls.UCWaveChart ucWaveChart1;
        private HZH_Controls.Controls.UCValve ucValve1;
        private HZH_Controls.Controls.UCConveyor ucConveyor1;
        private DAButton daButton1;
    }
}