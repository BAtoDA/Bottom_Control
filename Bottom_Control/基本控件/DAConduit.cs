﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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
    //  时间：2021/2/20 11:05:55 
    //  文件名：DAConduit 
    //  版本：V1.0.1  
    //  说明： 实现上位机底层控件 管道类 -不再公共运行时
    //  修改者：***
    //  修改说明： 
    //==============================================================
    /// <summary>
    /// 实现上位机底层控件 管道类 -不再公共运行时
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 管道类 -不再公共运行时")]
    class DAConduit:UCConduit, Button_base
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
                pLC_valu = value;
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
            ButtonBitForm1 buttonBitForm = new ButtonBitForm1(Convert.ToInt32(send), PLC_Contact, PLC_Address);
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
                if (value == null || !Button_PLC.IsNull(value, Plc))
                    throw new Exception("参数设置错误");
                plc_Contact = value;
            }
        }
        private string plc_Contact = "X";
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
        [Description("按钮参数 ON时触发背景颜色"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(Color), "111, 168, 255")]
        public Color Backdrop_ON { get; set; } = Color.FromName("Lime");
        [Description("按钮参数 OFF时触发背景颜色"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(Color), "Control")]
        public Color Backdrop_OFF { get; set; } = Color.FromArgb(74, 131, 229);
        [Description("按钮按下状态"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(bool), "false")]
        public bool Command { get; set; }
        [Description("按钮类型选择 true 位指示灯 false 位处理"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(bool), "false")]
        public bool Button_select { get; set; }
        [Description("按钮操作模式"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(Button_pattern), "复归型")]
        public Button_pattern Pattern { get; set; } = Button_pattern.Regression;
        [Description("控件为ON时显示的文本值"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(string), "ON")]
        public string Text_ON { get; set; } = "ON";
        [Description("控件为OFF时显示的文本值"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(string), "OFF")]
        public string Text_OFF { get; set; } = "OFF";
        /// <summary>
        /// 定时刷新 定时器
        /// </summary>
        [Description("按钮刷新定时器"), Category("PLC-按钮参数")]
        [DefaultValue(typeof(string), "PLC_time")]
        public System.Windows.Forms.Timer PLC_time { get; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 200 };
        /// <summary>
        /// PLC通讯协议对象
        /// </summary>
        Button_PLC plc;
        #endregion
        public DAConduit()
        {
            plc = new Button_PLC();
            PLC_time.Start();
            PLC_time.Tick += new EventHandler(Time_tick);
        }
        protected override void Dispose(bool disposing)//释放托管资源
        {
            base.Dispose(disposing);
            plc.Dispose();
            this.PLC_time.Dispose();
        }
        /// <summary>
        /// 定时器到达事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void Time_tick(object send, EventArgs e)
        {
            if (!plc_Enable) return;//用户不开启PLC功能
            plc.Refresh(this, this.Plc);
        }
    }
}
