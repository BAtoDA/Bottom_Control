
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.daCombox1 = new Bottom_Control.基本控件.DACombox();
            this.SuspendLayout();
            // 
            // daCombox1
            // 
            this.daCombox1.BackColor = System.Drawing.Color.Transparent;
            this.daCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.daCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.daCombox1.ConerRadius = 5;
            this.daCombox1.Control_Text = "";
            this.daCombox1.DropPanelHeight = -1;
            this.daCombox1.FillColor = System.Drawing.Color.White;
            this.daCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daCombox1.IsRadius = true;
            this.daCombox1.IsShowRect = true;
            this.daCombox1.ItemWidth = 70;
            this.daCombox1.KeyValuePair = new int[] {
        22,
        55,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.daCombox1.Location = new System.Drawing.Point(225, 146);
            this.daCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daCombox1.Name = "daCombox1";
            this.daCombox1.PLC_Address = "0";
            this.daCombox1.PLC_Contact = "D";
            this.daCombox1.PLC_Enable = false;
            this.daCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.daCombox1.RectWidth = 1;
            this.daCombox1.SelectedIndex = -1;
            this.daCombox1.SelectedValue = "";
            this.daCombox1.Size = new System.Drawing.Size(173, 32);
            this.daCombox1.Source = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("daCombox1.Source")));
            this.daCombox1.TabIndex = 0;
            this.daCombox1.TextValue = null;
            this.daCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daCombox1.ValuePair = new string[] {
        "dd",
        "dd",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daCombox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private 基本控件.DACombox daCombox1;
    }
}