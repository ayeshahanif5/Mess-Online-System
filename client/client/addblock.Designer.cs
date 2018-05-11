namespace client
{
    partial class addblock
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
            this.cmdadd = new System.Windows.Forms.Button();
            this.cmdblock = new System.Windows.Forms.Button();
            this.lbllGoBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmdadd
            // 
            this.cmdadd.Location = new System.Drawing.Point(116, 63);
            this.cmdadd.Name = "cmdadd";
            this.cmdadd.Size = new System.Drawing.Size(75, 23);
            this.cmdadd.TabIndex = 0;
            this.cmdadd.Text = "Add fine";
            this.cmdadd.UseVisualStyleBackColor = true;
            this.cmdadd.Click += new System.EventHandler(this.cmdadd_Click);
            // 
            // cmdblock
            // 
            this.cmdblock.Location = new System.Drawing.Point(116, 110);
            this.cmdblock.Name = "cmdblock";
            this.cmdblock.Size = new System.Drawing.Size(75, 23);
            this.cmdblock.TabIndex = 1;
            this.cmdblock.Text = "Blockuser";
            this.cmdblock.UseVisualStyleBackColor = true;
            this.cmdblock.Click += new System.EventHandler(this.cmdblock_Click);
            // 
            // lbllGoBack
            // 
            this.lbllGoBack.AutoSize = true;
            this.lbllGoBack.Location = new System.Drawing.Point(135, 163);
            this.lbllGoBack.Name = "lbllGoBack";
            this.lbllGoBack.Size = new System.Drawing.Size(49, 13);
            this.lbllGoBack.TabIndex = 2;
            this.lbllGoBack.TabStop = true;
            this.lbllGoBack.Text = "Go Back";
            this.lbllGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllGoBack_LinkClicked);
            // 
            // addblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbllGoBack);
            this.Controls.Add(this.cmdblock);
            this.Controls.Add(this.cmdadd);
            this.Name = "addblock";
            this.Text = "addblock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdadd;
        private System.Windows.Forms.Button cmdblock;
        private System.Windows.Forms.LinkLabel lbllGoBack;
    }
}