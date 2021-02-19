using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bottom_Control
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/15 13:38:25 
    //  文件名：Public_Class 
    //  版本：V1.0.1  
    //  说明： 实现处理控件一些公共方法
    //  修改者：***
    //  修改说明： 
    //==============================================================
    class Public_Class
    {
        /// <summary>
        /// 按钮类PLC选择 根据PLC类型改变辅助触点类型
        /// </summary>
        /// <param name="pLC">选择的PLC</param>
        /// <returns></returns>
        public static object PLC_button(PLC pLC)
        {
            switch(pLC)
            {
                case PLC.HMI:
                    return Enum.GetNames(typeof(HMI_bit));
                case PLC.Mitsubishi:
                    return Enum.GetNames(typeof(Mitsubishi_bit));
                case PLC.MODBUS_TCP:
                    return Enum.GetNames(typeof(Modbus_TCP_bit));
                case PLC.Siemens:
                    return Enum.GetNames(typeof(Siemens_bit));
            }
            return Enum.GetNames(typeof(Mitsubishi_bit));
        }

    }
}
