﻿/* Will Webster   *
 * Job Finder     *
 * AD Lab 6       *
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

namespace JobHelperGuiBeta1
{
    public partial class MainGui : Form
    {
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
            AddBusiness add1 = new AddBusiness();
            add1.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Moving this to Results_modify form
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

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays the Search form based on chosen filter
            this.Hide();
            Search search1 = new Search();
            search1.Show();
        }

    
    }

}