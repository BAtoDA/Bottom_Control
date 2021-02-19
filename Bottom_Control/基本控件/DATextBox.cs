﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bottom_Control.PLC参数设置界面;
using Bottom_Control.按钮__TO__PLC方法;
using Bottom_Control.控件类基;
using Bottom_Control.文本__TO__PLC方法;
using CCWin;
using 自定义Uppercomputer_20200727;
using 自定义Uppercomputer_20200727.文本输入键盘;

namespace Bottom_Control.基本控件
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/18 11:14:27 
    //  文件名：DATextBox 
    //  版本：V1.0.1  
    //  说明： 实现控件
    //  修改者：***
    //  修改说明： 
    //==============================================================
    /// <summary>
    /// 实现上位机底层控件 文本类 -不再公共运行时
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 文本类 -不再公共运行时 ")]
    public class DATextBox : CCWin.SkinControl.SkinTextBox, TextBox_base
    {
        #region 实现接口参数
        public event EventHandler Modification;
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
        public string Control_Text { get => this.Text; set=>this.Text=value; }
        /// <summary>
        /// 定时刷新 定时器
        /// </summary>
        [Description("文本刷新定时器"), Category("PLC-控件参数")]
        [DefaultValue(typeof(string), "PLC_time")]
        public System.Windows.Forms.Timer PLC_time { get; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 200 };
        /// <summary>
        /// PLC通讯对象
        /// </summary>
        TextBox_PLC pLC;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public DATextBox()
        {
            pLC = new TextBox_PLC();
            PLC_time.Start();
            PLC_time.Tick += new EventHandler(Time_tick);
            this.Text = "00";
        }
        bool write_ok=false;//太久用户不输入文本自动允许PLC写入数据
        protected override void OnClick(EventArgs e)//方法重写实现用户双击控件---进入键盘—实现参数写入与约束
        {
            /// <方法定时擦除用户是否在输入>
            write_ok = false;//不允许修改控件
            if (this.numerical.ToString() == "Hex_16_Bit" || this.numerical.ToString() == "Hex_32_Bit" || this.Plc.ToString()== "HMI")
            {
                keyboard_Hex board_Hex = new keyboard_Hex(this.Text, this);//实例化Hex键盘
                board_Hex.ShowDialog();//显示窗口
                this.Text = board_Hex.O_Text;//获取用户输入的文本
            }
            else
            {
                keyboard board = new keyboard(this.Text, this);//调出键盘
                board.ShowDialog();//显示窗口
                this.Text = board.O_Text;//获取用户输入的文本
            }
            write_ok = true;//允许修改控件
            //把控件文本写到PLC
            pLC.plc(this);
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
