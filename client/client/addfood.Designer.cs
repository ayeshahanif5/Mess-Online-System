namespace client
{
    partial class frmaddfood
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtday = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.linkviewmenu = new System.Windows.Forms.LinkLabel();
            this.lblUpdateStatus = new System.Windows.Forms.LinkLabel();
            this.lbllRating = new System.Windows.Forms.LinkLabel();
            this.linkstatus = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(172, 8);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(33, 15);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(34, 53);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Price";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(34, 97);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 3;
            this.lblday.Text = "Day";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(34, 135);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(172, 46);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 5;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(172, 90);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(100, 20);
            this.txtday.TabIndex = 6;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(172, 128);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 7;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(263, 195);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "AddFood";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // cmdupdate
            // 
            this.cmdupdate.Location = new System.Drawing.Point(263, 224);
            this.cmdupdate.Name = "cmdupdate";
            this.cmdupdate.Size = new System.Drawing.Size(75, 23);
            this.cmdupdate.TabIndex = 9;
            this.cmdupdate.Text = "Update";
            this.cmdupdate.UseVisualStyleBackColor = true;
            this.cmdupdate.Click += new System.EventHandler(this.cmdupdate_Click);
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(34, 176);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 10;
            this.lbltype.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(172, 169);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 11;
            // 
            // linkviewmenu
            // 
            this.linkviewmenu.AutoSize = true;
            this.linkviewmenu.Location = new System.Drawing.Point(18, 205);
            this.linkviewmenu.Name = "linkviewmenu";
            this.linkviewmenu.Size = new System.Drawing.Size(60, 13);
            this.linkviewmenu.TabIndex = 12;
            this.linkviewmenu.TabStop = true;
            this.linkviewmenu.Text = "View Menu";
            this.linkviewmenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkviewmenu_LinkClicked);
            // 
            // lblUpdateStatus
            // 
            this.lblUpdateStatus.AutoSize = true;
            this.lblUpdateStatus.Location = new System.Drawing.Point(18, 234);
            this.lblUpdateStatus.Name = "lblUpdateStatus";
            this.lblUpdateStatus.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateStatus.TabIndex = 13;
            this.lblUpdateStatus.TabStop = true;
            this.lblUpdateStatus.Text = "Update Status";
            this.lblUpdateStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUpdateStatus_LinkClicked);
            // 
            // lbllRating
            // 
            this.lbllRating.AutoSize = true;
            this.lbllRating.Location = new System.Drawing.Point(104, 205);
            this.lbllRating.Name = "lbllRating";
            this.lbllRating.Size = new System.Drawing.Size(72, 13);
            this.lbllRating.TabIndex = 14;
            this.lbllRating.TabStop = true;
            this.lbllRating.Text = "Check Rating";
            this.lbllRating.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkstatus
            // 
            this.linkstatus.AutoSize = true;
            this.linkstatus.Location = new System.Drawing.Point(121, 234);
            this.linkstatus.Name = "linkstatus";
            this.linkstatus.Size = new System.Drawing.Size(65, 13);
            this.linkstatus.TabIndex = 15;
            this.linkstatus.TabStop = true;
            this.linkstatus.Text = "checkstatus";
            this.linkstatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkstatus_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(202, 205);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add /block";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // frmaddfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkstatus);
            this.Controls.Add(this.lbllRating);
            this.Controls.Add(this.lblUpdateStatus);
            this.Controls.Add(this.linkviewmenu);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.cmdupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtday);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Name = "frmaddfood";
            this.Text = "addfood";
            this.Load += new System.EventHandler(this.frmaddfood_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtday;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.LinkLabel linkviewmenu;
        private System.Windows.Forms.LinkLabel lblUpdateStatus;
        private System.Windows.Forms.LinkLabel lbllRating;
        private System.Windows.Forms.LinkLabel linkstatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}