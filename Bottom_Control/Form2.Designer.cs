
namespace Bottom_Control
{
    partial class 
        Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.daAlarmLamp1 = new Bottom_Control.基本控件.DAAlarmLamp();
            this.daSignalLamp1 = new Bottom_Control.基本控件.DASignalLamp();
            this.daLedBulb1 = new Bottom_Control.基本控件.DALedBulb();
            this.daBottle1 = new Bottom_Control.基本控件.DABottle();
            this.daProcessEllipse1 = new Bottom_Control.基本控件.DAProcessEllipse();
            this.daProcessWave1 = new Bottom_Control.基本控件.DAProcessWave();
            this.daRotor1 = new Bottom_Control.基本控件.DARotor();
            this.daConduit1 = new Bottom_Control.基本控件.DAConduit();
            this.daPond1 = new Bottom_Control.基本控件.DAPond();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.daDataGridView_TO_PLC1 = new Bottom_Control.基本控件.DADataGridView_TO_PLC();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doughnut_PLC1 = new Bottom_Control.基本控件.Doughnut_PLC();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_TO_PLC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doughnut_PLC1)).BeginInit();
            this.SuspendLayout();
            // 
            // daAlarmLamp1
            // 
            this.daAlarmLamp1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daAlarmLamp1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daAlarmLamp1.I_Flicker = true;
            this.daAlarmLamp1.I_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.Silver};
            this.daAlarmLamp1.I_FlickerTime = 1000;
            this.daAlarmLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.daAlarmLamp1.Lampstand = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.daAlarmLamp1.Location = new System.Drawing.Point(112, 160);
            this.daAlarmLamp1.Name = "daAlarmLamp1";
            this.daAlarmLamp1.O_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.daAlarmLamp1.O_FlickerTime = 1000;
            this.daAlarmLamp1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daAlarmLamp1.PLC_Address = "20";
            this.daAlarmLamp1.PLC_Contact = "Y";
            this.daAlarmLamp1.PLC_Enable = true;
            this.daAlarmLamp1.Size = new System.Drawing.Size(50, 50);
            this.daAlarmLamp1.TabIndex = 8;
            this.daAlarmLamp1.TwinkleSpeed = 0;
            // 
            // daSignalLamp1
            // 
            this.daSignalLamp1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daSignalLamp1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daSignalLamp1.I_Flicker = true;
            this.daSignalLamp1.I_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))))};
            this.daSignalLamp1.I_FlickerTime = 1000;
            this.daSignalLamp1.IsHighlight = true;
            this.daSignalLamp1.IsShowBorder = false;
            this.daSignalLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.daSignalLamp1.Location = new System.Drawing.Point(239, 215);
            this.daSignalLamp1.Name = "daSignalLamp1";
            this.daSignalLamp1.O_Flicker = true;
            this.daSignalLamp1.O_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.Gray,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))))};
            this.daSignalLamp1.O_FlickerTime = 1000;
            this.daSignalLamp1.Pattern = Bottom_Control.Button_pattern.Regression;
            this.daSignalLamp1.PLC_Address = "20";
            this.daSignalLamp1.PLC_Contact = "Y";
            this.daSignalLamp1.PLC_Enable = true;
            this.daSignalLamp1.Size = new System.Drawing.Size(50, 50);
            this.daSignalLamp1.TabIndex = 7;
            this.daSignalLamp1.TwinkleSpeed = 0;
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
            this.plC_Open_Time1.MitsubishiIP = "192.168.3.105";
            this.plC_Open_Time1.MitsubishiPort = 506;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            // 
            // daDataGridView_TO_PLC1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.daDataGridView_TO_PLC1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daDataGridView_TO_PLC1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.daDataGridView_TO_PLC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daDataGridView_TO_PLC1.ColumnFont = null;
            this.daDataGridView_TO_PLC1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataGridView_TO_PLC1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.daDataGridView_TO_PLC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daDataGridView_TO_PLC1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_TO_PLC1.Control_Text = "";
            this.daDataGridView_TO_PLC1.DataGridView_Name = new string[] {
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
            this.daDataGridView_TO_PLC1.DataGridView_numerical = new Bottom_Control.numerical_format[] {
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit};
            this.daDataGridView_TO_PLC1.DataGridViewPLC_Time = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.daDataGridView_TO_PLC1.DefaultCellStyle = dataGridViewCellStyle3;
            this.daDataGridView_TO_PLC1.EnableHeadersVisualStyles = false;
            this.daDataGridView_TO_PLC1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.daDataGridView_TO_PLC1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daDataGridView_TO_PLC1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_TO_PLC1.Location = new System.Drawing.Point(379, 12);
            this.daDataGridView_TO_PLC1.Name = "daDataGridView_TO_PLC1";
            this.daDataGridView_TO_PLC1.PLC_address = new double[] {
        0D,
        1D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D};
            this.daDataGridView_TO_PLC1.PLC_Address = "0";
            this.daDataGridView_TO_PLC1.PLC_Contact = "D";
            this.daDataGridView_TO_PLC1.PLC_Enable = true;
            this.daDataGridView_TO_PLC1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.daDataGridView_TO_PLC1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_TO_PLC1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.daDataGridView_TO_PLC1.RowTemplate.Height = 23;
            this.daDataGridView_TO_PLC1.Size = new System.Drawing.Size(380, 150);
            this.daDataGridView_TO_PLC1.TabIndex = 10;
            this.daDataGridView_TO_PLC1.TitleBack = null;
            this.daDataGridView_TO_PLC1.TitleBackColorBegin = System.Drawing.Color.White;
            this.daDataGridView_TO_PLC1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.daDataGridView_TO_PLC1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daDataGridView_TO_PLC1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "PLC1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "PLC1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PLC2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "PLC2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "读取PLC时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "读取PLC时间";
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "PLC1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "PLC1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "PLC2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "PLC2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "读取PLC时间";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "读取PLC时间";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // doughnut_PLC1
            // 
            this.doughnut_PLC1.background_colo = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.doughnut_PLC1.ChartAreas.Add(chartArea1);
            this.doughnut_PLC1.color = System.Drawing.Color.Yellow;
            this.doughnut_PLC1.Control_Text = "doughnut_PLC1";
            this.doughnut_PLC1.DataGridView_Name = new string[] {
        "PLC2",
        "PLC3",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.doughnut_PLC1.DataGridView_numerical = new Bottom_Control.numerical_format[] {
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit};
            this.doughnut_PLC1.DataGridViewPLC_Time = false;
            this.doughnut_PLC1.doughnut_Chart_Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.doughnut_PLC1.doughnut_Chart_Name = "Chart1";
            this.doughnut_PLC1.doughnut_Chart_Text = "Chart_Text";
            legend1.Name = "Legend1";
            this.doughnut_PLC1.Legends.Add(legend1);
            this.doughnut_PLC1.Location = new System.Drawing.Point(392, 215);
            this.doughnut_PLC1.Name = "doughnut_PLC1";
            this.doughnut_PLC1.numerical = Bottom_Control.numerical_format.Signed_16_Bit;
            this.doughnut_PLC1.PLC_address = new double[] {
        0D,
        1D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D,
        0D};
            this.doughnut_PLC1.PLC_Address = "0";
            this.doughnut_PLC1.PLC_Contact = "D";
            this.doughnut_PLC1.PLC_Enable = true;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.doughnut_PLC1.Series.Add(series1);
            this.doughnut_PLC1.Size = new System.Drawing.Size(300, 300);
            this.doughnut_PLC1.TabIndex = 11;
            this.doughnut_PLC1.Text = "doughnut_PLC1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.doughnut_PLC1);
            this.Controls.Add(this.daDataGridView_TO_PLC1);
            this.Controls.Add(this.daAlarmLamp1);
            this.Controls.Add(this.daSignalLamp1);
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
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_TO_PLC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doughnut_PLC1)).EndInit();
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
        private 基本控件.DASignalLamp daSignalLamp1;
        private 基本控件.DAAlarmLamp daAlarmLamp1;
        private 基本控件.DADataGridView_TO_PLC daDataGridView_TO_PLC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private 基本控件.Doughnut_PLC doughnut_PLC1;
    }
}