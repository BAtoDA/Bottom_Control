using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bottom_Control
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/15 13:01:45 
    //  文件名：PLC 
    //  版本：V1.0.1  
    //  说明： 实现控件PLC选择
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public enum PLC
    {
        Mitsubishi,
        Siemens,
        MODBUS_TCP,
        HMI
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi_bit
    {
        /*  LCS,LCC,*/
        SM, X, Y, M, L, F, B, TS, SS, SC, CS, CC, SB, S, D_Bit, SD_Bit, R_Bit, SW_Bit, W_Bit
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi_D
    {
        /*LCN,LZ,*/
        SD, D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP_D
    {
        D
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum HMI_bit
    {
        Data_Bit
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum HMI_D
    {
        Data_D
    }
    /// <summary>
    ///  PLC--按钮状态
    /// </summary>
    public enum Button_state
    {
        Off, ON
    }
    /// <summary>
    /// 数值显示类型
    /// </summary>
    public enum numerical_format
    {
        BCD_16_Bit, BCD_32_Bit, Hex_16_Bit, Hex_32_Bit, Binary_16_Bit, Binary_32_Bit, Unsigned_16_Bit, Signed_16_Bit
            , Unsigned_32_Bit, Signed_32_Bit, Float_32_Bit, String_32_Bit
    }
    /// <summary>
    /// 数值显示类型
    /// </summary>
    public enum numerical_type
    {
        数值
    }
    /// <summary>
    /// 按钮操作模式
    /// </summary>
    public enum Button_pattern//按钮模式类型枚举
    {
        Set_as_on, Set_as_off, selector_witch, Regression
    }
    public enum Button_select
    {
        Place,
        Indicator
    }
}
