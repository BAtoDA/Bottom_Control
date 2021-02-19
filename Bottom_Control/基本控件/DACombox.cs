using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bottom_Control.PLC参数设置界面;
using Bottom_Control.按钮__TO__PLC方法;
using Bottom_Control.控件类基;
using Bottom_Control.文本__TO__PLC方法;
using HZH_Controls.Controls;

namespace Bottom_Control.基本控件
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/19 8:46:43 
    //  文件名：DACombox 
    //  版本：V1.0.1  
    //  说明： 实现控件上下左右对齐
    //  修改者：***
    //  修改说明： 
    //==============================================================
    class DACombox: UCCombox, TextBox_base, Combox_base
    {
        #region 实现接口参数
        public event EventHandler Modification;
        public event EventHandler Combox_Modification;
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [DefaultValue(typeof(PLC), "Mitsubishi")]
        public PLC Plc
        {
            get => pLC_valu;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(Modifications_Eeve);
                    this.Modification(Convert.ToInt32(pLC_valu), new EventArgs());
                    this.Modification -= new EventHandler(Modifications_Eeve);
                }
            }
        }
        private PLC pLC_valu;
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        private bool plc_Enable = false;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            TextboxDForm1 buttonBitForm = new TextboxDForm1(Convert.ToInt32(send), PLC_Contact, PLC_Address);
            buttonBitForm.ShowDialog();
            if (buttonBitForm.PLC_parameter.Length < 1) return;
            pLC_valu = buttonBitForm.pLC;
            PLC_Contact = buttonBitForm.PLC_parameter[1];
            plc_Address = buttonBitForm.PLC_parameter[2];
        }
        [Description("PLC读取触点"), Category("PLC类型")]
        public string PLC_Contact
        {
            get => plc_Contact;
            set
            {
                if (value == null || !TextBox_PLC.IsNull(value, Plc))
                    throw new Exception("参数设置错误");
                plc_Contact = value;
            }
        }
        private string plc_Contact = "D";
        [Description("PLC访问地址"), Category("PLC类型")]
        public string PLC_Address
        {
            get => plc_Address;
            set
            {
                if (Button_PLC.Address(value))
                    plc_Address = value;
            }
        }
        private string plc_Address = "0";
        [Description("设置访问PLC的类型 包含显示数据的类型"), Category("PLC-控件参数")]
        [DefaultValue(typeof(numerical_format), "Signed_16_Bit")]
        public numerical_format numerical { get; set; } = numerical_format.Signed_16_Bit;
        [Description("设置访问PLC小数点以上几位"), Category("PLC-控件参数")]
        [DefaultValue(typeof(int), "8")]
        public int Decimal_Above { get; set; } = 8;
        [Description("设置访问PLC小数点以下几位"), Category("PLC-控件参数")]
        [DefaultValue(typeof(int), "0")]
        public int Decimal_Below { get; set; } = 0;
        public string Control_Text { get => this.Text; set => this.Text = value; }
        /// <summary>
        /// 定时刷新 定时器
        /// </summary>
        [Description("文本刷新定时器"), Category("PLC-控件参数")]
        [DefaultValue(typeof(string), "PLC_time")]
        public System.Windows.Forms.Timer PLC_time { get; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 200 };
        [Description("下拉菜单参数"), Category("PLC-控件参数")]
        public List<KeyValuePair<int, string>> KeyValuePair 
        {
            get => keyValue;
            set
            {
                this.Combox_Modification += Combox_Modifications_Eeve;
                this.Combox_Modification(keyValue, new EventArgs());
                this.Combox_Modification -= Combox_Modifications_Eeve;
            }
        }
        private List<KeyValuePair<int, string>> keyValue = new List<KeyValuePair<int, string>>() { new KeyValuePair<int, string>(1, "PLC1") };
        public void Combox_Modifications_Eeve(object send, EventArgs e)
        {
            ComboxForm1 buttonBitForm = new ComboxForm1(KeyValuePair);
            buttonBitForm.ShowDialog();
            if (buttonBitForm.keyValuePairs.Count>0) return;
            keyValue = buttonBitForm.keyValuePairs;
        }
        /// <summary>
        /// PLC通讯对象
        /// </summary>
        TextBox_PLC pLC;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public DACombox()
        {
            pLC = new TextBox_PLC();
            PLC_time.Start();
            PLC_time.Tick += new EventHandler(Time_tick);
        }
        private new void SelectedChangedEvent(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 定时器到达事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void Time_tick(object send, EventArgs e)
        {
            lock (this)
            {
                pLC.Refresh(this);
            }
        }
    }
}
