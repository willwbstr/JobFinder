﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHelperGuiBeta1
{
    public partial class AddBusiness : Form
    {
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        private void AddNew1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Business' table. You can move, or remove it, as needed.
         
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the next form
            this.Hide();
            AddBusinessContactInfo add2 = new AddBusinessContactInfo();
            add2.Show();
        }

        private void btnCancel1_Click(object sender, EventArgs e)
        {
            // Clears the form
            ClearAllText(this);
        }


        // The Method that clears the text Boxes
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);

            }
        }
    }
}
