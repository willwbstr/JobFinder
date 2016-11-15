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
    public partial class AddJob : Form
    {
        public static Results_Modify results_Modify;
    
       
        public AddJob()
        {
            InitializeComponent();
        }

        private void jobBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          

        }

        private void AddNew4_Load(object sender, EventArgs e)
        {
          

        }

        private void btnNext4_Click(object sender, EventArgs e)
        {
             results_Modify = new Results_Modify();
            // Hides this form and loads the Results_Modify form
            this.Hide();
            if (results_Modify == null)
            {
                results_Modify = new Results_Modify();
                results_Modify.Show();
            }
            else
            {
                this.Refresh();
                results_Modify.Show();
            }
           
        }

        private void btnCancel4_Click(object sender, EventArgs e)
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

        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            this.Hide();
            
            AddBusinessContactInfo.addContact.Show();
            
        }

    }
}
