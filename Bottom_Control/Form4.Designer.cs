
namespace Bottom_Control
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.daAnalogMeter1 = new Bottom_Control.基本控件.DAAnalogMeter();
            this.daAlarmLamp1 = new Bottom_Control.基本控件.DAAlarmLamp();
            this.daButton2 = new Bottom_Control.DAButton();
            this.daButton1 = new Bottom_Control.DAButton();
            this.plC_Open_Time1 = new Bottom_Control.设置控件.PLC_Open_Time();
            this.daIhatetheqrcode_PLC1 = new Bottom_Control.基本控件.DAIhatetheqrcode_PLC();
            this.daCombox1 = new Bottom_Control.基本控件.DACombox();
            this.daDataGridView_PLCSQL1 = new Bottom_Control.基本控件.DADataGridView_PLCSQL();
            this.daDataGridView_TO_PLCE1 = new Bottom_Control.基本控件.DADataGridView_TO_PLCE();
            this.daDataGridView_TO_SQL1 = new Bottom_Control.基本控件.DADataGridView_TO_SQL();
            ((System.ComponentModel.ISupportInitialize)(this.daIhatetheqrcode_PLC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_PLCSQL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_TO_SQL1)).BeginInit();
            this.SuspendLayout();
            // 
            // daAnalogMeter1
            // 
            this.daAnalogMeter1.BackColor = System.Drawing.Color.Transparent;
            this.daAnalogMeter1.BodyColor = System.Drawing.Color.Transparent;
            this.daAnalogMeter1.Control_Text = "0";
            this.daAnalogMeter1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.daAnalogMeter1.ForeColor = System.Drawing.Color.Black;
            this.daAnalogMeter1.Location = new System.Drawing.Point(279, 128);
            this.daAnalogMeter1.MaxValue = 100D;
            this.daAnalogMeter1.MinValue = 0D;
            this.daAnalogMeter1.Name = "daAnalogMeter1";
            this.daAnalogMeter1.NeedleColor = System.Drawing.Color.YellowGreen;
            this.daAnalogMeter1.Plc = Bottom_Control.PLC.Siemens;
            this.daAnalogMeter1.PLC_Address = "1.0";
            this.daAnalogMeter1.PLC_Contact = "DB";
            this.daAnalogMeter1.PLC_Enable = true;
            this.daAnalogMeter1.Renderer = null;
            this.daAnalogMeter1.ScaleColor = System.Drawing.Color.Black;
            this.daAnalogMeter1.Size = new System.Drawing.Size(180, 180);
            this.daAnalogMeter1.Style = Sunny.UI.UIStyle.Custom;
            this.daAnalogMeter1.TabIndex = 3;
            this.daAnalogMeter1.Text = "daAnalogMeter1";
            this.daAnalogMeter1.Value = 0D;
            // 
            // daAlarmLamp1
            // 
            this.daAlarmLamp1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daAlarmLamp1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daAlarmLamp1.Button_select = false;
            this.daAlarmLamp1.Command = false;
            this.daAlarmLamp1.I_Flicker = true;
            this.daAlarmLamp1.I_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))))};
            this.daAlarmLamp1.I_FlickerTime = 1000;
            this.daAlarmLamp1.LampColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.daAlarmLamp1.Lampstand = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.daAlarmLamp1.Location = new System.Drawing.Point(371, 31);
            this.daAlarmLamp1.Name = "daAlarmLamp1";
            this.daAlarmLamp1.O_FlickerColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))))};
            this.daAlarmLamp1.O_FlickerTime = 1000;
            this.daAlarmLamp1.Pattern = Bottom_Control.Button_pattern.Set_as_on;
            this.daAlarmLamp1.Plc = Bottom_Control.PLC.Siemens;
            this.daAlarmLamp1.PLC_Address = "0.0";
            this.daAlarmLamp1.PLC_Contact = "Q";
            this.daAlarmLamp1.PLC_Enable = true;
            this.daAlarmLamp1.Size = new System.Drawing.Size(50, 50);
            this.daAlarmLamp1.TabIndex = 2;
            this.daAlarmLamp1.Text_OFF = "OFF";
            this.daAlarmLamp1.Text_ON = "ON";
            this.daAlarmLamp1.TwinkleSpeed = 0;
            // 
            // daButton2
            // 
            this.daButton2.BackColor = System.Drawing.Color.Transparent;
            this.daButton2.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton2.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton2.DownBack = null;
            this.daButton2.Location = new System.Drawing.Point(221, 31);
            this.daButton2.MouseBack = null;
            this.daButton2.Name = "daButton2";
            this.daButton2.NormlBack = null;
            this.daButton2.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton2.Plc = Bottom_Control.PLC.Siemens;
            this.daButton2.PLC_Address = "1.2";
            this.daButton2.PLC_Contact = "M";
            this.daButton2.PLC_Enable = true;
            this.daButton2.Size = new System.Drawing.Size(93, 49);
            this.daButton2.TabIndex = 1;
            this.daButton2.Text = "daButton2";
            this.daButton2.Text_OFF = "M1.2-OFF";
            this.daButton2.Text_ON = "M1.2-ON";
            this.daButton2.UseVisualStyleBackColor = false;
            // 
            // daButton1
            // 
            this.daButton1.BackColor = System.Drawing.Color.Transparent;
            this.daButton1.Backdrop_OFF = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.daButton1.Backdrop_ON = System.Drawing.Color.Lime;
            this.daButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.daButton1.DownBack = null;
            this.daButton1.Location = new System.Drawing.Point(51, 31);
            this.daButton1.MouseBack = null;
            this.daButton1.Name = "daButton1";
            this.daButton1.NormlBack = null;
            this.daButton1.Pattern = Bottom_Control.Button_pattern.selector_witch;
            this.daButton1.Plc = Bottom_Control.PLC.Siemens;
            this.daButton1.PLC_Address = "0.0";
            this.daButton1.PLC_Contact = "Q";
            this.daButton1.PLC_Enable = true;
            this.daButton1.Size = new System.Drawing.Size(93, 49);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "daButton1";
            this.daButton1.Text_OFF = "Q0.0-OFF";
            this.daButton1.Text_ON = "Q0.0-ON";
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // plC_Open_Time1
            // 
            this.plC_Open_Time1.Interval = 500;
            this.plC_Open_Time1.ModBusIP = "192.168.3.20";
            this.plC_Open_Time1.Siemens_Open = true;
            this.plC_Open_Time1.SiemensIP = "192.168.3.2";
            this.plC_Open_Time1.siemensPLCS = HslCommunication.Profinet.SiemensPLCS.S200Smart;
            // 
            // daIhatetheqrcode_PLC1
            // 
            this.daIhatetheqrcode_PLC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("daIhatetheqrcode_PLC1.BackgroundImage")));
            this.daIhatetheqrcode_PLC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.daIhatetheqrcode_PLC1.Control_Text = "123456789";
            this.daIhatetheqrcode_PLC1.Location = new System.Drawing.Point(30, 165);
            this.daIhatetheqrcode_PLC1.Name = "daIhatetheqrcode_PLC1";
            this.daIhatetheqrcode_PLC1.Plc = Bottom_Control.PLC.Siemens;
            this.daIhatetheqrcode_PLC1.PLC_Address = "1.20";
            this.daIhatetheqrcode_PLC1.PLC_Contact = "DB";
            this.daIhatetheqrcode_PLC1.PLC_Enable = true;
            this.daIhatetheqrcode_PLC1.select = false;
            this.daIhatetheqrcode_PLC1.Size = new System.Drawing.Size(232, 143);
            this.daIhatetheqrcode_PLC1.TabIndex = 4;
            this.daIhatetheqrcode_PLC1.TabStop = false;
            this.daIhatetheqrcode_PLC1.Text = "123456789";
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
            this.daCombox1.Location = new System.Drawing.Point(30, 340);
            this.daCombox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daCombox1.Name = "daCombox1";
            this.daCombox1.Plc = Bottom_Control.PLC.Siemens;
            this.daCombox1.PLC_Address = "1.4";
            this.daCombox1.PLC_Contact = "DB";
            this.daCombox1.PLC_Enable = true;
            this.daCombox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.daCombox1.RectWidth = 1;
            this.daCombox1.SelectedIndex = -1;
            this.daCombox1.SelectedValue = "";
            this.daCombox1.Size = new System.Drawing.Size(173, 32);
            this.daCombox1.Source = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>>)(resources.GetObject("daCombox1.Source")));
            this.daCombox1.TabIndex = 5;
            this.daCombox1.TextValue = null;
            this.daCombox1.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.daCombox1.ValuePair = new string[] {
        "向VW4写入1",
        "向VW4写入2",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            // 
            // daDataGridView_PLCSQL1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.daDataGridView_PLCSQL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daDataGridView_PLCSQL1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.daDataGridView_PLCSQL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daDataGridView_PLCSQL1.ColumnFont = null;
            this.daDataGridView_PLCSQL1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataGridView_PLCSQL1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit};
            this.daDataGridView_PLCSQL1.DataGridViewPLC_Time = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.daDataGridView_PLCSQL1.DefaultCellStyle = dataGridViewCellStyle3;
            this.daDataGridView_PLCSQL1.EnableHeadersVisualStyles = false;
            this.daDataGridView_PLCSQL1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.daDataGridView_PLCSQL1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daDataGridView_PLCSQL1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_PLCSQL1.Location = new System.Drawing.Point(465, 21);
            this.daDataGridView_PLCSQL1.Name = "daDataGridView_PLCSQL1";
            this.daDataGridView_PLCSQL1.numerical = Bottom_Control.numerical_format.Signed_16_Bit;
            this.daDataGridView_PLCSQL1.Plc = Bottom_Control.PLC.Siemens;
            this.daDataGridView_PLCSQL1.PLC_address = new string[] {
        "1.0",
        "1.1",
        "1.2",
        "1.3",
        "0",
        "0",
        "0",
        "0",
        "0",
        "0"};
            this.daDataGridView_PLCSQL1.PLC_Address = "0";
            this.daDataGridView_PLCSQL1.PLC_Contact = "DB";
            this.daDataGridView_PLCSQL1.PLC_Enable = true;
            this.daDataGridView_PLCSQL1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.daDataGridView_PLCSQL1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_PLCSQL1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.daDataGridView_PLCSQL1.RowTemplate.Height = 23;
            this.daDataGridView_PLCSQL1.Size = new System.Drawing.Size(362, 277);
            this.daDataGridView_PLCSQL1.SQL_Enable = true;
            this.daDataGridView_PLCSQL1.SqlString = "data source=DESKTOP-955LB02\\SQLEXPRESS;initial catalog=XN;persist security info=T" +
    "rue;user id=sa;password=3131458;MultipleActiveResultSets=True;App=EntityFramewor" +
    "k";
            this.daDataGridView_PLCSQL1.SqlSurface_Name = "Table_1";
            this.daDataGridView_PLCSQL1.TabIndex = 6;
            this.daDataGridView_PLCSQL1.TitleBack = null;
            this.daDataGridView_PLCSQL1.TitleBackColorBegin = System.Drawing.Color.White;
            this.daDataGridView_PLCSQL1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // daDataGridView_TO_PLCE1
            // 
            this.daDataGridView_TO_PLCE1.DataGridView_Name = new string[] {
        "VW0",
        "VW1",
        null,
        null,
        null,
        null,
        null,
        null,
        null,
        null};
            this.daDataGridView_TO_PLCE1.DataGridView_numerical = new Bottom_Control.numerical_format[] {
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Signed_16_Bit,
        Bottom_Control.numerical_format.Unsigned_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit,
        Bottom_Control.numerical_format.BCD_16_Bit};
            this.daDataGridView_TO_PLCE1.DataGridViewPLC_Time = true;
            this.daDataGridView_TO_PLCE1.Location = new System.Drawing.Point(465, 304);
            this.daDataGridView_TO_PLCE1.Name = "daDataGridView_TO_PLCE1";
            this.daDataGridView_TO_PLCE1.Plc = Bottom_Control.PLC.Siemens;
            this.daDataGridView_TO_PLCE1.PLC_address = new string[] {
        "1.0",
        "1.1",
        "0",
        "0",
        "0",
        "0",
        "0",
        "0",
        "0",
        "0"};
            this.daDataGridView_TO_PLCE1.PLC_Address = "0";
            this.daDataGridView_TO_PLCE1.PLC_Contact = "DB";
            this.daDataGridView_TO_PLCE1.PLC_Enable = true;
            this.daDataGridView_TO_PLCE1.Size = new System.Drawing.Size(362, 317);
            this.daDataGridView_TO_PLCE1.TabIndex = 7;
            // 
            // daDataGridView_TO_SQL1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.daDataGridView_TO_SQL1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.daDataGridView_TO_SQL1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.daDataGridView_TO_SQL1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.daDataGridView_TO_SQL1.ColumnFont = null;
            this.daDataGridView_TO_SQL1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataGridView_TO_SQL1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.daDataGridView_TO_SQL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daDataGridView_TO_SQL1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.daDataGridView_TO_SQL1.DefaultCellStyle = dataGridViewCellStyle7;
            this.daDataGridView_TO_SQL1.EnableHeadersVisualStyles = false;
            this.daDataGridView_TO_SQL1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.daDataGridView_TO_SQL1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daDataGridView_TO_SQL1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_TO_SQL1.Location = new System.Drawing.Point(833, 21);
            this.daDataGridView_TO_SQL1.Name = "daDataGridView_TO_SQL1";
            this.daDataGridView_TO_SQL1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.daDataGridView_TO_SQL1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.daDataGridView_TO_SQL1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.daDataGridView_TO_SQL1.RowTemplate.Height = 23;
            this.daDataGridView_TO_SQL1.Size = new System.Drawing.Size(340, 277);
            this.daDataGridView_TO_SQL1.SQL_Enable = true;
            this.daDataGridView_TO_SQL1.SqlString = "data source=DESKTOP-955LB02\\SQLEXPRESS;initial catalog=XN;persist security info=T" +
    "rue;user id=sa;password=3131458;MultipleActiveResultSets=True;App=EntityFramewor" +
    "k";
            this.daDataGridView_TO_SQL1.SqlSurface_Name = "Table_1";
            this.daDataGridView_TO_SQL1.TabIndex = 8;
            this.daDataGridView_TO_SQL1.TitleBack = null;
            this.daDataGridView_TO_SQL1.TitleBackColorBegin = System.Drawing.Color.White;
            this.daDataGridView_TO_SQL1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 596);
            this.Controls.Add(this.daDataGridView_TO_SQL1);
            this.Controls.Add(this.daDataGridView_TO_PLCE1);
            this.Controls.Add(this.daDataGridView_PLCSQL1);
            this.Controls.Add(this.daCombox1);
            this.Controls.Add(this.daIhatetheqrcode_PLC1);
            this.Controls.Add(this.daAnalogMeter1);
            this.Controls.Add(this.daAlarmLamp1);
            this.Controls.Add(this.daButton2);
            this.Controls.Add(this.daButton1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daIhatetheqrcode_PLC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_PLCSQL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daDataGridView_TO_SQL1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private 设置控件.PLC_Open_Time plC_Open_Time1;
        private DAButton daButton1;
        private DAButton daButton2;
        private 基本控件.DAAlarmLamp daAlarmLamp1;
        private 基本控件.DAAnalogMeter daAnalogMeter1;
        private 基本控件.DAIhatetheqrcode_PLC daIhatetheqrcode_PLC1;
        private 基本控件.DACombox daCombox1;
        private 基本控件.DADataGridView_PLCSQL daDataGridView_PLCSQL1;
        private 基本控件.DADataGridView_TO_PLCE daDataGridView_TO_PLCE1;
        private 基本控件.DADataGridView_TO_SQL daDataGridView_TO_SQL1;
    }
}