namespace client
{
    partial class on_off
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
            this.lblmenu = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdsubmit = new System.Windows.Forms.Button();
            this.lbllGoBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmenu
            // 
            this.lblmenu.AutoSize = true;
            this.lblmenu.Location = new System.Drawing.Point(23, 20);
            this.lblmenu.Name = "lblmenu";
            this.lblmenu.Size = new System.Drawing.Size(33, 13);
            this.lblmenu.TabIndex = 0;
            this.lblmenu.TabStop = true;
            this.lblmenu.Text = "menu";
            this.lblmenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblviewmenu_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdsubmit
            // 
            this.cmdsubmit.Location = new System.Drawing.Point(26, 226);
            this.cmdsubmit.Name = "cmdsubmit";
            this.cmdsubmit.Size = new System.Drawing.Size(75, 23);
            this.cmdsubmit.TabIndex = 2;
            this.cmdsubmit.Text = "submit";
            this.cmdsubmit.UseVisualStyleBackColor = true;
            this.cmdsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbllGoBack
            // 
            this.lbllGoBack.AutoSize = true;
            this.lbllGoBack.Location = new System.Drawing.Point(210, 235);
            this.lbllGoBack.Name = "lbllGoBack";
            this.lbllGoBack.Size = new System.Drawing.Size(55, 13);
            this.lbllGoBack.TabIndex = 3;
            this.lbllGoBack.TabStop = true;
            this.lbllGoBack.Text = "Goo Back";
            this.lbllGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllGoBack_LinkClicked);
            // 
            // on_off
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbllGoBack);
            this.Controls.Add(this.cmdsubmit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblmenu);
            this.Name = "on_off";
            this.Text = "on_off";
            this.Load += new System.EventHandler(this.on_off_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblmenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdsubmit;
        private System.Windows.Forms.LinkLabel lbllGoBack;
    }
}