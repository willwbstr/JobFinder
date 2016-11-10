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
    public partial class AddBusiness : Form
    {
        AddBusinessContactInfo add2;
        AddBusiness add1;
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the next form
            this.Hide();
            add2 = new AddBusinessContactInfo();
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
