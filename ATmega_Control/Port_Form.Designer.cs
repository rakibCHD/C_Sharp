
namespace Arduino_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Port_Form));
            this.flash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.arrow = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Browse_Exe = new System.Windows.Forms.Button();
            this.Browse_Config = new System.Windows.Forms.Button();
            this.Browse_hex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ExePath_tb = new System.Windows.Forms.TextBox();
            this.ConfigPath_tb = new System.Windows.Forms.TextBox();
            this.HexPath_tb = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LeftArrow = new System.Windows.Forms.Label();
            this.Back_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Chip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flash
            // 
            this.flash.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flash.Location = new System.Drawing.Point(331, 390);
            this.flash.Name = "flash";
            this.flash.Size = new System.Drawing.Size(131, 38);
            this.flash.TabIndex = 16;
            this.flash.Text = "Flash";
            this.flash.UseVisualStyleBackColor = false;
            this.flash.Click += new System.EventHandler(this.flash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Upload Dedicated hex file for Arduino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(202, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Port";
            // 
            // arrow
            // 
            this.arrow.AutoSize = true;
            this.arrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(373, 324);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(53, 61);
            this.arrow.TabIndex = 21;
            this.arrow.Text = "⮮";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 47);
            this.button1.TabIndex = 22;
            this.button1.Text = "Find Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Browse_Exe
            // 
            this.Browse_Exe.Location = new System.Drawing.Point(583, 87);
            this.Browse_Exe.Name = "Browse_Exe";
            this.Browse_Exe.Size = new System.Drawing.Size(75, 23);
            this.Browse_Exe.TabIndex = 23;
            this.Browse_Exe.Text = "Browse";
            this.Browse_Exe.UseVisualStyleBackColor = true;
            this.Browse_Exe.Click += new System.EventHandler(this.Browse_Exe_Click);
            // 
            // Browse_Config
            // 
            this.Browse_Config.Location = new System.Drawing.Point(585, 150);
            this.Browse_Config.Name = "Browse_Config";
            this.Browse_Config.Size = new System.Drawing.Size(75, 23);
            this.Browse_Config.TabIndex = 24;
            this.Browse_Config.Text = "Browse";
            this.Browse_Config.UseVisualStyleBackColor = true;
            this.Browse_Config.Click += new System.EventHandler(this.Browse_Config_Click);
            // 
            // Browse_hex
            // 
            this.Browse_hex.Location = new System.Drawing.Point(585, 214);
            this.Browse_hex.Name = "Browse_hex";
            this.Browse_hex.Size = new System.Drawing.Size(75, 23);
            this.Browse_hex.TabIndex = 25;
            this.Browse_hex.Text = "Browse";
            this.Browse_hex.UseVisualStyleBackColor = true;
            this.Browse_hex.Click += new System.EventHandler(this.Browse_hex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Programmer.exe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(662, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "ChipConfig.conf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "(.hex file)";
            // 
            // ExePath_tb
            // 
            this.ExePath_tb.Location = new System.Drawing.Point(264, 112);
            this.ExePath_tb.Name = "ExePath_tb";
            this.ExePath_tb.Size = new System.Drawing.Size(499, 22);
            this.ExePath_tb.TabIndex = 29;
            // 
            // ConfigPath_tb
            // 
            this.ConfigPath_tb.Location = new System.Drawing.Point(264, 174);
            this.ConfigPath_tb.Name = "ConfigPath_tb";
            this.ConfigPath_tb.Size = new System.Drawing.Size(499, 22);
            this.ConfigPath_tb.TabIndex = 30;
            // 
            // HexPath_tb
            // 
            this.HexPath_tb.Location = new System.Drawing.Point(264, 238);
            this.HexPath_tb.Name = "HexPath_tb";
            this.HexPath_tb.Size = new System.Drawing.Size(499, 22);
            this.HexPath_tb.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LeftArrow
            // 
            this.LeftArrow.AutoSize = true;
            this.LeftArrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.LeftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftArrow.Location = new System.Drawing.Point(171, 161);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(88, 61);
            this.LeftArrow.TabIndex = 47;
            this.LeftArrow.Text = "👈🏼";
            // 
            // Back_btn
            // 
            this.Back_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(12, 390);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(100, 38);
            this.Back_btn.TabIndex = 48;
            this.Back_btn.Text = "<<Back";
            this.Back_btn.UseVisualStyleBackColor = false;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 50;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Chip
            // 
            this.Chip.AutoSize = true;
            this.Chip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chip.Location = new System.Drawing.Point(65, 58);
            this.Chip.Name = "Chip";
            this.Chip.Size = new System.Drawing.Size(49, 24);
            this.Chip.TabIndex = 51;
            this.Chip.Text = "Chip";
            // 
            // Port_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.Chip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.HexPath_tb);
            this.Controls.Add(this.ConfigPath_tb);
            this.Controls.Add(this.ExePath_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Browse_hex);
            this.Controls.Add(this.Browse_Config);
            this.Controls.Add(this.Browse_Exe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Port_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Port_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button Browse_Exe;
        public System.Windows.Forms.Button Browse_Config;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox ExePath_tb;
        public System.Windows.Forms.TextBox ConfigPath_tb;
        public System.Windows.Forms.Button flash;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label arrow;
        public System.Windows.Forms.Button Browse_hex;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox HexPath_tb;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LeftArrow;
        public System.Windows.Forms.Button Back_btn;
        public System.Windows.Forms.Label Chip;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}