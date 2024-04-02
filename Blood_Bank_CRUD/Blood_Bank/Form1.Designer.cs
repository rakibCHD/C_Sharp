
namespace Blood_Bank
{
    partial class Blood_Bank_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Bank_Register));
            this.B_Insert = new System.Windows.Forms.Button();
            this.B_Update = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Reset = new System.Windows.Forms.Button();
            this.L_Name = new System.Windows.Forms.Label();
            this.L_NID = new System.Windows.Forms.Label();
            this.L_Profession = new System.Windows.Forms.Label();
            this.L_BG = new System.Windows.Forms.Label();
            this.L_Phone = new System.Windows.Forms.Label();
            this.L_Address = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_NID = new System.Windows.Forms.TextBox();
            this.TB_Profession = new System.Windows.Forms.TextBox();
            this.TB_BG = new System.Windows.Forms.TextBox();
            this.TB_Phone = new System.Windows.Forms.TextBox();
            this.TB_Address = new System.Windows.Forms.RichTextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Insert
            // 
            this.B_Insert.Location = new System.Drawing.Point(120, 249);
            this.B_Insert.Name = "B_Insert";
            this.B_Insert.Size = new System.Drawing.Size(75, 23);
            this.B_Insert.TabIndex = 0;
            this.B_Insert.Text = "Insert";
            this.B_Insert.UseVisualStyleBackColor = true;
            this.B_Insert.Click += new System.EventHandler(this.B_Insert_Click);
            // 
            // B_Update
            // 
            this.B_Update.Location = new System.Drawing.Point(280, 249);
            this.B_Update.Name = "B_Update";
            this.B_Update.Size = new System.Drawing.Size(75, 23);
            this.B_Update.TabIndex = 1;
            this.B_Update.Text = "Update";
            this.B_Update.UseVisualStyleBackColor = true;
            this.B_Update.Click += new System.EventHandler(this.B_Update_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(442, 249);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(75, 23);
            this.B_Delete.TabIndex = 2;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Reset
            // 
            this.B_Reset.Location = new System.Drawing.Point(600, 249);
            this.B_Reset.Name = "B_Reset";
            this.B_Reset.Size = new System.Drawing.Size(75, 23);
            this.B_Reset.TabIndex = 3;
            this.B_Reset.Text = "Reset";
            this.B_Reset.UseVisualStyleBackColor = true;
            this.B_Reset.Click += new System.EventHandler(this.B_Reset_Click);
            // 
            // L_Name
            // 
            this.L_Name.AutoSize = true;
            this.L_Name.Location = new System.Drawing.Point(102, 74);
            this.L_Name.Name = "L_Name";
            this.L_Name.Size = new System.Drawing.Size(35, 13);
            this.L_Name.TabIndex = 4;
            this.L_Name.Text = "Name";
            // 
            // L_NID
            // 
            this.L_NID.AutoSize = true;
            this.L_NID.Location = new System.Drawing.Point(111, 112);
            this.L_NID.Name = "L_NID";
            this.L_NID.Size = new System.Drawing.Size(26, 13);
            this.L_NID.TabIndex = 5;
            this.L_NID.Text = "NID";
            // 
            // L_Profession
            // 
            this.L_Profession.AutoSize = true;
            this.L_Profession.Location = new System.Drawing.Point(102, 149);
            this.L_Profession.Name = "L_Profession";
            this.L_Profession.Size = new System.Drawing.Size(56, 13);
            this.L_Profession.TabIndex = 6;
            this.L_Profession.Text = "Profession";
            // 
            // L_BG
            // 
            this.L_BG.AutoSize = true;
            this.L_BG.Location = new System.Drawing.Point(414, 91);
            this.L_BG.Name = "L_BG";
            this.L_BG.Size = new System.Drawing.Size(22, 13);
            this.L_BG.TabIndex = 7;
            this.L_BG.Text = "BG";
            // 
            // L_Phone
            // 
            this.L_Phone.AutoSize = true;
            this.L_Phone.Location = new System.Drawing.Point(377, 128);
            this.L_Phone.Name = "L_Phone";
            this.L_Phone.Size = new System.Drawing.Size(38, 13);
            this.L_Phone.TabIndex = 8;
            this.L_Phone.Text = "Phone";
            // 
            // L_Address
            // 
            this.L_Address.AutoSize = true;
            this.L_Address.Location = new System.Drawing.Point(684, 69);
            this.L_Address.Name = "L_Address";
            this.L_Address.Size = new System.Drawing.Size(45, 13);
            this.L_Address.TabIndex = 9;
            this.L_Address.Text = "Address";
            this.L_Address.Click += new System.EventHandler(this.L_Address_Click);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(143, 71);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(175, 20);
            this.TB_Name.TabIndex = 10;
            // 
            // TB_NID
            // 
            this.TB_NID.Location = new System.Drawing.Point(143, 109);
            this.TB_NID.Name = "TB_NID";
            this.TB_NID.Size = new System.Drawing.Size(175, 20);
            this.TB_NID.TabIndex = 11;
            // 
            // TB_Profession
            // 
            this.TB_Profession.Location = new System.Drawing.Point(165, 146);
            this.TB_Profession.Name = "TB_Profession";
            this.TB_Profession.Size = new System.Drawing.Size(131, 20);
            this.TB_Profession.TabIndex = 12;
            // 
            // TB_BG
            // 
            this.TB_BG.Location = new System.Drawing.Point(442, 88);
            this.TB_BG.Name = "TB_BG";
            this.TB_BG.Size = new System.Drawing.Size(109, 20);
            this.TB_BG.TabIndex = 13;
            // 
            // TB_Phone
            // 
            this.TB_Phone.Location = new System.Drawing.Point(421, 125);
            this.TB_Phone.Name = "TB_Phone";
            this.TB_Phone.Size = new System.Drawing.Size(157, 20);
            this.TB_Phone.TabIndex = 14;
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(642, 85);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(119, 60);
            this.TB_Address.TabIndex = 16;
            this.TB_Address.Text = "";
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(40, 294);
            this.DGV.Name = "DGV";
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(721, 150);
            this.DGV.TabIndex = 17;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // Blood_Bank_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(794, 456);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TB_Address);
            this.Controls.Add(this.TB_Phone);
            this.Controls.Add(this.TB_BG);
            this.Controls.Add(this.TB_Profession);
            this.Controls.Add(this.TB_NID);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.L_Address);
            this.Controls.Add(this.L_Phone);
            this.Controls.Add(this.L_BG);
            this.Controls.Add(this.L_Profession);
            this.Controls.Add(this.L_NID);
            this.Controls.Add(this.L_Name);
            this.Controls.Add(this.B_Reset);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Update);
            this.Controls.Add(this.B_Insert);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blood_Bank_Register";
            this.Text = "Blood_Bank";
            this.Load += new System.EventHandler(this.Blood_Bank_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Insert;
        private System.Windows.Forms.Button B_Update;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Reset;
        private System.Windows.Forms.Label L_Name;
        private System.Windows.Forms.Label L_NID;
        private System.Windows.Forms.Label L_Profession;
        private System.Windows.Forms.Label L_BG;
        private System.Windows.Forms.Label L_Phone;
        private System.Windows.Forms.Label L_Address;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_NID;
        private System.Windows.Forms.TextBox TB_Profession;
        private System.Windows.Forms.TextBox TB_BG;
        private System.Windows.Forms.TextBox TB_Phone;
        private System.Windows.Forms.RichTextBox TB_Address;
        private System.Windows.Forms.DataGridView DGV;
    }
}

