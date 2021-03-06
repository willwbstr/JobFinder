﻿namespace JobFinderGuiBeta1
{
    partial class AddBusinessContactInfo
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
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label businessPhoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label notesLabel;
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.businessPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.btnPrevious2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            faxLabel = new System.Windows.Forms.Label();
            businessPhoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(92, 20);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(34, 17);
            faxLabel.TabIndex = 1;
            faxLabel.Text = "Fax:";
            // 
            // businessPhoneLabel
            // 
            businessPhoneLabel.AutoSize = true;
            businessPhoneLabel.Location = new System.Drawing.Point(12, 55);
            businessPhoneLabel.Name = "businessPhoneLabel";
            businessPhoneLabel.Size = new System.Drawing.Size(114, 17);
            businessPhoneLabel.TabIndex = 2;
            businessPhoneLabel.Text = "Business Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(75, 87);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 17);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "E-mail:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(63, 118);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(63, 17);
            websiteLabel.TabIndex = 6;
            websiteLabel.Text = "Website:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(75, 149);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(49, 17);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // faxTextBox
            // 
            this.faxTextBox.Location = new System.Drawing.Point(128, 17);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(253, 22);
            this.faxTextBox.TabIndex = 2;
            // 
            // businessPhoneTextBox
            // 
            this.businessPhoneTextBox.Location = new System.Drawing.Point(126, 50);
            this.businessPhoneTextBox.Name = "businessPhoneTextBox";
            this.businessPhoneTextBox.Size = new System.Drawing.Size(255, 22);
            this.businessPhoneTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(126, 84);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(255, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.Location = new System.Drawing.Point(128, 115);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(253, 22);
            this.websiteTextBox.TabIndex = 7;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(128, 146);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(253, 22);
            this.notesTextBox.TabIndex = 9;
            // 
            // btnPrevious2
            // 
            this.btnPrevious2.Location = new System.Drawing.Point(78, 198);
            this.btnPrevious2.Name = "btnPrevious2";
            this.btnPrevious2.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious2.TabIndex = 10;
            this.btnPrevious2.Text = "Previous";
            this.btnPrevious2.UseVisualStyleBackColor = true;
            this.btnPrevious2.Click += new System.EventHandler(this.btnPrevious2_Click);
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(306, 197);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 11;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(192, 197);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 12;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // AddBusinessContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobFinderGuiBeta1.Properties.Resources.JobFinder1;
            this.ClientSize = new System.Drawing.Size(448, 249);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel2);
            this.Controls.Add(this.btnNext2);
            this.Controls.Add(this.btnPrevious2);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(businessPhoneLabel);
            this.Controls.Add(this.businessPhoneTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Name = "AddBusinessContactInfo";
            this.Text = "Add Business Contact Info";
            this.Load += new System.EventHandler(this.AddBusinessContactInfo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox businessPhoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button btnPrevious2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.Button btnCancel2;
    }
}