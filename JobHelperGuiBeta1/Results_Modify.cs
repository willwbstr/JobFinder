using System;
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
    public partial class Results_Modify : Form
    {
        
        public Results_Modify()
        {
            InitializeComponent();
        }

     
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Takes everything off Read Only mode and allows for changes to be made.
        
            this.dataGridView4.ReadOnly = false;
            this.txtBusinessID.ReadOnly = false;
            this.txtBusinessName.ReadOnly = false;
            this.txtAddress.ReadOnly = false;
            this.txtAddress2.ReadOnly = false;
            this.txtCity.ReadOnly = false;
            this.txtState.ReadOnly = false;
            this.txtZip.ReadOnly = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Takes everythinfg to read only and saves to the database
         
            this.dataGridView4.ReadOnly = true;
            this.txtBusinessID.ReadOnly = true;
            this.txtBusinessName.ReadOnly = true;
            this.txtAddress.ReadOnly = true;
            this.txtAddress2.ReadOnly = true;
            this.txtCity.ReadOnly = true;
            this.txtState.ReadOnly = true;
            this.txtZip.ReadOnly = true;
        }

        private void btnReturn2Main_Click(object sender, EventArgs e)
        {
            // Closes this form, loads the MainGui form, and clears all the old forms 

            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "MainGui")
                    f.Close();
            }
            
          
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
