using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;

namespace Bottom_Control
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“xNDataSet.Table_1”中。您可以根据需要移动或删除它。
            this.table_1TableAdapter.Fill(this.xNDataSet.Table_1);
            this.plC_Open_Time1.Enabled = true;
            this.plC_Open_Time1.Start();
            //  List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "ID", HeadText = "编号", Width = 70, WidthType = SizeType.Absolute });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Name", HeadText = "姓名", Width = 500, WidthType = SizeType.Absolute });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Age", HeadText = "年龄", Width = 500, WidthType = SizeType.Absolute });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Birthday", HeadText = "生日", Width = 500, WidthType = SizeType.Absolute, Format = (a) => { return ((DateTime)a).ToString("yyyy-MM-dd"); } });
            //lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "Sex", HeadText = "性别", Width = 50, WidthType = SizeType.Absolute, Format = (a) => { return ((int)a) == 0 ? "女" : "男"; } });
            //this.ucDataGridView1.Columns = lstCulumns;
            //this.ucDataGridView1.IsShowCheckBox = true;
            //List<object> lstSource = new List<object>();
            //for (int i = 0; i < 50; i++)
            //{
            //    TestGridModel model = new TestGridModel()
            //    {
            //        ID = i.ToString(),
            //        Age = 3 * i,
            //        Name = "姓名——" + i,
            //        Birthday = DateTime.Now.AddYears(-10),
            //        Sex = i % 2
            //    };
            //    lstSource.Add(model);                
            //}          
            //this.ucDataGridView1.DataSource = lstSource;
        }
      
        private void daDataGridView_TO_PLC1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
    public class TestGridModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Sex { get; set; }
        public int Age { get; set; }
        public List<TestGridModel> Childrens { get; set; }
    }
}
