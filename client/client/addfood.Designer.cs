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
            this.cmdadd = new System.Windows.Forms.Button();
            this.cmdupdate = new System.Windows.Forms.Button();
            this.lbltype = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.linkviewmenu = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(166, 12);
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
            this.lblprice.Location = new System.Drawing.Point(33, 68);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Price";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.Location = new System.Drawing.Point(34, 115);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(26, 13);
            this.lblday.TabIndex = 3;
            this.lblday.Text = "Day";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(34, 153);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(30, 13);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "Date";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(166, 61);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 5;
            // 
            // txtday
            // 
            this.txtday.Location = new System.Drawing.Point(166, 108);
            this.txtday.Name = "txtday";
            this.txtday.Size = new System.Drawing.Size(100, 20);
            this.txtday.TabIndex = 6;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(172, 146);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 7;
            // 
            // cmdadd
            // 
            this.cmdadd.Location = new System.Drawing.Point(130, 218);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(75, 23);
            this.cmdadd.TabIndex = 8;
            this.cmdadd.Text = "AddFood";
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // cmdupdate
            // 
            this.cmdupdate.Location = new System.Drawing.Point(12, 218);
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
            this.lbltype.Location = new System.Drawing.Point(29, 188);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(31, 13);
            this.lbltype.TabIndex = 10;
            this.lbltype.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(172, 188);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 11;
            // 
            // linkviewmenu
            // 
            this.linkviewmenu.AutoSize = true;
            this.linkviewmenu.Location = new System.Drawing.Point(256, 223);
            this.linkviewmenu.Name = "linkviewmenu";
            this.linkviewmenu.Size = new System.Drawing.Size(60, 13);
            this.linkviewmenu.TabIndex = 12;
            this.linkviewmenu.TabStop = true;
            this.linkviewmenu.Text = "View Menu";
            this.linkviewmenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkviewmenu_LinkClicked);
            // 
            // frmaddfood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 262);
            this.Controls.Add(this.linkviewmenu);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.cmdupdate);
            this.Controls.Add(this.cmdadd);
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
        private System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.Button cmdupdate;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.LinkLabel linkviewmenu;
    }
}