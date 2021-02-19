using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bottom_Control.PLC参数设置界面;

namespace Bottom_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            plC_Open_Time1.Enabled = true;
            plC_Open_Time1.Start();
            ComboxForm1 comboxForm1 = new ComboxForm1(new List<KeyValuePair<int, string>>() { new KeyValuePair<int, string>(2, "dd") });
            comboxForm1.ShowDialog();
        }
    }
}
