namespace client
{
    partial class checkbilldate
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
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txtbill = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.cmdShow = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(146, 40);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 0;
            // 
            // txtbill
            // 
            this.txtbill.Location = new System.Drawing.Point(146, 110);
            this.txtbill.Name = "txtbill";
            this.txtbill.Size = new System.Drawing.Size(100, 20);
            this.txtbill.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(38, 43);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.Location = new System.Drawing.Point(48, 117);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(20, 13);
            this.lblBill.TabIndex = 3;
            this.lblBill.Text = "Bill";
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(171, 160);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(75, 23);
            this.cmdShow.TabIndex = 4;
            this.cmdShow.Text = "Showbill";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(190, 214);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(49, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkbilldate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmdShow);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtbill);
            this.Controls.Add(this.txtdate);
            this.Name = "checkbilldate";
            this.Text = "checkbilldate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txtbill;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}