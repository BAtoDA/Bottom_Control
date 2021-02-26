using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;
using Bottom_Control.PLC通讯协议;
using HslCommunication.Profinet;

namespace Bottom_Control.设置控件
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2021/2/18 8:28:11 
    //  文件名：PLC_Open_Time 
    //  版本：V1.0.1  
    //  说明： 实现后台打开与重链PLC控件
    //  修改者：***
    //  修改说明： 
    //==============================================================
    /// <summary>
    /// PLC后台定时打开,刷新,重新链接控件
    /// </summary>
    [Browsable(true)]
    [Description("PLC后台定时打开,刷新,重新链接控件")]
    class PLC_Open_Time:Timer
    {
        #region 三菱PLC配置属性
        [Description("根据PLC 提供的IP进行填写 三菱PLC需要在以太网配置里拖拽出SLMP设备并且配置好IP与端口"), Category("三菱PLC参数")]
        [DefaultValue(typeof(string), "192.168.3.2")]
        public string MitsubishiIP
        {
            get => Mitsubishi_ip.ToString();
            set 
            {
                Mitsubishi_ip = IPAddress.TryParse(value, out Mitsubishi_ip) ? Mitsubishi_ip = IPAddress.Parse(value) : Mitsubishi_ip = IPAddress.Parse("192.168.3.2");               
            }
        }
        private IPAddress Mitsubishi_ip=IPAddress.Parse("192.168.3.2");
        [Description("根据PLC 提供的端口进行填写 三菱PLC需要在以太网配置里拖拽出SLMP设备并且配置好IP与端口"), Category("三菱PLC参数")]
        [DefaultValue(typeof(int), "4999")]
        public int MitsubishiPort { get; set; } = 4999;
        [Description("是否打开或者启用该PLC"), Category("三菱PLC参数")]
        [DefaultValue(typeof(bool), "false")]
        public bool Mitsubishi_Open { get; set; } = false;
        #endregion
        #region 西门子PLC配置属性
        [Description("根据PLC 提供的IP进行填写 西门子PLC需要在以太网配置勾选S7协议"), Category("西门子PLC参数")]
        [DefaultValue(typeof(string), "192.168.3.10")]
        public string SiemensIP
        {
            get => Siemens_ip.ToString();
            set
            {
                Siemens_ip = IPAddress.TryParse(value, out Siemens_ip) ? Siemens_ip = IPAddress.Parse(value) : Siemens_ip = IPAddress.Parse("192.168.3.10");
            }
        }
        [Description("根据PLC 选择具体PLC型号"), Category("西门子PLC参数")]
        public SiemensPLCS siemensPLCS { get; set; } = SiemensPLCS.S200Smart;
        private IPAddress Siemens_ip = IPAddress.Parse("192.168.3.10");
        [Description("根据PLC 提供的端口进行填写 西门子PLC需要在以太网配置勾选S7协议"), Category("西门子PLC参数")]
        [DefaultValue(typeof(int), "102")]
        public int SiemensPort { get; } = 102;
        [Description("是否打开或者启用该PLC"), Category("西门子PLC参数")]
        [DefaultValue(typeof(bool), "false")]
        public bool Siemens_Open { get; set; } = false;
        #endregion
        #region MODBUS tcp 配置属性
        [Description("根据PLC 提供的IP进行填写 三菱PLC需要在以太网配置里拖拽出modbus设备并且配置好IP与端口 西门子需要配置MODBUS FB"), Category("MODBUS PLC参数")]
        [DefaultValue(typeof(string), "192.168.3.10")]
        public string ModBusIP
        {
            get => ModBus_ip.ToString();
            set
            {
                ModBus_ip = IPAddress.TryParse(value, out ModBus_ip) ? ModBus_ip = IPAddress.Parse(value) : ModBus_ip = IPAddress.Parse("192.168.3.20");
            }
        }
        private IPAddress ModBus_ip = IPAddress.Parse("192.168.3.20");
        [Description("根据PLC 提供的端口进行填写 三菱PLC需要在以太网配置里拖拽出modbus设备并且配置好IP与端口 西门子需要配置MODBUS FB"), Category("MODBUS PLC参数")]
        [DefaultValue(typeof(int), "102")]
        public int ModBusPort { get; } = 502;
        [Description("是否打开或者启用该PLC"), Category("MODBUS PLC参数")]
        [DefaultValue(typeof(bool), "false")]
        public bool ModBus_Open { get; set; } = false;
        #endregion
        #region PLC通讯对象
        /// <summary>
        /// 三菱通讯对象
        /// </summary>
        static IPLC_interface Mitsubishi = new Mitsubishi_realize();
        /// <summary>
        /// 西门子通讯对象
        /// </summary>
        static IPLC_interface Siemens = new Siemens_realize();
        /// <summary>
        /// MODBUS tcp通讯对象
        /// </summary>
        static MODBUD_TCP MODBUS;
        /// <summary>
        /// 全局锁 指示该控件只能添加一个 
        /// </summary>
        static bool Lock_control;
        /// <summary>
        /// 全局锁异常标志位
        /// </summary>
        private bool lock_err;
        /// <summary>
        /// PLC触发报警事件
        /// </summary>
        public event EventHandler PLC_errEvent;
        /// <summary>
        /// 指示定时器是否在运行
        /// </summary>
        public static bool Time_run;
        System.Threading.Mutex mutex;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public PLC_Open_Time()
        {
            if (Lock_control)
            {
                lock_err = true;
                //throw new Exception("该控件不能重复添加");
            }
            Lock_control = true;
            //配置该控件默认参数
            this.Enabled = false;
            this.Interval = 500;
            mutex = new System.Threading.Mutex();
            //配置PLC参数
            Mitsubishi.IPEndPoint = new IPEndPoint(Mitsubishi_ip, MitsubishiPort);
            Siemens.IPEndPoint = new IPEndPoint(Siemens_ip, SiemensPort);
            MODBUS = new MODBUD_TCP(new IPEndPoint(ModBus_ip, ModBusPort), "502");
        }
        protected override void OnTick(EventArgs e)//重写定时器到达事件
        {
            lock(this)
            {
                Task.Run(() =>
                {
                    //配置PLC参数
                    Mitsubishi.IPEndPoint.Address = Mitsubishi_ip;
                    Mitsubishi.IPEndPoint.Port = MitsubishiPort;
                    Siemens.IPEndPoint.Address = ModBus_ip;
                    Siemens = new Siemens_realize(Siemens.IPEndPoint,siemensPLCS);
                    MODBUD_TCP.IPEndPoint.Address = ModBus_ip;
                    MODBUD_TCP.IPEndPoint.Port = ModBusPort;
                    if (Mitsubishi_Open & !Mitsubishi.PLC_ready)
                    {
                        Mitsubishi.PLC_open();
                        if (Mitsubishi.PLCerr_content != null)
                            this.PLC_errEvent(Mitsubishi.PLCerr_content, new EventArgs());
                    }
                    if (Siemens_Open & !Siemens.PLC_ready)
                    {
                        Siemens.PLC_open();
                        if (Siemens.PLCerr_content != null)
                            this.PLC_errEvent(Siemens.PLCerr_content, new EventArgs());
                    }
                    if (ModBus_Open & !MODBUD_TCP.IPLC_interface_PLC_ready)
                    {
                        MODBUD_TCP.IPLC_interface_PLC_open();
                        if (MODBUD_TCP.IPLC_interface_PLCerr_content != null)
                            this.PLC_errEvent(MODBUD_TCP.IPLC_interface_PLCerr_content, new EventArgs());
                    }
                });
            }
        }
        protected override void Dispose(bool disposing)//重写释放托管资源方法
        {
            base.Dispose(disposing);
            if (!lock_err)
            {
                Lock_control = false;
            }
            lock_err = false;
        }
    }
}
