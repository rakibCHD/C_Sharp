
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
            this.Browse_avrdude = new System.Windows.Forms.Button();
            this.Browse_avrconfig = new System.Windows.Forms.Button();
            this.Browse_hex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AvrdudePath_tb = new System.Windows.Forms.TextBox();
            this.AvrConfigPath_tb = new System.Windows.Forms.TextBox();
            this.HexPath_tb = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.flash.Click += new System.EventHandler(this.flash_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 14);
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
            // Browse_avrdude
            // 
            this.Browse_avrdude.Location = new System.Drawing.Point(583, 87);
            this.Browse_avrdude.Name = "Browse_avrdude";
            this.Browse_avrdude.Size = new System.Drawing.Size(75, 23);
            this.Browse_avrdude.TabIndex = 23;
            this.Browse_avrdude.Text = "Browse";
            this.Browse_avrdude.UseVisualStyleBackColor = true;
            this.Browse_avrdude.Click += new System.EventHandler(this.Browse_avrdude_Click);
            // 
            // Browse_avrconfig
            // 
            this.Browse_avrconfig.Location = new System.Drawing.Point(585, 150);
            this.Browse_avrconfig.Name = "Browse_avrconfig";
            this.Browse_avrconfig.Size = new System.Drawing.Size(75, 23);
            this.Browse_avrconfig.TabIndex = 24;
            this.Browse_avrconfig.Text = "Browse";
            this.Browse_avrconfig.UseVisualStyleBackColor = true;
            this.Browse_avrconfig.Click += new System.EventHandler(this.Browse_avrconfig_Click);
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
            // AvrdudePath_tb
            // 
            this.AvrdudePath_tb.Location = new System.Drawing.Point(264, 112);
            this.AvrdudePath_tb.Name = "AvrdudePath_tb";
            this.AvrdudePath_tb.Size = new System.Drawing.Size(499, 22);
            this.AvrdudePath_tb.TabIndex = 29;
            // 
            // AvrConfigPath_tb
            // 
            this.AvrConfigPath_tb.Location = new System.Drawing.Point(264, 174);
            this.AvrConfigPath_tb.Name = "AvrConfigPath_tb";
            this.AvrConfigPath_tb.Size = new System.Drawing.Size(499, 22);
            this.AvrConfigPath_tb.TabIndex = 30;
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
            // Port_Form
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(794, 446);
            this.Controls.Add(this.HexPath_tb);
            this.Controls.Add(this.AvrConfigPath_tb);
            this.Controls.Add(this.AvrdudePath_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Browse_hex);
            this.Controls.Add(this.Browse_avrconfig);
            this.Controls.Add(this.Browse_avrdude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.arrow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Port_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port_Form";
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
        public System.Windows.Forms.Button Browse_avrdude;
        public System.Windows.Forms.Button Browse_avrconfig;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox AvrdudePath_tb;
        public System.Windows.Forms.TextBox AvrConfigPath_tb;
        public System.Windows.Forms.Button flash;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label arrow;
        public System.Windows.Forms.Button Browse_hex;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox HexPath_tb;
        public System.Windows.Forms.Label label1;
    }
}