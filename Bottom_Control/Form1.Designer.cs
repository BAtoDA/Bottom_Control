
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
            this.daButton1 = new Bottom_Control.DAButton();
            this.daButton2 = new Bottom_Control.DAButton();
            this.SuspendLayout();
            // 
            // daButton1
            // 
            this.daButton1.BackColor = System.Drawing.Color.Transparent;
            this.daButton1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton1.DownBack = null;
            this.daButton1.Location = new System.Drawing.Point(225, 124);
            this.daButton1.MouseBack = null;
            this.daButton1.Name = "daButton1";
            this.daButton1.NormlBack = null;
            this.daButton1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daButton1.PLC_Address = "0";
            this.daButton1.PLC_Contact = "X";
            this.daButton1.PLC_Enable = false;
            this.daButton1.Size = new System.Drawing.Size(120, 78);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "daButton1";
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // daButton2
            // 
            this.daButton2.BackColor = System.Drawing.Color.Transparent;
            this.daButton2.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton2.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton2.DownBack = null;
            this.daButton2.Location = new System.Drawing.Point(491, 170);
            this.daButton2.MouseBack = null;
            this.daButton2.Name = "daButton2";
            this.daButton2.NormlBack = null;
            this.daButton2.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daButton2.Plc = Bottom_Control.PLC.Siemens;
            this.daButton2.PLC_Address = "0";
            this.daButton2.PLC_Contact = "I";
            this.daButton2.PLC_Enable = true;
            this.daButton2.Size = new System.Drawing.Size(75, 23);
            this.daButton2.TabIndex = 1;
            this.daButton2.Text = "daButton2";
            this.daButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daButton2);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DAButton daButton1;
        private DAButton daButton2;
    }
}