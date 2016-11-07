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
    public partial class AddJob : Form
    {
        Results_Modify R_M;
    
        AddContact add3;
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
            // Hides this form and loads the Results_Modify form
            this.Hide();
            R_M = new Results_Modify();
            R_M.Show();
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
            add3 = new AddContact();
            add3.ShowDialog();
            this.Show();
        }

    }
}
