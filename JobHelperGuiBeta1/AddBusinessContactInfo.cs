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
    public partial class AddBusinessContactInfo : Form
    {
        public AddBusinessContactInfo()
        {
            
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           
        }

        private void AddNew2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFinderDataSet.Business' table. You can move, or remove it, as needed.
           
            
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            this.Hide();
            AddBusiness add1 = new AddBusiness();
            add1.ShowDialog();
            this.Show();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the next form
            this.Hide();
            AddContact add3 = new AddContact();
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
