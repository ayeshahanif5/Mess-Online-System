namespace client
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
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblfname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.btnregister = new System.Windows.Forms.Button();
            this.lbllname = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtreg = new System.Windows.Forms.TextBox();
            this.txtans = new System.Windows.Forms.TextBox();
            this.txtquest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(164, 23);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 0;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(164, 104);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 1;
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Location = new System.Drawing.Point(56, 30);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(49, 13);
            this.lblfname.TabIndex = 2;
            this.lblfname.Text = "firstname";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(60, 111);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(52, 13);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "password";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.Location = new System.Drawing.Point(67, 304);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(29, 13);
            this.linklogin.TabIndex = 4;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "login";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(189, 300);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(75, 23);
            this.btnregister.TabIndex = 5;
            this.btnregister.Text = "register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllname
            // 
            this.lbllname.AutoSize = true;
            this.lbllname.Location = new System.Drawing.Point(60, 66);
            this.lbllname.Name = "lbllname";
            this.lbllname.Size = new System.Drawing.Size(49, 13);
            this.lbllname.TabIndex = 6;
            this.lbllname.Text = "lastname";
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(67, 154);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(34, 13);
            this.lblreg.TabIndex = 7;
            this.lblreg.Text = "regno";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(164, 59);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(100, 20);
            this.txtlname.TabIndex = 8;
            // 
            // txtreg
            // 
            this.txtreg.Location = new System.Drawing.Point(164, 147);
            this.txtreg.Name = "txtreg";
            this.txtreg.Size = new System.Drawing.Size(100, 20);
            this.txtreg.TabIndex = 9;
            // 
            // txtans
            // 
            this.txtans.Location = new System.Drawing.Point(165, 246);
            this.txtans.Name = "txtans";
            this.txtans.Size = new System.Drawing.Size(100, 20);
            this.txtans.TabIndex = 12;
            // 
            // txtquest
            // 
            this.txtquest.FormattingEnabled = true;
            this.txtquest.Items.AddRange(new object[] {
            "whats your hobby?",
            "whats your favourite character?"});
            this.txtquest.Location = new System.Drawing.Point(164, 201);
            this.txtquest.Name = "txtquest";
            this.txtquest.Size = new System.Drawing.Size(101, 21);
            this.txtquest.TabIndex = 13;
            this.txtquest.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtquest);
            this.Controls.Add(this.txtans);
            this.Controls.Add(this.txtreg);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.lbllname);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.linklogin);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblfname);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtfname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lbllname;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtreg;
        private System.Windows.Forms.TextBox txtans;
        private System.Windows.Forms.ComboBox txtquest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}