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

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void Results_Modify_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.jobFinderDataSet.Phone);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.jobFinderDataSet.Job);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.jobFinderDataSet.Contact);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter.Fill(this.jobFinderDataSet.Business);

            this.reportViewer1.RefreshReport();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // Takes everything off Read Only mode and allows for changes to be made.
            this.dataGridView1.ReadOnly = false;
            this.dataGridView2.ReadOnly = false;
            this.dataGridView3.ReadOnly = false;
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
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.ReadOnly = true;
            this.dataGridView3.ReadOnly = true;
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

    
    }
}
