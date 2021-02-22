using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bottom_Control.PLC通讯协议;
using Bottom_Control.基本控件;
using Bottom_Control.控件类基;

namespace Bottom_Control.表格控件__TO__PLC
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/20 22:14:07 
    //  文件名：DataGridView_PLC 
    //  版本：V1.0.1  
    //  说明： 实现DataGridView表格控件读取PLC数据
    //  修改者：***
    //  修改说明： 
    //==============================================================
    /// <summary>
    /// 实现DataGridView表格控件读取PLC数据
    /// </summary>
    class DataGridView_PLC
    {
        public List<string> plc(TextBox_base textBox, DataGridViewPLC_base dataGridView,int Idx)//根据PLC类型写入
        {
            List<string> Data = new List<string>();
            switch (textBox.Plc)
            {
                case PLC.Mitsubishi:
                    IPLC_interface mitsubishi = new Mitsubishi_realize();//实例化接口--实现三菱在线访问
                    if (mitsubishi.PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(mitsubishi.PLC_read_D_register(textBox.PLC_Contact, dataGridView.PLC_address[i].ToString(), dataGridView.DataGridView_numerical[i]));
                    }                  
                    break;
                case PLC.Siemens:
                    IPLC_interface Siemens = new Siemens_realize();//实例化接口--实现西门子在线访问
                    if (Siemens.PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(Siemens.PLC_read_D_register(textBox.PLC_Contact, dataGridView.PLC_address[i].ToString(), dataGridView.DataGridView_numerical[i]));
                    }
                    break;
                case PLC.MODBUS_TCP:
                    MODBUD_TCP MODBUD_TCP = new MODBUD_TCP();//实例化接口--实现MODBUS TCP
                    if (MODBUD_TCP.IPLC_interface_PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(MODBUD_TCP.IPLC_interface_PLC_read_D_register(textBox.PLC_Contact, dataGridView.PLC_address[i].ToString(), dataGridView.DataGridView_numerical[i]));
                    }
                    break;
            }
            return Data;
        }
        public List<string> plc(TextBox_base textBox, Histogram_base dataGridView, int Idx)//根据PLC类型写入
        {
            List<string> Data = new List<string>();
            switch (textBox.Plc)
            {
                case PLC.Mitsubishi:
                    IPLC_interface mitsubishi = new Mitsubishi_realize();//实例化接口--实现三菱在线访问
                    if (mitsubishi.PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(mitsubishi.PLC_read_D_register(textBox.PLC_Contact, dataGridView.Total_address[i].ToString(), dataGridView.Histogram_numerical[i]));
                    }
                    break;
                case PLC.Siemens:
                    IPLC_interface Siemens = new Siemens_realize();//实例化接口--实现西门子在线访问
                    if (Siemens.PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(Siemens.PLC_read_D_register(textBox.PLC_Contact, dataGridView.Total_address[i].ToString(), dataGridView.Histogram_numerical[i]));
                    }
                    break;
                case PLC.MODBUS_TCP:
                    MODBUD_TCP MODBUD_TCP = new MODBUD_TCP();//实例化接口--实现MODBUS TCP
                    if (MODBUD_TCP.IPLC_interface_PLC_ready)
                    {
                        for (int i = 0; i < Idx; i++)
                            Data.Add(MODBUD_TCP.IPLC_interface_PLC_read_D_register(textBox.PLC_Contact, dataGridView.Total_address[i].ToString(), dataGridView.Histogram_numerical[i]));
                    }
                    break;
            }
            return Data;
        }
    }
}
