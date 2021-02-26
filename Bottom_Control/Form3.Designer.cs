
namespace Bottom_Control
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.daDataGridView_PLCSQL1 = new Bottom_Control.基本控件.DADataGridView_PLCSQL();
            this.daButton1 = new Bottom_Control.DAButton();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_PLCSQL1)).BeginInit();
            this.SuspendLayout();
            // 
            // daDataGridView_PLCSQL1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.daDataGridView_PLCSQL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.daDataGridView_PLCSQL1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.daDataGridView_PLCSQL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daDataGridView_PLCSQL1.ColumnFont = null;
            this.daDataGridView_PLCSQL1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataGridView_PLCSQL1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.daDataGridView_PLCSQL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daDataGridView_PLCSQL1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_PLCSQL1.Control_Text = "";
            this.daDataGridView_PLCSQL1.DataGridView_Name = new string[] {
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.daDataGridView_PLCSQL1.DataGridView_numerical = new Bottom_Control.numerical_format[] {
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
            this.daDataGridView_PLCSQL1.DataGridViewPLC_Time = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.daDataGridView_PLCSQL1.DefaultCellStyle = dataGridViewCellStyle7;
            this.daDataGridView_PLCSQL1.EnableHeadersVisualStyles = false;
            this.daDataGridView_PLCSQL1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.daDataGridView_PLCSQL1.HeadFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daDataGridView_PLCSQL1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_PLCSQL1.Location = new System.Drawing.Point(39, 66);
            this.daDataGridView_PLCSQL1.Name = "daDataGridView_PLCSQL1";
            this.daDataGridView_PLCSQL1.numerical = Bottom_Control.numerical_format.Signed_16_Bit;
            this.daDataGridView_PLCSQL1.PLC_address = new double[] {
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
            this.daDataGridView_PLCSQL1.PLC_Address = "0";
            this.daDataGridView_PLCSQL1.PLC_Contact = "D";
            this.daDataGridView_PLCSQL1.PLC_Enable = true;
            this.daDataGridView_PLCSQL1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.daDataGridView_PLCSQL1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_PLCSQL1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.daDataGridView_PLCSQL1.RowTemplate.Height = 23;
            this.daDataGridView_PLCSQL1.Size = new System.Drawing.Size(240, 150);
            this.daDataGridView_PLCSQL1.SQL_Enable = true;
            this.daDataGridView_PLCSQL1.SqlString = "data source=DESKTOP-955LB02\\SQLEXPRESS;initial catalog=XN;persist security info=T" +
    "rue;user id=sa;password=3131458;MultipleActiveResultSets=True;App=EntityFramewor" +
    "k";
            this.daDataGridView_PLCSQL1.SqlSurface_Name = "Table_1";
            this.daDataGridView_PLCSQL1.TabIndex = 3;
            this.daDataGridView_PLCSQL1.TitleBack = null;
            this.daDataGridView_PLCSQL1.TitleBackColorBegin = System.Drawing.Color.White;
            this.daDataGridView_PLCSQL1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // daButton1
            // 
            this.daButton1.BackColor = System.Drawing.Color.Transparent;
            this.daButton1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton1.DownBack = null;
            this.daButton1.Location = new System.Drawing.Point(39, 222);
            this.daButton1.MouseBack = null;
            this.daButton1.Name = "daButton1";
            this.daButton1.NormlBack = null;
            this.daButton1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daButton1.PLC_Address = "0";
            this.daButton1.PLC_Contact = "X";
            this.daButton1.PLC_Enable = false;
            this.daButton1.Size = new System.Drawing.Size(112, 48);
            this.daButton1.TabIndex = 4;
            this.daButton1.Text = "daButton1";
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.daButton1);
            this.Controls.Add(this.daDataGridView_PLCSQL1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_PLCSQL1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private 基本控件.DADataGridView_PLCSQL daDataGridView_PLCSQL1;
        private DAButton daButton1;
    }
}