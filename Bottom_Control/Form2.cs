﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.plC_Open_Time1.Enabled = true;
            this.plC_Open_Time1.Start();
        }

        private void oscillogram_PLC1_PaddingChanged(object sender, EventArgs e)
        {
            MessageBox.Show("dd");
        }

        private void oscillogram_PLC1_MarginChanged(object sender, EventArgs e)
        {
            MessageBox.Show("dd");
        }

        private void oscillogram_PLC1_ParentChanged(object sender, EventArgs e)
        {
        }
    }
}
