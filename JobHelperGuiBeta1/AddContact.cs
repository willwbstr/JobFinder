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
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void contactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void AddNew3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.jobFinderDataSet.Phone);
            // TODO: This line of code loads data into the 'jobFinderDataSet.Contact' table. You can move, or remove it, as needed.
            this.contactTableAdapter.Fill(this.jobFinderDataSet.Contact);

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the next form
            this.Hide();
            AddJob add4 = new AddJob();
            add4.Show();
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            this.Hide();
            AddBusinessContactInfo add2 = new AddBusinessContactInfo();
            add2.ShowDialog();
            this.Show();
        }

        private void btnCancel3_Click(object sender, EventArgs e)
        {
            // Clears the form
            ClearAllText(this);
            cboMethodOfContact.Items.Clear();
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

        private void cboMethodOfContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMethodOfContact.SelectedValue = // methods listed for contact
        }
    }
}
