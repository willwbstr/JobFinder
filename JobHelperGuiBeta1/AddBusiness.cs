using System;
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
    public partial class AddBusiness : Form
    {
        public static AddBusinessContactInfo addBusinessContactInfo;
      
        public AddBusiness()
        {
            InitializeComponent();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            addBusinessContactInfo = new AddBusinessContactInfo();
            // Hides this form and loads the next form
            //Build the business object;
            this.Hide();
            if (addBusinessContactInfo == null)
            {
            addBusinessContactInfo = new AddBusinessContactInfo();
            addBusinessContactInfo.Show();
            }
            else 
            {
                addBusinessContactInfo.Show();
            }
           
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

        private void AddBusiness_Load(object sender, EventArgs e)
        {

        }
    }
}
