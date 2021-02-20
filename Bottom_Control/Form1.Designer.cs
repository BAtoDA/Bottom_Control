
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.daCombox1 = new Bottom_Control.基本控件.DACombox();
            this.ucWaveChart1 = new HZH_Controls.Controls.UCWaveChart();
            this.ucValve1 = new HZH_Controls.Controls.UCValve();
            this.ucConveyor1 = new HZH_Controls.Controls.UCConveyor();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Interval = 500;
            this.plC_Open_Time1.Mitsubishi_Open = true;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            // 
            // daCombox1
            // 
            this.daCombox1.BackColor = System.Drawing.Color.Transparent;
            this.daCombox1.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.daCombox1.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.daCombox1.ConerRadius = 5;
            this.daCombox1.Control_Text = "1";
            this.daCombox1.DropPanelHeight = -1;
            this.daCombox1.FillColor = System.Drawing.Color.White;
            this.daCombox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daCombox1.IsRadius = true;
            this.daCombox1.IsShowRect = true;
            this.daCombox1.ItemWidth = 70;
            this.daCombox1.KeyValuePair = new int[] {
        1,
        2,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0};
            this.daCombox1.Location = new System.Drawing.Point(136, 73);
            this.daCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daCombox1.Name = "daCombox1";
            this.daCombox1.PLC_Address = "0";
            this.daCombox1.PLC_Contact = "D";
            this.daCombox1.PLC_Enable = true;
            this.daCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.daCombox1.RectWidth = 1;
            this.daCombox1.SelectedIndex = 0;
            this.daCombox1.SelectedValue = "1";
            this.daCombox1.Size = new System.Drawing.Size(173, 32);
            this.daCombox1.Source = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("daCombox1.Source")));
            this.daCombox1.TabIndex = 0;
            this.daCombox1.TextValue = "PLC1";
            this.daCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daCombox1.ValuePair = new string[] {
        "PLC1",
        "PLC2",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
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
            // skinDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinDataGridView1.ColumnFont = null;
            this.skinDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView1.EnableHeadersVisualStyles = false;
            this.skinDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(94, 215);
            this.skinDataGridView1.Name = "skinDataGridView1";
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView1.RowTemplate.Height = 23;
            this.skinDataGridView1.Size = new System.Drawing.Size(415, 303);
            this.skinDataGridView1.TabIndex = 11;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 563);
            this.Controls.Add(this.skinDataGridView1);
            this.Controls.Add(this.ucConveyor1);
            this.Controls.Add(this.ucValve1);
            this.Controls.Add(this.ucWaveChart1);
            this.Controls.Add(this.daCombox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private 基本控件.DACombox daCombox1;
        private HZH_Controls.Controls.UCWaveChart ucWaveChart1;
        private HZH_Controls.Controls.UCValve ucValve1;
        private HZH_Controls.Controls.UCConveyor ucConveyor1;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}