
namespace ESP_Control
{
    partial class Port_Form
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
            this.components = new System.ComponentModel.Container();
            this.Back_btn = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Label();
            this.BinPath_tb = new System.Windows.Forms.TextBox();
            this.ExePath_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Browse_Bin = new System.Windows.Forms.Button();
            this.Browse_Exe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.arrow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flash = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(9, 388);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 38);
            this.Back_btn.TabIndex = 61;
            this.Back_btn.Text = "<<Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.AutoSize = true;
            this.LeftArrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.LeftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftArrow.Location = new System.Drawing.Point(177, 145);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(88, 61);
            this.LeftArrow.TabIndex = 60;
            this.LeftArrow.Text = "👈🏼";
            // 
            // BinPath_tb
            // 
            this.BinPath_tb.Location = new System.Drawing.Point(279, 213);
            this.BinPath_tb.Name = "BinPath_tb";
            this.BinPath_tb.Size = new System.Drawing.Size(499, 22);
            this.BinPath_tb.TabIndex = 59;
            // 
            // ExePath_tb
            // 
            this.ExePath_tb.Location = new System.Drawing.Point(279, 131);
            this.ExePath_tb.Name = "ExePath_tb";
            this.ExePath_tb.Size = new System.Drawing.Size(499, 22);
            this.ExePath_tb.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "(.bin file)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Programmer.exe";
            // 
            // Browse_Bin
            // 
            this.Browse_Bin.Location = new System.Drawing.Point(600, 189);
            this.Browse_Bin.Name = "Browse_Bin";
            this.Browse_Bin.Size = new System.Drawing.Size(75, 23);
            this.Browse_Bin.TabIndex = 55;
            this.Browse_Bin.Text = "Browse";
            this.Browse_Bin.UseVisualStyleBackColor = true;
            this.Browse_Bin.Click += new System.EventHandler(this.Browse_Bin_Click);
            // 
            // Browse_Exe
            // 
            this.Browse_Exe.Location = new System.Drawing.Point(598, 106);
            this.Browse_Exe.Name = "Browse_Exe";
            this.Browse_Exe.Size = new System.Drawing.Size(75, 23);
            this.Browse_Exe.TabIndex = 54;
            this.Browse_Exe.Text = "Browse";
            this.Browse_Exe.UseVisualStyleBackColor = true;
            this.Browse_Exe.Click += new System.EventHandler(this.Browse_Exe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(8, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 47);
            this.button1.TabIndex = 53;
            this.button1.Text = "Find Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arrow
            // 
            this.arrow.AutoSize = true;
            this.arrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(370, 322);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(53, 61);
            this.arrow.TabIndex = 52;
            this.arrow.Text = "⮮";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 36);
            this.label1.TabIndex = 50;
            this.label1.Text = "Upload Dedicated Bin file for ESP";
            // 
            // flash
            // 
            this.flash.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash.Location = new System.Drawing.Point(328, 388);
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(131, 38);
            this.flash.TabIndex = 49;
            this.flash.Text = "Flash";
            this.flash.UseVisualStyleBackColor = false;
            this.flash.Click += new System.EventHandler(this.flash_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Port_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(795, 445);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.BinPath_tb);
            this.Controls.Add(this.ExePath_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Browse_Bin);
            this.Controls.Add(this.Browse_Exe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Port_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port_Form";
            this.Load += new System.EventHandler(this.Port_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Back_btn;
        public System.Windows.Forms.Label LeftArrow;
        public System.Windows.Forms.TextBox BinPath_tb;
        public System.Windows.Forms.TextBox ExePath_tb;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Browse_Bin;
        public System.Windows.Forms.Button Browse_Exe;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label arrow;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button flash;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}