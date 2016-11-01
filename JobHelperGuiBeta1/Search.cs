﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainGui;

namespace JobHelperGuiBeta1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search by already presented field and Display Results_Modify Form
           List<Field> searchToolStripMenuItem.MainGui =
               searchToolStripMenuItem.MainGui.FindAll(FieldAccessException => Field.Filter == selectedField.Filter);
            Results_Modify R_M = new Results_Modify();
            R_M.Show();
            this.Close();


        }



    }
}
