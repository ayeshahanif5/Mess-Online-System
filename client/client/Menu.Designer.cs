namespace client
{
    partial class frmMenu
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbllGoBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(26, 25);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(78, 13);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Menu of Week";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbllGoBack
            // 
            this.lbllGoBack.AutoSize = true;
            this.lbllGoBack.Location = new System.Drawing.Point(196, 237);
            this.lbllGoBack.Name = "lbllGoBack";
            this.lbllGoBack.Size = new System.Drawing.Size(49, 13);
            this.lbllGoBack.TabIndex = 2;
            this.lbllGoBack.TabStop = true;
            this.lbllGoBack.Text = "Go Back";
            this.lbllGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllGoBack_LinkClicked);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbllGoBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lbllGoBack;
    }
}