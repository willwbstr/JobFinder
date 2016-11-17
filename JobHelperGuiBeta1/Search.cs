using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobFinderData;
using JobFinderBU;


namespace JobFinderGuiBeta1
{
    public partial class Search : Form

    {
        // gets the selected Item from the previous form to display
        public string displayFormatText
        {
            get
            {
               return txtDisplayFormat.Text;
            }
            set
            {
                txtDisplayFormat.Text = value;
            }
        }
        public Search()
        {
            InitializeComponent();
            this.txtDisplayFormat.ReadOnly = true;
        }

        private void Search_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchby = "WHERE ";
            if (txtDisplayFormat.Text == "Business") searchby = searchby + "businessName = " + "";

            if (txtDisplayFormat.Text == "Contact") searchby = searchby + "contactLastName = " + "";

            if (txtDisplayFormat.Text == "Date") searchby = searchby + "date_time = " + "";

            if (txtDisplayFormat.Text == "Phone") searchby = searchby + "contactNumber = " + "";

            if (txtDisplayFormat.Text == "E-Mail") searchby = searchby + "email = " + "";

            if (txtDisplayFormat.Text == "Job") searchby = searchby + "job = " + "";

            searchby = searchby + txtDisplayFormat + "";

            Results_Modify R_M = new Results_Modify();
            R_M.Show();
            this.Close();


        }

        private void txtDisplayFormat_TextChanged(object sender, EventArgs e)
        {

          
        
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Will change depending on the selection of the search criteria from the Main Gui
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MainGui.mg == null)
            {
                MainGui.mg = new MainGui();
                MainGui.mg.Show();
            }
            else
            {
                this.Refresh();
                MainGui.mg.Show();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }



    }
}
