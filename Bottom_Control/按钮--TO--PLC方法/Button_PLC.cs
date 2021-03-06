﻿using Bottom_Control.PLC通讯协议;
using Bottom_Control.基本控件;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bottom_Control.按钮__TO__PLC方法
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/17 17:20:25 
    //  文件名：Button_PLC 
    //  版本：V1.0.1  
    //  说明： 处理按钮类 点击事件写入到PLC
    //  修改者：***
    //  修改说明： 
    //==============================================================
    class Button_PLC : IDisposable
    {
        public bool state = false;//定义标志位--复归型按钮-判断状态
        public string plc(Button_base Button)//根据PLC类型写入
        {
            string pLC = Button.Plc.ToString();
            switch (pLC)
            {
                case "Mitsubishi"://三菱有二种模式 --在线与仿真

                    IPLC_interface mitsubishi = new Mitsubishi_realize();//实例化接口--实现三菱在线访问
                    if (mitsubishi.PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select(Button.Pattern.ToString(), mitsubishi, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户

                    break;
                case "Siemens":
                    IPLC_interface Siemens = new Siemens_realize();//实例化接口--实现西门子在线访问
                    if (Siemens.PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select(Button.Pattern.ToString(), Siemens, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户
                    break;
                case "Modbus_TCP":
                    MODBUD_TCP MODBUD_TCP = new MODBUD_TCP();//实例化接口--实现MODBUS TCP
                    if (MODBUD_TCP.IPLC_interface_PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select(Button.Pattern.ToString(), "MODBUD_TCP", MODBUD_TCP, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户
                    break;

            }
            return "OK";
        }
        public string plc(Button_base Button, bool state)//根据PLC类型写入--为复归型按钮使用
        {
            string pLC = Button.Plc.ToString();
            switch (pLC)
            {
                case "Mitsubishi":
                    IPLC_interface mitsubishi = new Mitsubishi_realize();//实例化接口--实现三菱在线访问
                    if (mitsubishi.PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select("复归型_Off", mitsubishi, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户

                    break;
                case "Siemens":
                    IPLC_interface Siemens = new Siemens_realize();//实例化接口--实现西门子在线访问
                    if (Siemens.PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select("复归型_Off", Siemens, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户
                    break;
                case "Modbus_TCP":
                    MODBUD_TCP MODBUD_TCP = new MODBUD_TCP();//实例化接口--实现三菱仿真
                    if (MODBUD_TCP.IPLC_interface_PLC_ready)//PLC是否准备完成
                    {
                        Button_write_select("复归型_Off", "MODBUD_TCP", MODBUD_TCP, Button);//根据按钮模式进行写入操作
                    }
                    else MessageBox.Show("未连接设备：" + pLC.Trim(), "Err");//推出异常提示用户
                    break;
            }
            return "OK";
        }
        private void Button_write_select(string Name, IPLC_interface pLC_Interface, Button_base Button)//按照按钮模式写入
        {
            //string[] Data = Button_Class(Button);
            switch (Name)
            {
                case "Set_as_on"://设置常ON
                    if (Button.Command)
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact,Button.PLC_Address, Button_state.ON);//写入常ON
                    else
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.ON);//写入常ON
                    break;
                case "Set_as_off"://设置常OFF
                    if (Button.Command)
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.Off);//写入常Off
                    else
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.Off);//写入常Off
                    break;
                case "selector_witch":
                    if (Button.Command)
                    {
                        List<bool> data = pLC_Interface.PLC_read_M_bit(Button.PLC_Contact, Button.PLC_Address);//先读取要写入的状态
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, data[0] == true ? Button_state.Off : Button_state.ON);//根据要写入的状态进行取反
                    }
                    else
                    {
                        List<bool> data = pLC_Interface.PLC_read_M_bit(Button.PLC_Contact, Button.PLC_Address);//先读取要写入的状态
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, data[0] == true ? Button_state.Off : Button_state.ON);//根据要写入的状态进行取反
                    }
                    break;
                case "Regression":
                    if (Button.Command)
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.ON);//先写入ON--后用事件复位-off
                    else
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.ON);//先写入ON--后用事件复位-off
                    state = true;//标志位                      
                    break;
                case "复归型_Off":
                    if (Button.Command)
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.Off);//先写入ON--后用事件复位-off
                    else
                        pLC_Interface.PLC_write_M_bit(Button.PLC_Contact, Button.PLC_Address, Button_state.Off);//先写入ON--后用事件复位-off
                    state = false;//标志位
                    break;
            }
        }
        private void Button_write_select(string Name, string modbus_tcp, MODBUD_TCP pLC_Interface, Button_base button)//按照按钮模式写入
        {
            switch (Name)
            {
                case "Set_as_on"://设置常ON
                    if (button.Command)
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.ON);//写入常ON
                    else
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.ON);//写入常ON
                    break;
                case "Set_as_off"://设置常OFF
                    if (button.Command)
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.Off);//写入常Off
                    else
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.Off);//写入常Off
                    break;
                case "selector_witch":
                    if (button.Command)
                    {
                        List<bool> data = pLC_Interface.IPLC_interface_PLC_read_M_bit(button.PLC_Contact, button.PLC_Address);//先读取要写入的状态
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, data[0] == true ? Button_state.Off : Button_state.ON);//根据要写入的状态进行取反
                    }
                    else
                    {
                        List<bool> data = pLC_Interface.IPLC_interface_PLC_read_M_bit(button.PLC_Contact, button.PLC_Address);//先读取要写入的状态
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, data[0] == true ? Button_state.Off : Button_state.ON);//根据要写入的状态进行取反
                    }
                    break;
                case "Regression":
                    if (button.Command)
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.ON);//先写入ON--后用事件复位-off
                    else
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.ON);//先写入ON--后用事件复位-off
                    state = true;//标志位                      
                    break;
                case "复归型_Off":
                    if (button.Command)
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.Off);//先写入ON--后用事件复位-off
                    else
                        pLC_Interface.IPLC_interface_PLC_write_M_bit(button.PLC_Contact, button.PLC_Address, Button_state.Off);//先写入ON--后用事件复位-off
                    state = false;//标志位
                    break;
            }
        }
        /// <summary>
        /// 定时刷新控件
        /// </summary>
        /// <param name="button"></param>
        public void Refresh(Control button,PLC Plc)//根据PLC类型读取--按钮类
        {
            Button_state button_State =Button_state.Off;//按钮状态
            Button_base button_base = button as Button_base;
            switch (Plc)
            {
                case PLC.Mitsubishi:
                    IPLC_interface mitsubishi = new Mitsubishi_realize();//实例化接口--实现三菱在线访问
                    if (mitsubishi.PLC_ready)//PLC是否准备完成
                    {
                        List<bool> data = mitsubishi.PLC_read_M_bit(button_base.PLC_Contact, button_base.PLC_Address);//读取状态
                        button_State = data[0] == true ? Button_state.ON : Button_state.Off;
                        button_state(button, button_State);
                    }
                    break;
                case PLC.Siemens:
                    IPLC_interface Siemens = new Siemens_realize();//实例化接口--实现西门子在线访问
                    if (Siemens.PLC_ready)//PLC是否准备完成
                    {
                        List<bool> data = Siemens.PLC_read_M_bit(button_base.PLC_Contact, button_base.PLC_Address);//读取状态
                        button_State = data[0] == true ? Button_state.ON : Button_state.Off;
                        button_state(button, button_State);
                    }
                    break;
                case PLC.MODBUS_TCP:
                    MODBUD_TCP MODBUD_TCP = new MODBUD_TCP();//实例化接口--实现MODBUS TCP
                    if (MODBUD_TCP.IPLC_interface_PLC_ready)//PLC是否准备完成
                    {
                        List<bool> data = MODBUD_TCP.IPLC_interface_PLC_read_M_bit(button_base.PLC_Contact, button_base.PLC_Address);//读取状态
                        button_State = data[0] == true ? Button_state.ON : Button_state.Off;
                        button_state(button, button_State);
                    }
                    break;
            }
        }
        /// <summary>
        /// 填充按钮类
        /// </summary>
        /// <param name="button_Reform"></param>
        /// <param name="button_Classes"></param>
        /// <param name="button_State"></param>
        private void button_state(Control button, Button_state button_State)//填充按钮类
        {
            switch (button.GetType().Name)
            {
                case "DAButton":
                    DAButton Dabutton = button as DAButton;
                    Dabutton.Text = button_State == Button_state.ON ? Dabutton.Text_ON : Dabutton.Text_OFF;
                    Dabutton.BaseColor = button_State == Button_state.ON ? Dabutton.Backdrop_ON : Dabutton.Backdrop_OFF;
                    //Dabutton.RectColor = Dabutton.FillColor;
                    break;
                case "DACheckBox":
                    DACheckBox daCheckBox = button as DACheckBox;
                    daCheckBox.Text = button_State == Button_state.ON ? daCheckBox.Text_ON : daCheckBox.Text_OFF;
                    daCheckBox.BackColor = button_State == Button_state.ON ? daCheckBox.Backdrop_ON : daCheckBox.Backdrop_OFF;
                    daCheckBox.Checked = button_State == Button_state.ON ? true : false;
                    break;
                case "DASwitch":
                    DASwitch daSwitch = button as DASwitch;
                    daSwitch.Text = button_State == Button_state.ON ? daSwitch.Text_ON : daSwitch.Text_OFF;
                    daSwitch.FalseColor = daSwitch.Backdrop_OFF;
                    daSwitch.TrueColor = daSwitch.Backdrop_ON;
                    daSwitch.Checked = Convert.ToBoolean(button_State);
                    break;
                case "DAConduit":
                    DAConduit daConduit = button as DAConduit;
                    daConduit.Text = button_State == Button_state.ON ? daConduit.Text_ON : daConduit.Text_OFF;
                    daConduit.LiquidColor = button_State == Button_state.ON ? daConduit.Backdrop_ON : daConduit.Backdrop_OFF;
                    daConduit.LiquidDirection = button_State == Button_state.ON ? HZH_Controls.Controls.LiquidDirection.Forward : HZH_Controls.Controls.LiquidDirection.Backward;
                    break;
                case "DARotor":
                    DARotor daRotor = button as DARotor;
                    daRotor.Text = button_State == Button_state.ON ? daRotor.Text_ON : daRotor.Text_OFF;
                    daRotor.RotorAround = button_State == Button_state.ON ? HZH_Controls.Controls.RotorAround.Clockwise : HZH_Controls.Controls.RotorAround.Counterclockwise;
                    break;
                case "DALedBulb":
                    DALedBulb daLedBulb = button as DALedBulb;
                    daLedBulb.Text = button_State == Button_state.ON ? daLedBulb.Text_ON : daLedBulb.Text_OFF;
                    daLedBulb.Color = button_State == Button_state.ON ? daLedBulb.Backdrop_ON : daLedBulb.Backdrop_OFF;
                    break;
                case "DASignalLamp":
                    DASignalLamp daSignalLamp = button as DASignalLamp;
                    daSignalLamp.Text = button_State == Button_state.ON ? daSignalLamp.Text_ON : daSignalLamp.Text_OFF;
                    if(daSignalLamp.I_Flicker& daSignalLamp.O_Flicker == false&button_State == Button_state.Off)
                    {
                        daSignalLamp.LampColor[0] = button_State == Button_state.ON ? daSignalLamp.Backdrop_ON : daSignalLamp.Backdrop_OFF;
                        daSignalLamp.TwinkleSpeed = 0;
                        return;
                    }
                    if (daSignalLamp.I_Flicker==false & daSignalLamp.O_Flicker& button_State == Button_state.ON)
                    {
                        daSignalLamp.LampColor[0] = button_State == Button_state.ON ? daSignalLamp.Backdrop_ON : daSignalLamp.Backdrop_OFF;
                        daSignalLamp.TwinkleSpeed = 0;
                        return;
                    }
                    if (daSignalLamp.O_Flicker&button_State==Button_state.Off)
                    {
                        daSignalLamp.LampColor = daSignalLamp.O_FlickerColor;
                        daSignalLamp.TwinkleSpeed = daSignalLamp.O_FlickerTime;
                        return;
                    }
                    if (daSignalLamp.I_Flicker & button_State == Button_state.ON)
                    {
                        daSignalLamp.LampColor = daSignalLamp.I_FlickerColor;
                        daSignalLamp.TwinkleSpeed = daSignalLamp.I_FlickerTime;
                        return;
                    }
                    if (daSignalLamp.O_Flicker == false & daSignalLamp.I_Flicker == false)
                    {
                        daSignalLamp.LampColor[0] = button_State == Button_state.ON ? daSignalLamp.Backdrop_ON : daSignalLamp.Backdrop_OFF;
                        daSignalLamp.TwinkleSpeed = 0;
                    }
                    break;
                case "DAAlarmLamp":
                    DAAlarmLamp daAlarmLamp = button as DAAlarmLamp;
                    daAlarmLamp.Text = button_State == Button_state.ON ? daAlarmLamp.Text_ON : daAlarmLamp.Text_OFF;
                    if (daAlarmLamp.I_Flicker & daAlarmLamp.O_Flicker == false & button_State == Button_state.Off)
                    {
                        daAlarmLamp.LampColor[0] = button_State == Button_state.ON ? daAlarmLamp.Backdrop_ON : daAlarmLamp.Backdrop_OFF;
                        daAlarmLamp.TwinkleSpeed = 0;
                        return;
                    }
                    if (daAlarmLamp.I_Flicker == false & daAlarmLamp.O_Flicker & button_State == Button_state.ON)
                    {
                        daAlarmLamp.LampColor[0] = button_State == Button_state.ON ? daAlarmLamp.Backdrop_ON : daAlarmLamp.Backdrop_OFF;
                        daAlarmLamp.TwinkleSpeed = 0;
                        return;
                    }
                    if (daAlarmLamp.O_Flicker & button_State == Button_state.Off)
                    {
                        daAlarmLamp.LampColor = daAlarmLamp.O_FlickerColor;
                        daAlarmLamp.TwinkleSpeed = daAlarmLamp.O_FlickerTime;
                        return;
                    }
                    if (daAlarmLamp.I_Flicker & button_State == Button_state.ON)
                    {
                        daAlarmLamp.LampColor = daAlarmLamp.I_FlickerColor;
                        daAlarmLamp.TwinkleSpeed = daAlarmLamp.I_FlickerTime;
                        return;
                    }
                    if (daAlarmLamp.O_Flicker == false & daAlarmLamp.I_Flicker == false)
                    {
                        daAlarmLamp.LampColor[0] = button_State == Button_state.ON ? daAlarmLamp.Backdrop_ON : daAlarmLamp.Backdrop_OFF;
                        daAlarmLamp.TwinkleSpeed = 0;
                    }
                    break;
            }
        }
        /// <summary>
        /// 索引该值是否在符合当前PLC
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool IsNull(string data, PLC pLC)
        {
            switch (pLC)
            {
                case PLC.Mitsubishi:
                    return Enum.GetNames(typeof(Mitsubishi_bit)).Where(pi => pi.ToString() == data).FirstOrDefault() == null ? false : true;
                case PLC.Siemens:
                    return Enum.GetNames(typeof(Siemens_bit)).Where(pi => pi.ToString() == data).FirstOrDefault() == null ? false : true;
                case PLC.MODBUS_TCP:
                    return Enum.GetNames(typeof(Modbus_TCP_bit)).Where(pi => pi.ToString() == data).FirstOrDefault() == null ? false : true;
            }
            return true;
        }
        /// <summary>
        /// 判断地址是否符合
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool Address(string data)
        {
            //检查输入数据是否正确
            Regex reg = new Regex(@"^[A-Fa-z0-9]+(.[0-9]+)?$");
            if (reg.IsMatch(data) != true)
            {
                return false;
            }
            return true;
        }
        public Button_PLC()
        {
            Dispose(false);
        }
        //是否回收完毕
        bool _disposed;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //这里的参数表示示是否需要释放那些实现IDisposable接口的托管对象
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return; //如果已经被回收，就中断执行
            if (disposing)
            {
                //TODO:释放那些实现IDisposable接口的托管对象
            }
            //TODO:释放非托管资源，设置对象为null
            _disposed = true;
        }
    }
}
