namespace JobHelperGuiBeta1
{
    partial class Print
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtBusiness = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelP = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(174, 144);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtBusiness
            // 
            this.txtBusiness.Location = new System.Drawing.Point(80, 36);
            this.txtBusiness.Name = "txtBusiness";
            this.txtBusiness.Size = new System.Drawing.Size(190, 22);
            this.txtBusiness.TabIndex = 1;
            this.txtBusiness.TextChanged += new System.EventHandler(this.txtBusiness_TextChanged);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(80, 90);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(190, 22);
            this.txtJob.TabIndex = 2;
            this.txtJob.TextChanged += new System.EventHandler(this.txtJob_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Business";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Job";
            // 
            // btnCancelP
            // 
            this.btnCancelP.Location = new System.Drawing.Point(46, 144);
            this.btnCancelP.Name = "btnCancelP";
            this.btnCancelP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelP.TabIndex = 5;
            this.btnCancelP.Text = "Cancel";
            this.btnCancelP.UseVisualStyleBackColor = true;
            this.btnCancelP.Click += new System.EventHandler(this.btnCancelP_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JobHelperGuiBeta1.Properties.Resources.JobFinder1;
            this.ClientSize = new System.Drawing.Size(287, 198);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtBusiness);
            this.Controls.Add(this.btnPrint);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtBusiness;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelP;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}