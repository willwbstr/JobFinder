/* Will Webster   *
 * Job Finder     *
 *                *
 *****************/

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

    public partial class MainGui : Form
    {
        public static Search search1;
        public static AddBusiness addBusiness;
        public static MainGui mg;
        public static string updateStatus;
        public static string find;
       
        public MainGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays the Add Form
            this.Hide();
            addBusiness = new AddBusiness();
            addBusiness.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Closes program
       
            this.Close();
            
        }

        // Job Window //

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports rpt = new Reports();
            rpt.Show();
        }

        public void buisnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        public void searchToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.Hide();
            search1 = new Search();
            updateStatus = e.ClickedItem.Text;
            search1.displayFormatText = MainGui.updateStatus;
            search1.Show();
          
        }

        public void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

}
