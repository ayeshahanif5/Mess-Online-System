namespace client
{
    partial class check_status
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
            this.txtreg_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.linkaddfood = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtreg_no
            // 
            this.txtreg_no.Location = new System.Drawing.Point(172, 43);
            this.txtreg_no.Name = "txtreg_no";
            this.txtreg_no.Size = new System.Drawing.Size(100, 20);
            this.txtreg_no.TabIndex = 0;
            this.txtreg_no.TextChanged += new System.EventHandler(this.txtreg_no_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "registration no_of student";
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(82, 99);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // linkaddfood
            // 
            this.linkaddfood.AutoSize = true;
            this.linkaddfood.Location = new System.Drawing.Point(104, 183);
            this.linkaddfood.Name = "linkaddfood";
            this.linkaddfood.Size = new System.Drawing.Size(46, 13);
            this.linkaddfood.TabIndex = 3;
            this.linkaddfood.TabStop = true;
            this.linkaddfood.Text = "addfood";
            this.linkaddfood.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkaddfood_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // check_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkaddfood);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtreg_no);
            this.Name = "check_status";
            this.Text = "check_status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtreg_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.LinkLabel linkaddfood;
        private System.Windows.Forms.Button button1;
    }
}