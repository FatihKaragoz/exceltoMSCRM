namespace ExcelToMSCRMImport
{
    partial class ImportExcelForm
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
            this.kaydet = new System.Windows.Forms.Button();
            this.accountName = new System.Windows.Forms.TextBox();
            this.email1 = new System.Windows.Forms.TextBox();
            this.email2 = new System.Windows.Forms.TextBox();
            this.telephone1 = new System.Windows.Forms.TextBox();
            this.telephone2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kaydet
            // 
            this.kaydet.Location = new System.Drawing.Point(160, 220);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(100, 23);
            this.kaydet.TabIndex = 1;
            this.kaydet.Text = "kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            // 
            // accountName
            // 
            this.accountName.Location = new System.Drawing.Point(160, 90);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(100, 20);
            this.accountName.TabIndex = 2;
            // 
            // email1
            // 
            this.email1.Location = new System.Drawing.Point(160, 116);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(100, 20);
            this.email1.TabIndex = 3;
            // 
            // email2
            // 
            this.email2.Location = new System.Drawing.Point(160, 142);
            this.email2.Name = "email2";
            this.email2.Size = new System.Drawing.Size(100, 20);
            this.email2.TabIndex = 4;
            // 
            // telephone1
            // 
            this.telephone1.Location = new System.Drawing.Point(160, 168);
            this.telephone1.Name = "telephone1";
            this.telephone1.Size = new System.Drawing.Size(100, 20);
            this.telephone1.TabIndex = 5;
            // 
            // telephone2
            // 
            this.telephone2.Location = new System.Drawing.Point(160, 194);
            this.telephone2.Name = "telephone2";
            this.telephone2.Size = new System.Drawing.Size(100, 20);
            this.telephone2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "account name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "email1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "email2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "telephone1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "telephone2";
            // 
            // ImportExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telephone2);
            this.Controls.Add(this.telephone1);
            this.Controls.Add(this.email2);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.accountName);
            this.Controls.Add(this.kaydet);
            this.Name = "ImportExcelForm";
            this.Text = "ImportExcelForm";
            this.Load += new System.EventHandler(this.ImportExcelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.TextBox accountName;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.TextBox email2;
        private System.Windows.Forms.TextBox telephone1;
        private System.Windows.Forms.TextBox telephone2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}