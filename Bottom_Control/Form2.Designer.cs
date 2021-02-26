
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
            this.daDataGridView_TO_PLCE1 = new Bottom_Control.基本控件.DADataGridView_TO_PLCE();
            this.SuspendLayout();
            // 
            // daDataGridView_TO_PLCE1
            // 
            this.daDataGridView_TO_PLCE1.DataGridView_Name = new string[] {
        "PLC1",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.daDataGridView_TO_PLCE1.DataGridView_numerical = new Bottom_Control.numerical_format[] {
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit};
            this.daDataGridView_TO_PLCE1.DataGridViewPLC_Time = false;
            this.daDataGridView_TO_PLCE1.Location = new System.Drawing.Point(24, 12);
            this.daDataGridView_TO_PLCE1.Name = "daDataGridView_TO_PLCE1";
            this.daDataGridView_TO_PLCE1.PLC_address = new double[] {
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D};
            this.daDataGridView_TO_PLCE1.PLC_Address = "0";
            this.daDataGridView_TO_PLCE1.PLC_Contact = "D";
            this.daDataGridView_TO_PLCE1.PLC_Enable = true;
            this.daDataGridView_TO_PLCE1.Size = new System.Drawing.Size(209, 146);
            this.daDataGridView_TO_PLCE1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.daDataGridView_TO_PLCE1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private 基本控件.DADataGridView_TO_PLCE daDataGridView_TO_PLCE1;
    }
}