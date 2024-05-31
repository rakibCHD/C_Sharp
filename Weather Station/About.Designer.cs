
namespace Weather_Station
{
    partial class About
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
            this.label1 = new System.Windows.Forms.Label();
            this.Linkedin_Link = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Facebook_link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Linkedin_Link
            // 
            this.Linkedin_Link.AutoSize = true;
            this.Linkedin_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Linkedin_Link.Location = new System.Drawing.Point(231, 601);
            this.Linkedin_Link.Name = "Linkedin_Link";
            this.Linkedin_Link.Size = new System.Drawing.Size(284, 20);
            this.Linkedin_Link.TabIndex = 9;
            this.Linkedin_Link.TabStop = true;
            this.Linkedin_Link.Text = "https://www.linkedin.com/in/rakibchd/";
            this.Linkedin_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linkedin_Link_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "This software is Developed By: MD.RAKIB CHOWDHURY";
            // 
            // Facebook_link
            // 
            this.Facebook_link.AutoSize = true;
            this.Facebook_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.134328F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebook_link.Location = new System.Drawing.Point(231, 632);
            this.Facebook_link.Name = "Facebook_link";
            this.Facebook_link.Size = new System.Drawing.Size(276, 20);
            this.Facebook_link.TabIndex = 7;
            this.Facebook_link.TabStop = true;
            this.Facebook_link.Text = "https://www.facebook.com/rakib.chd";
            this.Facebook_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Facebook_link_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 671);
            this.Controls.Add(this.Linkedin_Link);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Facebook_link);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Linkedin_Link;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Facebook_link;
    }
}