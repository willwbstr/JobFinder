﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFinderGuiBeta1
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'God.DataTable1' table. You can move, or remove it, as needed.
            DataTable1TableAdapter.Fill(God.DataTable1);

            reportViewer1.RefreshReport();
        }

     
    }
}
