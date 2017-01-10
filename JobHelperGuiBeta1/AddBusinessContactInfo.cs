using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobFinderBU;

namespace JobFinderGuiBeta1
{
    public partial class AddBusinessContactInfo : Form
    {
        public static AddContact addContact;
       

        public AddBusinessContactInfo()
        {
            
            InitializeComponent();
        }

        private void businessBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
           
        }

        private void AddBusinessContactInfo_Load(object sender, EventArgs e)

        {
           
           
            
        }

        private void btnPrevious2_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            Hide();
            MainGui.addBusiness.Show();
           
           
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            addContact = new AddContact();
            // Hides this form and loads the next form
            Hide();
            if (addContact == null)
            {
                addContact = new AddContact();
                addContact.ShowDialog();
            }
            else
            {
                addContact.ShowDialog();
            }
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

        private void AddBusinessContactInfo_Load_1(object sender, EventArgs e)
        {

        }
    }
}
