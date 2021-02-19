using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
namespace Bottom_Control.PLC参数设置界面
{
    public partial class ComboxForm1 : Sunny.UI.UIForm
    {
        private List<KeyValuePair<int, string>> KeyValuePair;
        public ComboxForm1(List<KeyValuePair<int,string>> keyValue)
        {
            InitializeComponent();
            this.KeyValuePair = keyValue;
        }

        private void ComboxForm1_Load(object sender, EventArgs e)
        {
            this.uiDataGridView1.Rows.Add();
            for (int i=0;i<this.KeyValuePair.Count;i++)
            {
                this.uiDataGridView1.Rows[i].Cells[0].Value = KeyValuePair[i].Key;
                this.uiDataGridView1.Rows[i].Cells[1].Value = KeyValuePair[i].Value;
                this.uiDataGridView1.Rows.Add();
            }
        }
        public List<KeyValuePair<int, string>> keyValuePairs;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            keyValuePairs = new List<KeyValuePair<int, string>>();
            for(int i=0;i<this.uiDataGridView1.Rows.Count;i++)
            {
                if(this.uiDataGridView1.Rows[i].Cells[0].Value!=null)
                {
                    keyValuePairs.Add(new KeyValuePair<int, string>(Convert.ToInt32(this.uiDataGridView1.Rows[i].Cells[0].Value), this.uiDataGridView1.Rows[i].Cells[1].Value.ToString()));
                }
            }
            this.Close();
        }
    }
}
