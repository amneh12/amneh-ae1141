namespace WindowsFormsApp11
{
    partial class Form1
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
            this.btncreatemployee = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.btnCreateTextBox = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncreatemployee
            // 
            this.btncreatemployee.Location = new System.Drawing.Point(265, 318);
            this.btncreatemployee.Name = "btncreatemployee";
            this.btncreatemployee.Size = new System.Drawing.Size(184, 88);
            this.btncreatemployee.TabIndex = 0;
            this.btncreatemployee.Text = "Create Employee";
            this.btncreatemployee.UseVisualStyleBackColor = true;
            this.btncreatemployee.Click += new System.EventHandler(this.btncreatemployee_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(121, 107);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(20, 17);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(124, 215);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(87, 17);
            this.lbldob.TabIndex = 2;
            this.lbldob.Text = "Date Of Birth";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(121, 169);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(43, 17);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateTextBox);
            this.panel1.Location = new System.Drawing.Point(542, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 225);
            this.panel1.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(281, 100);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 24);
            this.txtid.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(281, 162);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 24);
            this.txtname.TabIndex = 6;
            // 
            // DTP
            // 
            this.DTP.Location = new System.Drawing.Point(265, 215);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(200, 24);
            this.DTP.TabIndex = 7;
            // 
            // btnCreateTextBox
            // 
            this.btnCreateTextBox.Location = new System.Drawing.Point(0, 4);
            this.btnCreateTextBox.Name = "btnCreateTextBox";
            this.btnCreateTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTextBox.TabIndex = 0;
            this.btnCreateTextBox.Text = "button1";
            this.btnCreateTextBox.UseVisualStyleBackColor = true;
            this.btnCreateTextBox.Click += new System.EventHandler(this.btnCreateTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btncreatemployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreatemployee;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.Button btnCreateTextBox;
    }
}

