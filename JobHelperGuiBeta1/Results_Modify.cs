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
        Search searchPage = MainGui.search1;
        AddBusiness addB  = MainGui.addBusiness;
       
        List<Business> businessList;
        List<Contact> contactList;
        List<Job> jobList;
        List<Phone> phoneList;

        public Results_Modify()
        {
            InitializeComponent();



            dataGridView4.ReadOnly = true;
            txtBusinessID.ReadOnly = true;
            txtBusinessName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtAddress2.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtBusinessPhone.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtWebsite.ReadOnly = true;
            txtContactFirstName.ReadOnly = true;
            txtContactLastName.ReadOnly = true;
            txtContactNumber.ReadOnly = true;
            txtMethodOfContact.ReadOnly = true;
            txtJob.ReadOnly = true;
            txtSourceOfJob.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtNotes.ReadOnly = true;

        }
      
     
        private void btnModify_Click(object sender, EventArgs e)
        {
            // Takes everything off Read Only mode and allows for changes to be made.

            dataGridView4.ReadOnly = false;
            txtBusinessID.ReadOnly = false;
            txtBusinessName.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtAddress2.ReadOnly = false;
            txtCity.ReadOnly = false;
            txtState.ReadOnly = false;
            txtZip.ReadOnly = false;
            txtBusinessPhone.ReadOnly = false;
            txtFax.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtWebsite.ReadOnly = false;
            txtContactFirstName.ReadOnly = false;
            txtContactLastName.ReadOnly = false;
            txtContactNumber.ReadOnly = false;
            txtMethodOfContact.ReadOnly = false;
            txtJob.ReadOnly = false;
            txtSourceOfJob.ReadOnly = false;
            txtSalary.ReadOnly = false;
            txtStatus.ReadOnly = false;
            txtNotes.ReadOnly = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Takes everythinfg to read only and saves to the database


            dataGridView4.ReadOnly = true;
            txtBusinessID.ReadOnly = true;
            txtBusinessName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtAddress2.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZip.ReadOnly = true;
            txtBusinessPhone.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtWebsite.ReadOnly = true;
            txtContactFirstName.ReadOnly = true;
            txtContactLastName.ReadOnly = true;
            txtContactNumber.ReadOnly = true;
            txtMethodOfContact.ReadOnly = true;
            txtJob.ReadOnly = true;
            txtSourceOfJob.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtStatus.ReadOnly = true;
            txtNotes.ReadOnly = true;

            PhoneDB.UpdatePhone();
            BusinessDB.UpdateBusiness();
            ContactDB.UpdateContact();
            JobDB.UpdateJob();
            // TODO: Set all form refs to NULL!!!!!
        }

        private void btnReturn2Main_Click(object sender, EventArgs e)
        {
            // Closes this form, loads the MainGui form, and clears all the old forms 


            Close();
                 if (MainGui.mg == null)
                 {
                     MainGui.mg = new MainGui();
                     MainGui.mg.Show();
                 }
                 else
                 {
                Refresh();
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


            SearchView(MainGui.find);


        }

        private void txtMethodOfContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBusinessName_TextChanged(object sender, EventArgs e)
        {

        }
        public void SearchView(string find)
        {
            businessList = BusinessDB.GetAll(find);
            contactList = ContactDB.GetAll(find);
            jobList = JobDB.GetAll(find);
            phoneList = PhoneDB.GetAll(find);

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

        static void AddView(string add)
        {
           

            //txtBusinessID.Text = AddBusiness.businessNameTextBox.Text.ToString();
            //txtBusinessName.Text = .ToString();
            //txtAddress.Text =.ToString();
            //txtAddress2.Text = .ToString();
            //txtCity.Text = .ToString();
            //txtState.Text = .ToString();
            //txtZip.Text = ToString();
            //txtFax.Text = businessList[0].Fax.ToString();
            //txtEmail.Text = businessList[0].Email.ToString();
            //txtWebsite.Text = businessList[0].Website.ToString();
            //txtContactFirstName.Text = contactList[0].ContactFirstName.ToString();
            //txtContactLastName.Text = contactList[0].ContactLastName.ToString();
            //txtMethodOfContact.Text = contactList[0].MethodOfContact.ToString();
            //txtContactEmail.Text = contactList[0].ContactEmail.ToString();
            //txtContactNumber.Text = phoneList[0].ContactNumber.ToString();
            //txtJob.Text = jobList[0].JobDescription.ToString();
            //txtSourceOfJob.Text = jobList[0].SourceOfJob.ToString();
            //txtSalary.Text = jobList[0].Salary.ToString();
            //txtStatus.Text = jobList[0].Status.ToString();
            //txtNotes.Text = jobList[0].Notes.ToString();

        }

        public TextBox BusinessNameTextBox
        {
            get
            {
                return txtBusinessName;
            }
        }
    }
}

