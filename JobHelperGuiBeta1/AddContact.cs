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
        public static AddJob addJob;
       
        public AddContact()
        {
            InitializeComponent();
            this.cboMethodOfContact.Items.AddRange(new object[] { "Call", "Text", "Email" });
        }

        private void contactBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
       

        }

        private void AddContact_Load(object sender, EventArgs e)
        {
          

        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            addJob = new AddJob();
            // Hides this form and loads the next form
            this.Hide();
            if (addJob == null)
            {
                addJob = new AddJob();
                addJob.Show();
            }
            else
            {
                this.Refresh();
                addJob.Show();
            }
          
        }

        private void btnPrevious3_Click(object sender, EventArgs e)
        {
            // Hides this form and loads the previous 
            this.Hide();
           
            AddBusiness.addBusinessContactInfo.Show();
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

        public static void cboMethodOfContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cboMethodOfContact.SelectedValue = // methods listed for contact

           
        }
    }
}
