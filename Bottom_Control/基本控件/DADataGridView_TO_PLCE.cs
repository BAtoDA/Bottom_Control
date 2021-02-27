using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bottom_Control.控件类基;

namespace Bottom_Control.基本控件
{
    /// <summary>
    /// 实现上位机底层控件 文本类 -不再公共运行时
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 定时从PLC自定寄存器读取数据  PLC读取表格类 -不再公共运行时")]
    public partial class DADataGridView_TO_PLCE : UserControl
    {

        #region 实现接口参数
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [DefaultValue(typeof(PLC), "Mitsubishi")]
        public PLC Plc { get => this.daDataGridView_TO_PLC2.Plc; set => this.daDataGridView_TO_PLC2.Plc = value; }
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable { get => this.daDataGridView_TO_PLC2.PLC_Enable; set => this.daDataGridView_TO_PLC2.PLC_Enable = value; }
        [Description("PLC读取触点"), Category("PLC类型")]
        public string PLC_Contact { get => this.daDataGridView_TO_PLC2.PLC_Contact; set => this.daDataGridView_TO_PLC2.PLC_Contact = value; }
        public string PLC_Address { get => this.daDataGridView_TO_PLC2.PLC_Address; set => this.daDataGridView_TO_PLC2.PLC_Address = value; }
        [DefaultValue(typeof(int), "8")]
        public int Decimal_Above { get => this.daDataGridView_TO_PLC2.Decimal_Above; set => this.daDataGridView_TO_PLC2.Decimal_Above = value; }
        [DefaultValue(typeof(int), "0")]
        public int Decimal_Below { get => this.daDataGridView_TO_PLC2.Decimal_Below; set => this.daDataGridView_TO_PLC2.Decimal_Below = value; }
        /// <summary>
        /// 定时刷新 定时器
        /// </summary>
        [Description("文本刷新定时器"), Category("PLC-控件参数")]
        [DefaultValue(typeof(string), "PLC_time")]
        public System.Windows.Forms.Timer PLC_time { get => this.daDataGridView_TO_PLC2.PLC_time; }
        [Description("读取PLC的地址--对应表格列"), Category("PLC-控件参数")]
        public string[] PLC_address { get => this.daDataGridView_TO_PLC2.PLC_address; set => this.daDataGridView_TO_PLC2.PLC_address = value; }
        [Description("表格列显示的名称--对应表格列"), Category("PLC-控件参数")]
        public string[] DataGridView_Name { get => this.daDataGridView_TO_PLC2.DataGridView_Name; set => this.daDataGridView_TO_PLC2.DataGridView_Name = value; }
        [Description("表格列读取PLC的类型--对应表格列"), Category("PLC-控件参数")]
        public numerical_format[] DataGridView_numerical { get => this.daDataGridView_TO_PLC2.DataGridView_numerical; set => this.daDataGridView_TO_PLC2.DataGridView_numerical = value; }
        [Description("指示着是否显示读取时间列"), Category("PLC-控件参数")]
        public bool DataGridViewPLC_Time { get => this.daDataGridView_TO_PLC2.DataGridViewPLC_Time; set => this.daDataGridView_TO_PLC2.DataGridViewPLC_Time = value; }

        #endregion
        public DADataGridView_TO_PLCE()
        {
            InitializeComponent();
            this.daDataGridView_TO_PLC2.SizeChanged += ((Send, e1) =>
              {
                  this.Size = this.daDataGridView_TO_PLC2.Size;
              });
        }

        protected override void OnParentChanged(EventArgs e)
        {
            this.daDataGridView_TO_PLC2.OnParentChanged1(new EventArgs());

        }
        private void DADataGridView_TO_PLC1_Load(object sender, EventArgs e)
        {

        }
    }
}
