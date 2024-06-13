
namespace ESP_Control
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BlinkOff = new System.Windows.Forms.Button();
            this.ms = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BlinkOn = new System.Windows.Forms.Button();
            this.Guideline_Label = new System.Windows.Forms.Label();
            this.ledStatus = new System.Windows.Forms.Label();
            this.Reconnect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.binLabel = new System.Windows.Forms.Label();
            this.UploadBin = new System.Windows.Forms.Button();
            this.Pin_Label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ESP_About = new System.Windows.Forms.Label();
            this.Off = new System.Windows.Forms.Button();
            this.On = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BlinkOff
            // 
            this.BlinkOff.BackColor = System.Drawing.Color.LightGray;
            this.BlinkOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlinkOff.Location = new System.Drawing.Point(487, 256);
            this.BlinkOff.Name = "BlinkOff";
            this.BlinkOff.Size = new System.Drawing.Size(108, 40);
            this.BlinkOff.TabIndex = 49;
            this.BlinkOff.Text = "Blink Off";
            this.BlinkOff.UseVisualStyleBackColor = false;
            this.BlinkOff.Click += new System.EventHandler(this.BlinkOff_Click);
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.Location = new System.Drawing.Point(526, 214);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(35, 24);
            this.ms.TabIndex = 48;
            this.ms.Text = "ms";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 47;
            // 
            // BlinkOn
            // 
            this.BlinkOn.BackColor = System.Drawing.Color.LightGray;
            this.BlinkOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlinkOn.Location = new System.Drawing.Point(333, 256);
            this.BlinkOn.Name = "BlinkOn";
            this.BlinkOn.Size = new System.Drawing.Size(108, 40);
            this.BlinkOn.TabIndex = 46;
            this.BlinkOn.Text = "Blink On";
            this.BlinkOn.UseVisualStyleBackColor = false;
            this.BlinkOn.Click += new System.EventHandler(this.BlinkOn_Click);
            // 
            // Guideline_Label
            // 
            this.Guideline_Label.AutoSize = true;
            this.Guideline_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guideline_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Guideline_Label.Location = new System.Drawing.Point(800, 520);
            this.Guideline_Label.Name = "Guideline_Label";
            this.Guideline_Label.Size = new System.Drawing.Size(141, 25);
            this.Guideline_Label.TabIndex = 45;
            this.Guideline_Label.Text = "@GuideLine";
            this.Guideline_Label.Click += new System.EventHandler(this.Guideline_Label_Click);
            // 
            // ledStatus
            // 
            this.ledStatus.AutoSize = true;
            this.ledStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledStatus.Location = new System.Drawing.Point(420, 364);
            this.ledStatus.Name = "ledStatus";
            this.ledStatus.Size = new System.Drawing.Size(65, 24);
            this.ledStatus.TabIndex = 44;
            this.ledStatus.Text = "Led is ";
            // 
            // Reconnect
            // 
            this.Reconnect.BackColor = System.Drawing.Color.LightGray;
            this.Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect.Location = new System.Drawing.Point(88, 258);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(131, 38);
            this.Reconnect.TabIndex = 43;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = false;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(148, 176);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(40, 18);
            this.Port.TabIndex = 42;
            this.Port.Text = "Port";
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.LightGray;
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(88, 313);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(131, 38);
            this.disconnect.TabIndex = 41;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Connected Port\r\n";
            // 
            // binLabel
            // 
            this.binLabel.AutoSize = true;
            this.binLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binLabel.ForeColor = System.Drawing.Color.Black;
            this.binLabel.Location = new System.Drawing.Point(239, 484);
            this.binLabel.Name = "binLabel";
            this.binLabel.Size = new System.Drawing.Size(46, 25);
            this.binLabel.TabIndex = 39;
            this.binLabel.Text = "Bin";
            // 
            // UploadBin
            // 
            this.UploadBin.BackColor = System.Drawing.Color.LightGray;
            this.UploadBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadBin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadBin.Location = new System.Drawing.Point(397, 420);
            this.UploadBin.Name = "UploadBin";
            this.UploadBin.Size = new System.Drawing.Size(149, 38);
            this.UploadBin.TabIndex = 38;
            this.UploadBin.Text = "Upload(.bin)";
            this.UploadBin.UseVisualStyleBackColor = false;
            this.UploadBin.Click += new System.EventHandler(this.UploadBin_Click);
            // 
            // Pin_Label
            // 
            this.Pin_Label.AutoSize = true;
            this.Pin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin_Label.Location = new System.Drawing.Point(363, 323);
            this.Pin_Label.Name = "Pin_Label";
            this.Pin_Label.Size = new System.Drawing.Size(37, 24);
            this.Pin_Label.TabIndex = 37;
            this.Pin_Label.Text = "Pin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(669, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 36);
            this.label4.TabIndex = 36;
            this.label4.Text = "Pins";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(650, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ESP_About
            // 
            this.ESP_About.AutoSize = true;
            this.ESP_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESP_About.Location = new System.Drawing.Point(379, 34);
            this.ESP_About.Name = "ESP_About";
            this.ESP_About.Size = new System.Drawing.Size(193, 47);
            this.ESP_About.TabIndex = 34;
            this.ESP_About.Text = "ESP8266";
            this.ESP_About.Click += new System.EventHandler(this.ESP_About_Click);
            // 
            // Off
            // 
            this.Off.BackColor = System.Drawing.Color.LightGray;
            this.Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Off.Location = new System.Drawing.Point(513, 155);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(82, 40);
            this.Off.TabIndex = 33;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = false;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // On
            // 
            this.On.BackColor = System.Drawing.Color.LightGray;
            this.On.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On.Location = new System.Drawing.Point(333, 155);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(82, 38);
            this.On.TabIndex = 32;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = false;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(949, 553);
            this.Controls.Add(this.BlinkOff);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BlinkOn);
            this.Controls.Add(this.Guideline_Label);
            this.Controls.Add(this.ledStatus);
            this.Controls.Add(this.Reconnect);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.disconnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.binLabel);
            this.Controls.Add(this.UploadBin);
            this.Controls.Add(this.Pin_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ESP_About);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BlinkOff;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BlinkOn;
        private System.Windows.Forms.Label Guideline_Label;
        private System.Windows.Forms.Label ledStatus;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label binLabel;
        private System.Windows.Forms.Button UploadBin;
        private System.Windows.Forms.Label Pin_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ESP_About;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button On;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

