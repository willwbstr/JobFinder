namespace JobHelperGuiBeta1
{
    partial class AddJob
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
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label sourceOfJobLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label notesLabel;
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtSourceOfJob = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnNext4 = new System.Windows.Forms.Button();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.btnPrevious4 = new System.Windows.Forms.Button();
            jobLabel = new System.Windows.Forms.Label();
            sourceOfJobLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Location = new System.Drawing.Point(78, 30);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(35, 17);
            jobLabel.TabIndex = 1;
            jobLabel.Text = "Job:";
            // 
            // sourceOfJobLabel
            // 
            sourceOfJobLabel.AutoSize = true;
            sourceOfJobLabel.Location = new System.Drawing.Point(10, 67);
            sourceOfJobLabel.Name = "sourceOfJobLabel";
            sourceOfJobLabel.Size = new System.Drawing.Size(103, 17);
            sourceOfJobLabel.TabIndex = 2;
            sourceOfJobLabel.Text = "Source Of Job:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(65, 105);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(52, 17);
            salaryLabel.TabIndex = 4;
            salaryLabel.Text = "Salary:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(65, 142);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(52, 17);
            statusLabel.TabIndex = 6;
            statusLabel.Text = "Status:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(68, 180);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(49, 17);
            notesLabel.TabIndex = 8;
            notesLabel.Text = "Notes:";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(121, 27);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(254, 22);
            this.txtJob.TabIndex = 2;
            // 
            // txtSourceOfJob
            // 
            this.txtSourceOfJob.Location = new System.Drawing.Point(121, 64);
            this.txtSourceOfJob.Name = "txtSourceOfJob";
            this.txtSourceOfJob.Size = new System.Drawing.Size(254, 22);
            this.txtSourceOfJob.TabIndex = 3;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(121, 102);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(163, 22);
            this.txtSalary.TabIndex = 5;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(121, 139);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 22);
            this.txtStatus.TabIndex = 7;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(121, 177);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(254, 22);
            this.txtNotes.TabIndex = 9;
            // 
            // btnNext4
            // 
            this.btnNext4.Location = new System.Drawing.Point(284, 232);
            this.btnNext4.Name = "btnNext4";
            this.btnNext4.Size = new System.Drawing.Size(75, 23);
            this.btnNext4.TabIndex = 10;
            this.btnNext4.Text = "Next";
            this.btnNext4.UseVisualStyleBackColor = true;
            this.btnNext4.Click += new System.EventHandler(this.btnNext4_Click);
            // 
            // btnCancel4
            // 
            this.btnCancel4.Location = new System.Drawing.Point(179, 232);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(75, 23);
            this.btnCancel4.TabIndex = 11;
            this.btnCancel4.Text = "Cancel";
            this.btnCancel4.UseVisualStyleBackColor = true;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel4_Click);
            // 
            // btnPrevious4
            // 
            this.btnPrevious4.Location = new System.Drawing.Point(71, 232);
            this.btnPrevious4.Name = "btnPrevious4";
            this.btnPrevious4.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious4.TabIndex = 12;
            this.btnPrevious4.Text = "Previous";
            this.btnPrevious4.UseVisualStyleBackColor = true;
            this.btnPrevious4.Click += new System.EventHandler(this.btnPrevious4_Click);
            // 
            // AddJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobHelperGuiBeta1.Properties.Resources.JobFinder1;
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrevious4);
            this.Controls.Add(this.btnCancel4);
            this.Controls.Add(this.btnNext4);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(sourceOfJobLabel);
            this.Controls.Add(this.txtSourceOfJob);
            this.Controls.Add(jobLabel);
            this.Controls.Add(this.txtJob);
            this.Name = "AddJob";
            this.Text = "Add Job";
            this.Load += new System.EventHandler(this.AddNew4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtSourceOfJob;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnNext4;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnPrevious4;
    }
}