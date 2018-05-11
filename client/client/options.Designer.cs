namespace client
{
    partial class frmoptions
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lbllRate = new System.Windows.Forms.LinkLabel();
            this.link_current_bill = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(91, 58);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check bill by date";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(93, 99);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(60, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Menu";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lbllRate
            // 
            this.lbllRate.AutoSize = true;
            this.lbllRate.Location = new System.Drawing.Point(90, 139);
            this.lbllRate.Name = "lbllRate";
            this.lbllRate.Size = new System.Drawing.Size(75, 13);
            this.lbllRate.TabIndex = 2;
            this.lbllRate.TabStop = true;
            this.lbllRate.Text = "Rate the Food";
            this.lbllRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // link_current_bill
            // 
            this.link_current_bill.AutoSize = true;
            this.link_current_bill.Location = new System.Drawing.Point(89, 172);
            this.link_current_bill.Name = "link_current_bill";
            this.link_current_bill.Size = new System.Drawing.Size(94, 13);
            this.link_current_bill.TabIndex = 3;
            this.link_current_bill.TabStop = true;
            this.link_current_bill.Text = "check_currect_bill";
            this.link_current_bill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_current_bill_LinkClicked);
            // 
            // frmoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.link_current_bill);
            this.Controls.Add(this.lbllRate);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "frmoptions";
            this.Text = "options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel lbllRate;
        private System.Windows.Forms.LinkLabel link_current_bill;
    }
}