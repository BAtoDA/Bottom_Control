
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
            this.daSwitch1 = new Bottom_Control.基本控件.DASwitch();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.SuspendLayout();
            // 
            // daSwitch1
            // 
            this.daSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.daSwitch1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daSwitch1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daSwitch1.Checked = false;
            this.daSwitch1.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.daSwitch1.FalseTextColr = System.Drawing.Color.White;
            this.daSwitch1.Location = new System.Drawing.Point(427, 176);
            this.daSwitch1.Name = "daSwitch1";
            this.daSwitch1.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daSwitch1.Plc = Bottom_Control.PLC.Siemens;
            this.daSwitch1.PLC_Address = "0.0";
            this.daSwitch1.PLC_Contact = "Q";
            this.daSwitch1.PLC_Enable = true;
            this.daSwitch1.Size = new System.Drawing.Size(83, 31);
            this.daSwitch1.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.daSwitch1.TabIndex = 0;
            this.daSwitch1.Texts = null;
            this.daSwitch1.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daSwitch1.TrueTextColr = System.Drawing.Color.White;
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Interval = 500;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            this.plC_Open_Time1.Siemens_Open = true;
            this.plC_Open_Time1.SiemensIP = "192.168.3.2";
            this.plC_Open_Time1.siemensPLCS = HslCommunication.Profinet.SiemensPLCS.S200Smart;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daSwitch1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private 基本控件.DASwitch daSwitch1;
    }
}