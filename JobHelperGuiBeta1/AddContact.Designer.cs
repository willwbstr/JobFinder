namespace JobHelperGuiBeta1
{
    partial class AddContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contactLastNameLabel;
            System.Windows.Forms.Label contactFirstNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label methodOfContactLabel;
            System.Windows.Forms.Label contactNumberLabel;
            this.jobFinderDataSet = new JobHelperGuiBeta1.JobFinderDataSet();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.ContactTableAdapter();
            this.tableAdapterManager = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.TableAdapterManager();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.contactFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.btnPrevious3 = new System.Windows.Forms.Button();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.cboMethodOfContact = new System.Windows.Forms.ComboBox();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.PhoneTableAdapter();
            this.txtcontactNumber = new System.Windows.Forms.TextBox();
            this.btnCancel3 = new System.Windows.Forms.Button();
            contactLastNameLabel = new System.Windows.Forms.Label();
            contactFirstNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            methodOfContactLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactLastNameLabel
            // 
            contactLastNameLabel.AutoSize = true;
            contactLastNameLabel.Location = new System.Drawing.Point(12, 23);
            contactLastNameLabel.Name = "contactLastNameLabel";
            contactLastNameLabel.Size = new System.Drawing.Size(132, 17);
            contactLastNameLabel.TabIndex = 1;
            contactLastNameLabel.Text = "Contact Last Name:";
            // 
            // contactFirstNameLabel
            // 
            contactFirstNameLabel.AutoSize = true;
            contactFirstNameLabel.Location = new System.Drawing.Point(12, 63);
            contactFirstNameLabel.Name = "contactFirstNameLabel";
            contactFirstNameLabel.Size = new System.Drawing.Size(132, 17);
            contactFirstNameLabel.TabIndex = 2;
            contactFirstNameLabel.Text = "Contact First Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(97, 179);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-mail:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(97, 218);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(49, 17);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // methodOfContactLabel
            // 
            methodOfContactLabel.AutoSize = true;
            methodOfContactLabel.Location = new System.Drawing.Point(12, 101);
            methodOfContactLabel.Name = "methodOfContactLabel";
            methodOfContactLabel.Size = new System.Drawing.Size(130, 17);
            methodOfContactLabel.TabIndex = 11;
            methodOfContactLabel.Text = "Method Of Contact:";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new System.Drawing.Point(30, 140);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(114, 17);
            contactNumberLabel.TabIndex = 12;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // jobFinderDataSet
            // 
            this.jobFinderDataSet.DataSetName = "JobFinderDataSet";
            this.jobFinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTableAdapter = null;
            this.tableAdapterManager.ContactTableAdapter = this.contactTableAdapter;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.PhoneTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JobHelperGuiBeta1.JobFinderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "contactLastName", true));
            this.txtContactLastName.Location = new System.Drawing.Point(148, 23);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(258, 22);
            this.txtContactLastName.TabIndex = 2;
            // 
            // contactFirstNameTextBox
            // 
            this.contactFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "contactFirstName", true));
            this.contactFirstNameTextBox.Location = new System.Drawing.Point(148, 60);
            this.contactFirstNameTextBox.Name = "contactFirstNameTextBox";
            this.contactFirstNameTextBox.Size = new System.Drawing.Size(258, 22);
            this.contactFirstNameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(148, 176);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(258, 22);
            this.emailTextBox.TabIndex = 7;
            // 
            // notesTextBox
            // 
            this.notesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "notes", true));
            this.notesTextBox.Location = new System.Drawing.Point(150, 215);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(256, 22);
            this.notesTextBox.TabIndex = 9;
            // 
            // btnPrevious3
            // 
            this.btnPrevious3.Location = new System.Drawing.Point(100, 251);
            this.btnPrevious3.Name = "btnPrevious3";
            this.btnPrevious3.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious3.TabIndex = 10;
            this.btnPrevious3.Text = "Previous";
            this.btnPrevious3.UseVisualStyleBackColor = true;
            this.btnPrevious3.Click += new System.EventHandler(this.btnPrevious3_Click);
            // 
            // btnNext3
            // 
            this.btnNext3.Location = new System.Drawing.Point(331, 251);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(75, 23);
            this.btnNext3.TabIndex = 11;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // cboMethodOfContact
            // 
            this.cboMethodOfContact.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "methodOfContact", true));
            this.cboMethodOfContact.FormattingEnabled = true;
            this.cboMethodOfContact.Location = new System.Drawing.Point(148, 98);
            this.cboMethodOfContact.Name = "cboMethodOfContact";
            this.cboMethodOfContact.Size = new System.Drawing.Size(258, 24);
            this.cboMethodOfContact.TabIndex = 12;
            this.cboMethodOfContact.SelectedIndexChanged += new System.EventHandler(this.cboMethodOfContact_SelectedIndexChanged);
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // txtcontactNumber
            // 
            this.txtcontactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "contactNumber", true));
            this.txtcontactNumber.Location = new System.Drawing.Point(148, 137);
            this.txtcontactNumber.Name = "txtcontactNumber";
            this.txtcontactNumber.Size = new System.Drawing.Size(258, 22);
            this.txtcontactNumber.TabIndex = 13;
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(214, 251);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 23);
            this.btnCancel3.TabIndex = 14;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobHelperGuiBeta1.Properties.Resources.JobFinder1;
            this.ClientSize = new System.Drawing.Size(442, 306);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel3);
            this.Controls.Add(contactNumberLabel);
            this.Controls.Add(this.txtcontactNumber);
            this.Controls.Add(methodOfContactLabel);
            this.Controls.Add(this.cboMethodOfContact);
            this.Controls.Add(this.btnNext3);
            this.Controls.Add(this.btnPrevious3);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(contactFirstNameLabel);
            this.Controls.Add(this.contactFirstNameTextBox);
            this.Controls.Add(contactLastNameLabel);
            this.Controls.Add(this.txtContactLastName);
            this.Name = "AddContact";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.AddNew3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobFinderDataSet jobFinderDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private JobFinderDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private JobFinderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtContactLastName;
        private System.Windows.Forms.TextBox contactFirstNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button btnPrevious3;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.ComboBox cboMethodOfContact;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private JobFinderDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.TextBox txtcontactNumber;
        private System.Windows.Forms.Button btnCancel3;
    }
}