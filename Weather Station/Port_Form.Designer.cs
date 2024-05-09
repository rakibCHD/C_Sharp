
namespace Weather_Station
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
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HexPath_tb = new System.Windows.Forms.TextBox();
            this.AvrConfigPath_tb = new System.Windows.Forms.TextBox();
            this.AvrdudePath_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Browse_hex = new System.Windows.Forms.Button();
            this.Browse_avrconfig = new System.Windows.Forms.Button();
            this.Browse_avrdude = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.arrow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.Flash = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // HexPath_tb
            // 
            this.HexPath_tb.Location = new System.Drawing.Point(282, 242);
            this.HexPath_tb.Name = "HexPath_tb";
            this.HexPath_tb.Size = new System.Drawing.Size(505, 22);
            this.HexPath_tb.TabIndex = 45;
            // 
            // AvrConfigPath_tb
            // 
            this.AvrConfigPath_tb.Location = new System.Drawing.Point(282, 178);
            this.AvrConfigPath_tb.Name = "AvrConfigPath_tb";
            this.AvrConfigPath_tb.Size = new System.Drawing.Size(505, 22);
            this.AvrConfigPath_tb.TabIndex = 44;
            // 
            // AvrdudePath_tb
            // 
            this.AvrdudePath_tb.Location = new System.Drawing.Point(282, 116);
            this.AvrdudePath_tb.Name = "AvrdudePath_tb";
            this.AvrdudePath_tb.Size = new System.Drawing.Size(505, 22);
            this.AvrdudePath_tb.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "(.hex file)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(680, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "ChipConfig.conf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Programmer.exe";
            // 
            // Browse_hex
            // 
            this.Browse_hex.Location = new System.Drawing.Point(603, 218);
            this.Browse_hex.Name = "Browse_hex";
            this.Browse_hex.Size = new System.Drawing.Size(75, 23);
            this.Browse_hex.TabIndex = 39;
            this.Browse_hex.Text = "Browse";
            this.Browse_hex.UseVisualStyleBackColor = true;
            this.Browse_hex.Click += new System.EventHandler(this.Browse_hex_Click);
            // 
            // Browse_avrconfig
            // 
            this.Browse_avrconfig.Location = new System.Drawing.Point(603, 154);
            this.Browse_avrconfig.Name = "Browse_avrconfig";
            this.Browse_avrconfig.Size = new System.Drawing.Size(75, 23);
            this.Browse_avrconfig.TabIndex = 38;
            this.Browse_avrconfig.Text = "Browse";
            this.Browse_avrconfig.UseVisualStyleBackColor = true;
            this.Browse_avrconfig.Click += new System.EventHandler(this.Browse_avrconfig_Click);
            // 
            // Browse_avrdude
            // 
            this.Browse_avrdude.Location = new System.Drawing.Point(601, 91);
            this.Browse_avrdude.Name = "Browse_avrdude";
            this.Browse_avrdude.Size = new System.Drawing.Size(75, 23);
            this.Browse_avrdude.TabIndex = 37;
            this.Browse_avrdude.Text = "Browse";
            this.Browse_avrdude.UseVisualStyleBackColor = true;
            this.Browse_avrdude.Click += new System.EventHandler(this.Browse_avrdude_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.97015F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 47);
            this.button1.TabIndex = 36;
            this.button1.Text = "Find Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // arrow
            // 
            this.arrow.AutoSize = true;
            this.arrow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.9403F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow.Location = new System.Drawing.Point(391, 354);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(53, 61);
            this.arrow.TabIndex = 35;
            this.arrow.Text = "⮮";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 36);
            this.label1.TabIndex = 33;
            this.label1.Text = "Upload Weather hex file for Arduino";
            // 
            // Flash
            // 
            this.Flash.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Flash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flash.Location = new System.Drawing.Point(349, 418);
            this.Flash.Name = "Flash";
            this.Flash.Size = new System.Drawing.Size(131, 38);
            this.Flash.TabIndex = 32;
            this.Flash.Text = "Flash";
            this.Flash.UseVisualStyleBackColor = false;
            this.Flash.Click += new System.EventHandler(this.Flash_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Port_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 490);
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
            this.Controls.Add(this.Flash);
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
        public System.Windows.Forms.TextBox HexPath_tb;
        public System.Windows.Forms.TextBox AvrConfigPath_tb;
        public System.Windows.Forms.TextBox AvrdudePath_tb;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button Browse_hex;
        public System.Windows.Forms.Button Browse_avrconfig;
        public System.Windows.Forms.Button Browse_avrdude;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label arrow;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Flash;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}