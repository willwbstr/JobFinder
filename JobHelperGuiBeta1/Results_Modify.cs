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
    public partial class Results_Modify : Form
    {
       
        List<Business> businessList;
        List<Contact> contactList;
        List<Job> jobList;
        List<Phone> phoneList;

        public Results_Modify()
        {
            InitializeComponent();
            //txtMethodOfContact.Text = AddBusinessContactInfo.addContact.cboMethodOfContact.Text.ToString();


            // Sets Text Boxes to Read only

            this.dataGridView4.ReadOnly = true;
            this.txtBusinessID.ReadOnly = true;
            this.txtBusinessName.ReadOnly = true;
            this.txtAddress.ReadOnly = true;
            this.txtAddress2.ReadOnly = true;
            this.txtCity.ReadOnly = true;
            this.txtState.ReadOnly = true;
            this.txtZip.ReadOnly = true;
            this.txtBusinessPhone.ReadOnly = true;
            this.txtFax.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.txtWebsite.ReadOnly = true;
            this.txtContactFirstName.ReadOnly = true;
            this.txtContactLastName.ReadOnly = true;
            this.txtContactNumber.ReadOnly = true;
            this.txtMethodOfContact.ReadOnly = true;
            this.txtJob.ReadOnly = true;
            this.txtSourceOfJob.ReadOnly = true;
            this.txtSalary.ReadOnly = true;
            this.txtStatus.ReadOnly = true;
            this.txtNotes.ReadOnly = true;

        }

     
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Takes everything off Read Only mode and allows for changes to be made.
        
            this.dataGridView4.ReadOnly = false;
            this.txtBusinessID.ReadOnly = false;
            this.txtBusinessName.ReadOnly = false;
            this.txtAddress.ReadOnly = false;
            this.txtAddress2.ReadOnly = false;
            this.txtCity.ReadOnly = false;
            this.txtState.ReadOnly = false;
            this.txtZip.ReadOnly = false;
            this.txtBusinessPhone.ReadOnly = false;
            this.txtFax.ReadOnly = false;
            this.txtEmail.ReadOnly = false;
            this.txtWebsite.ReadOnly = false;
            this.txtContactFirstName.ReadOnly = false;
            this.txtContactLastName.ReadOnly = false;
            this.txtContactNumber.ReadOnly = false;
            this.txtMethodOfContact.ReadOnly = false;
            this.txtJob.ReadOnly = false;
            this.txtSourceOfJob.ReadOnly = false;
            this.txtSalary.ReadOnly = false;
            this.txtStatus.ReadOnly = false;
            this.txtNotes.ReadOnly = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Takes everythinfg to read only and saves to the database

         
            this.dataGridView4.ReadOnly = true;
            this.txtBusinessID.ReadOnly = true;
            this.txtBusinessName.ReadOnly = true;
            this.txtAddress.ReadOnly = true;
            this.txtAddress2.ReadOnly = true;
            this.txtCity.ReadOnly = true;
            this.txtState.ReadOnly = true;
            this.txtZip.ReadOnly = true;
            this.txtBusinessPhone.ReadOnly = true;
            this.txtFax.ReadOnly = true;
            this.txtEmail.ReadOnly = true;
            this.txtWebsite.ReadOnly = true;
            this.txtContactFirstName.ReadOnly = true;
            this.txtContactLastName.ReadOnly = true;
            this.txtContactNumber.ReadOnly = true;
            this.txtMethodOfContact.ReadOnly = true;
            this.txtJob.ReadOnly = true;
            this.txtSourceOfJob.ReadOnly = true;
            this.txtSalary.ReadOnly = true;
            this.txtStatus.ReadOnly = true;
            this.txtNotes.ReadOnly = true;


            // TODO: Set all form refs to NULL!!!!!
        }

        private void btnReturn2Main_Click(object sender, EventArgs e)
        {
            // Closes this form, loads the MainGui form, and clears all the old forms 

            
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

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Results_Modify_Load(object sender, EventArgs e)
        {
            businessList = BusinessDB.GetAll(" ");
            contactList = ContactDB.GetAll(" ");
            jobList = JobDB.GetAll(" ");
            phoneList = PhoneDB.GetAll(" ");

            txtBusinessID.Text = businessList[0].BusinessID.ToString();
            txtBusinessName.Text = businessList[0].BusinessName.ToString();
            txtAddress.Text = businessList[0].Address.ToString();
            txtAddress2.Text = businessList[0].Address2.ToString();
            txtCity.Text = businessList[0].City.ToString();
            txtState.Text = businessList[0].State.ToString();
            txtZip.Text = businessList[0].Zip.ToString();
            txtFax.Text = businessList[0].Fax.ToString();
            txtEmail.Text = businessList[0].Email.ToString();
            txtWebsite.Text = businessList[0].Website.ToString();
            txtContactFirstName.Text = contactList[0].ContactFirstName.ToString();
            txtContactLastName.Text = contactList[0].ContactLastName.ToString();
            txtMethodOfContact.Text = contactList[0].MethodOfContact.ToString();
            txtContactEmail.Text = contactList[0].ContactEmail.ToString();
            txtContactNumber.Text = phoneList[0].ContactNumber.ToString();
            txtJob.Text = jobList[0].JobDescription.ToString();
            txtSourceOfJob.Text = jobList[0].SourceOfJob.ToString();
            txtSalary.Text = jobList[0].Salary.ToString();
            txtStatus.Text = jobList[0].Status.ToString();
            txtNotes.Text = jobList[0].Notes.ToString();

        }

        private void txtMethodOfContact_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
