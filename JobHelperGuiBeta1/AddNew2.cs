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
    public partial class AddNew2 : Form
    {
        public AddNew2()
        {
            
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.businessBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobFinderDataSet);

        }

        private void AddNew2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Business' table. You can move, or remove it, as needed.
            this.businessTableAdapter.Fill(this.jobFinderDataSet.Business);
            
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            this.Hide();
            AddNew1 add1 = new AddNew1();
            add1.ShowDialog();
            this.Show();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the next form
            this.Hide();
            AddNew3 add3 = new AddNew3();
            add3.Show();
        }

        private void btnCancel2_Click(object sender, EventArgs e)
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
