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
            // Search by already presented field and Display Results_Modify Form
           //List<Field> searchToolStripMenuItem.MainGui =
           //    searchToolStripMenuItem.MainGui.FindAll(FieldAccessException => Field.Filter == selectedField.Filter);
           // Results_Modify R_M = new Results_Modify();
           // R_M.Show();
           // this.Close();


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



    }
}
