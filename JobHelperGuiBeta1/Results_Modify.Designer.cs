namespace JobHelperGuiBeta1
{
    partial class Results_Modify
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
            System.Windows.Forms.Label businessIDLabel;
            System.Windows.Forms.Label businessNameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label address2Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipLabel;
            this.jobFinderDataSet = new JobHelperGuiBeta1.JobFinderDataSet();
            this.businessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.BusinessTableAdapter();
            this.tableAdapterManager = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.TableAdapterManager();
            this.contactTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.ContactTableAdapter();
            this.jobTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.JobTableAdapter();
            this.phoneTableAdapter = new JobHelperGuiBeta1.JobFinderDataSetTableAdapters.PhoneTableAdapter();
            this.txtBusinessID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.businessPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contactLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.methodOfContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceOfJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn2Main = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            businessIDLabel = new System.Windows.Forms.Label();
            businessNameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            address2Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // businessIDLabel
            // 
            businessIDLabel.AutoSize = true;
            businessIDLabel.Location = new System.Drawing.Point(24, 33);
            businessIDLabel.Name = "businessIDLabel";
            businessIDLabel.Size = new System.Drawing.Size(86, 17);
            businessIDLabel.TabIndex = 1;
            businessIDLabel.Text = "Business ID:";
            // 
            // businessNameLabel
            // 
            businessNameLabel.AutoSize = true;
            businessNameLabel.Location = new System.Drawing.Point(323, 30);
            businessNameLabel.Name = "businessNameLabel";
            businessNameLabel.Size = new System.Drawing.Size(110, 17);
            businessNameLabel.TabIndex = 6;
            businessNameLabel.Text = "Business Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(47, 73);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "Address:";
            // 
            // address2Label
            // 
            address2Label.AutoSize = true;
            address2Label.Location = new System.Drawing.Point(39, 108);
            address2Label.Name = "address2Label";
            address2Label.Size = new System.Drawing.Size(76, 17);
            address2Label.TabIndex = 10;
            address2Label.Text = "Address 2:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(450, 70);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 12;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(440, 108);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(45, 17);
            stateLabel.TabIndex = 14;
            stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(453, 143);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(32, 17);
            zipLabel.TabIndex = 16;
            zipLabel.Text = "Zip:";
            // 
            // jobFinderDataSet
            // 
            this.jobFinderDataSet.DataSetName = "JobFinderDataSet";
            this.jobFinderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessBindingSource
            // 
            this.businessBindingSource.DataMember = "Business";
            this.businessBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // businessTableAdapter
            // 
            this.businessTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessTableAdapter = this.businessTableAdapter;
            this.tableAdapterManager.ContactTableAdapter = this.contactTableAdapter;
            this.tableAdapterManager.EventsTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.PhoneTableAdapter = this.phoneTableAdapter;
            this.tableAdapterManager.UpdateOrder = JobHelperGuiBeta1.JobFinderDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // phoneTableAdapter
            // 
            this.phoneTableAdapter.ClearBeforeFill = true;
            // 
            // txtBusinessID
            // 
            this.txtBusinessID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "businessID", true));
            this.txtBusinessID.Location = new System.Drawing.Point(115, 30);
            this.txtBusinessID.Name = "txtBusinessID";
            this.txtBusinessID.Size = new System.Drawing.Size(167, 22);
            this.txtBusinessID.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessPhoneDataGridViewTextBoxColumn,
            this.fax,
            this.emailDataGridViewTextBoxColumn,
            this.website,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.businessBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(829, 97);
            this.dataGridView1.TabIndex = 3;
            // 
            // businessPhoneDataGridViewTextBoxColumn
            // 
            this.businessPhoneDataGridViewTextBoxColumn.DataPropertyName = "businessPhone";
            this.businessPhoneDataGridViewTextBoxColumn.HeaderText = "Business Phone";
            this.businessPhoneDataGridViewTextBoxColumn.Name = "businessPhoneDataGridViewTextBoxColumn";
            this.businessPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.businessPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "Fax";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 150;
            // 
            // website
            // 
            this.website.DataPropertyName = "website";
            this.website.HeaderText = "Website";
            this.website.Name = "website";
            this.website.ReadOnly = true;
            this.website.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactLastNameDataGridViewTextBoxColumn,
            this.contactFirstNameDataGridViewTextBoxColumn,
            this.methodOfContactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn1,
            this.notesDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.contactBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(4, 277);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(829, 106);
            this.dataGridView2.TabIndex = 4;
            // 
            // contactLastNameDataGridViewTextBoxColumn
            // 
            this.contactLastNameDataGridViewTextBoxColumn.DataPropertyName = "contactLastName";
            this.contactLastNameDataGridViewTextBoxColumn.HeaderText = "Contact Last Name";
            this.contactLastNameDataGridViewTextBoxColumn.Name = "contactLastNameDataGridViewTextBoxColumn";
            this.contactLastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactFirstNameDataGridViewTextBoxColumn
            // 
            this.contactFirstNameDataGridViewTextBoxColumn.DataPropertyName = "contactFirstName";
            this.contactFirstNameDataGridViewTextBoxColumn.HeaderText = "Contact First Name";
            this.contactFirstNameDataGridViewTextBoxColumn.Name = "contactFirstNameDataGridViewTextBoxColumn";
            this.contactFirstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // methodOfContactDataGridViewTextBoxColumn
            // 
            this.methodOfContactDataGridViewTextBoxColumn.DataPropertyName = "methodOfContact";
            this.methodOfContactDataGridViewTextBoxColumn.HeaderText = "Method Of Contact";
            this.methodOfContactDataGridViewTextBoxColumn.Name = "methodOfContactDataGridViewTextBoxColumn";
            this.methodOfContactDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            this.emailDataGridViewTextBoxColumn1.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            this.notesDataGridViewTextBoxColumn1.Width = 150;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobDataGridViewTextBoxColumn,
            this.sourceOfJobDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.jobBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(4, 383);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(829, 75);
            this.dataGridView3.TabIndex = 5;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDataGridViewTextBoxColumn.Width = 150;
            // 
            // sourceOfJobDataGridViewTextBoxColumn
            // 
            this.sourceOfJobDataGridViewTextBoxColumn.DataPropertyName = "sourceOfJob";
            this.sourceOfJobDataGridViewTextBoxColumn.HeaderText = "Source Of Job";
            this.sourceOfJobDataGridViewTextBoxColumn.Name = "sourceOfJobDataGridViewTextBoxColumn";
            this.sourceOfJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.sourceOfJobDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn2
            // 
            this.notesDataGridViewTextBoxColumn2.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn2.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn2.Name = "notesDataGridViewTextBoxColumn2";
            this.notesDataGridViewTextBoxColumn2.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn2.Width = 150;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactNumberDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.phoneBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(4, 458);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(829, 92);
            this.dataGridView4.TabIndex = 6;
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "contactNumber";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            this.contactNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn3
            // 
            this.notesDataGridViewTextBoxColumn3.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn3.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn3.Name = "notesDataGridViewTextBoxColumn3";
            this.notesDataGridViewTextBoxColumn3.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn3.Width = 150;
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            this.phoneBindingSource.DataSource = this.jobFinderDataSet;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "businessName", true));
            this.txtBusinessName.Location = new System.Drawing.Point(438, 27);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(228, 22);
            this.txtBusinessName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "address", true));
            this.txtAddress.Location = new System.Drawing.Point(116, 70);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(272, 22);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtAddress2
            // 
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "address2", true));
            this.txtAddress2.Location = new System.Drawing.Point(116, 105);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(272, 22);
            this.txtAddress2.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "city", true));
            this.txtCity.Location = new System.Drawing.Point(489, 67);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(177, 22);
            this.txtCity.TabIndex = 13;
            // 
            // txtState
            // 
            this.txtState.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "state", true));
            this.txtState.Location = new System.Drawing.Point(489, 105);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(177, 22);
            this.txtState.TabIndex = 15;
            // 
            // txtZip
            // 
            this.txtZip.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessBindingSource, "zip", true));
            this.txtZip.Location = new System.Drawing.Point(489, 140);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(126, 22);
            this.txtZip.TabIndex = 17;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(702, 26);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(109, 35);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify Vendor";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(702, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn2Main
            // 
            this.btnReturn2Main.Location = new System.Drawing.Point(702, 116);
            this.btnReturn2Main.Name = "btnReturn2Main";
            this.btnReturn2Main.Size = new System.Drawing.Size(109, 49);
            this.btnReturn2Main.TabIndex = 21;
            this.btnReturn2Main.Text = "Return to Main Screen";
            this.btnReturn2Main.UseVisualStyleBackColor = true;
            this.btnReturn2Main.Click += new System.EventHandler(this.btnReturn2Main_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReportFileToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // showReportFileToolStripMenuItem
            // 
            this.showReportFileToolStripMenuItem.Name = "showReportFileToolStripMenuItem";
            this.showReportFileToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.showReportFileToolStripMenuItem.Text = "Show Report";
            // 
            // Results_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobHelperGuiBeta1.Properties.Resources.JobFinder1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 551);
            this.ControlBox = false;
            this.Controls.Add(this.btnReturn2Main);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(address2Label);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(businessNameLabel);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(businessIDLabel);
            this.Controls.Add(this.txtBusinessID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Results_Modify";
            this.Text = "Results_Modify";
            this.Load += new System.EventHandler(this.Results_Modify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobFinderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JobFinderDataSet jobFinderDataSet;
        private System.Windows.Forms.BindingSource businessBindingSource;
        private JobFinderDataSetTableAdapters.BusinessTableAdapter businessTableAdapter;
        private JobFinderDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtBusinessID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private JobFinderDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private JobFinderDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn methodOfContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private JobFinderDataSetTableAdapters.PhoneTableAdapter phoneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceOfJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn website;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn2Main;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReportFileToolStripMenuItem;
    }
}