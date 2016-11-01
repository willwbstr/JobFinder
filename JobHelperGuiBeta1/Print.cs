using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;


namespace JobHelperGuiBeta1
{
    public partial class Print : Form
    {
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]

        public Print()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender,System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void txtBusiness_TextChanged(object sender, EventArgs e)
        {
            // Shows the business that is being printed *** May put this in Results Modify ***
            // I know this isn't the code but it gives an Idea of what I need

            txtBusiness.Results_Modify.Show();
        }

        private void txtJob_TextChanged(object sender, EventArgs e)
        {
            // shows the job being printed *** May put this in the Results Modify ***
            // I know this isn't the code but it gives an Idea of what I need
            dataGridView3.Jobs.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Will print the display of Results_ Modify

            /* Alot of code I will get back to you on this but basically I
             * Have to convert the page to a jpeg, store it and then create 
             * a method to customize the PrintDialog and print the stored image. */ 
            
            
        }

        private void btnCancelP_Click(object sender, EventArgs e)
        {
            // Close form and clears fields
            this.Close();
        }
    }
}
