
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
            this.daButton1 = new Bottom_Control.DAButton();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.daButton2 = new Bottom_Control.DAButton();
            this.daButton3 = new Bottom_Control.DAButton();
            this.daButton4 = new Bottom_Control.DAButton();
            this.daTextBox1 = new Bottom_Control.基本控件.DATextBox();
            this.daAnalogMeter1 = new Bottom_Control.基本控件.DAAnalogMeter();
            this.ucCombox1 = new HZH_Controls.Controls.UCCombox();
            this.SuspendLayout();
            // 
            // daButton1
            // 
            this.daButton1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daButton1.Location = new System.Drawing.Point(341, 238);
            this.daButton1.Name = "daButton1";
            this.daButton1.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton1.PLC_Address = "20";
            this.daButton1.PLC_Contact = "Y";
            this.daButton1.PLC_Enable = true;
            this.daButton1.Size = new System.Drawing.Size(100, 35);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "daButton1";
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Mitsubishi_Open = true;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            // 
            // daButton2
            // 
            this.daButton2.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton2.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daButton2.Location = new System.Drawing.Point(341, 288);
            this.daButton2.Name = "daButton2";
            this.daButton2.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton2.PLC_Address = "20";
            this.daButton2.PLC_Contact = "Y";
            this.daButton2.PLC_Enable = true;
            this.daButton2.Size = new System.Drawing.Size(100, 35);
            this.daButton2.TabIndex = 1;
            this.daButton2.Text = "daButton2";
            // 
            // daButton3
            // 
            this.daButton3.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton3.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daButton3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daButton3.Location = new System.Drawing.Point(341, 342);
            this.daButton3.Name = "daButton3";
            this.daButton3.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton3.PLC_Address = "20";
            this.daButton3.PLC_Contact = "Y";
            this.daButton3.PLC_Enable = true;
            this.daButton3.Size = new System.Drawing.Size(100, 35);
            this.daButton3.TabIndex = 2;
            this.daButton3.Text = "daButton3";
            // 
            // daButton4
            // 
            this.daButton4.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton4.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daButton4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daButton4.Location = new System.Drawing.Point(341, 394);
            this.daButton4.Name = "daButton4";
            this.daButton4.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton4.PLC_Address = "20";
            this.daButton4.PLC_Contact = "Y";
            this.daButton4.PLC_Enable = true;
            this.daButton4.Size = new System.Drawing.Size(100, 35);
            this.daButton4.TabIndex = 3;
            this.daButton4.Text = "daButton4";
            // 
            // daTextBox1
            // 
            this.daTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.daTextBox1.Control_Text = "daTextBox1";
            this.daTextBox1.DownBack = null;
            this.daTextBox1.Icon = null;
            this.daTextBox1.IconIsButton = false;
            this.daTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.daTextBox1.IsPasswordChat = '\0';
            this.daTextBox1.IsSystemPasswordChar = false;
            this.daTextBox1.Lines = new string[] {
        "daTextBox1"};
            this.daTextBox1.Location = new System.Drawing.Point(485, 238);
            this.daTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.daTextBox1.MaxLength = 32767;
            this.daTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.daTextBox1.MouseBack = null;
            this.daTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.daTextBox1.Multiline = false;
            this.daTextBox1.Name = "daTextBox1";
            this.daTextBox1.NormlBack = null;
            this.daTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.daTextBox1.PLC_Address = "20";
            this.daTextBox1.PLC_Contact = "D";
            this.daTextBox1.PLC_Enable = true;
            this.daTextBox1.ReadOnly = false;
            this.daTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.daTextBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.daTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.daTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.daTextBox1.SkinTxt.Name = "BaseText";
            this.daTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.daTextBox1.SkinTxt.TabIndex = 0;
            this.daTextBox1.SkinTxt.Text = "daTextBox1";
            this.daTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.daTextBox1.SkinTxt.WaterText = "";
            this.daTextBox1.TabIndex = 4;
            this.daTextBox1.Text = "daTextBox1";
            this.daTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.daTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.daTextBox1.WaterText = "";
            this.daTextBox1.WordWrap = true;
            // 
            // daAnalogMeter1
            // 
            this.daAnalogMeter1.BackColor = System.Drawing.Color.Transparent;
            this.daAnalogMeter1.BodyColor = System.Drawing.Color.Transparent;
            this.daAnalogMeter1.Control_Text = "0";
            this.daAnalogMeter1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daAnalogMeter1.ForeColor = System.Drawing.Color.Black;
            this.daAnalogMeter1.Location = new System.Drawing.Point(105, 41);
            this.daAnalogMeter1.MaxValue = 100D;
            this.daAnalogMeter1.MinValue = 0D;
            this.daAnalogMeter1.Name = "daAnalogMeter1";
            this.daAnalogMeter1.NeedleColor = System.Drawing.Color.YellowGreen;
            this.daAnalogMeter1.PLC_Address = "20";
            this.daAnalogMeter1.PLC_Contact = "D";
            this.daAnalogMeter1.PLC_Enable = true;
            this.daAnalogMeter1.Renderer = null;
            this.daAnalogMeter1.ScaleColor = System.Drawing.Color.Black;
            this.daAnalogMeter1.Size = new System.Drawing.Size(180, 180);
            this.daAnalogMeter1.Style = Sunny.UI.UIStyle.Custom;
            this.daAnalogMeter1.TabIndex = 5;
            this.daAnalogMeter1.Text = "daAnalogMeter1";
            this.daAnalogMeter1.Value = 0D;
            // 
            // ucCombox1
            // 
            this.ucCombox1.BackColor = System.Drawing.Color.Transparent;
            this.ucCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ucCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.ucCombox1.ConerRadius = 5;
            this.ucCombox1.DropPanelHeight = -1;
            this.ucCombox1.FillColor = System.Drawing.Color.White;
            this.ucCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ucCombox1.IsRadius = true;
            this.ucCombox1.IsShowRect = true;
            this.ucCombox1.ItemWidth = 70;
            this.ucCombox1.Location = new System.Drawing.Point(267, 51);
            this.ucCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCombox1.Name = "ucCombox1";
            this.ucCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucCombox1.RectWidth = 1;
            this.ucCombox1.SelectedIndex = -1;
            this.ucCombox1.SelectedValue = "";
            this.ucCombox1.Size = new System.Drawing.Size(173, 32);
            this.ucCombox1.Source = null;
            this.ucCombox1.TabIndex = 6;
            this.ucCombox1.TextValue = null;
            this.ucCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucCombox1);
            this.Controls.Add(this.daAnalogMeter1);
            this.Controls.Add(this.daTextBox1);
            this.Controls.Add(this.daButton4);
            this.Controls.Add(this.daButton3);
            this.Controls.Add(this.daButton2);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DAButton daButton1;
        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private DAButton daButton2;
        private DAButton daButton3;
        private DAButton daButton4;
        private 基本控件.DATextBox daTextBox1;
        private 基本控件.DAAnalogMeter daAnalogMeter1;
        private HZH_Controls.Controls.UCCombox ucCombox1;
    }
}