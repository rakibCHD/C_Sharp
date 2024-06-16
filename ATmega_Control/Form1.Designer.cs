
namespace Arduino_Control
{
    partial class AVR_ATMEGA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AVR_ATMEGA));
            this.On = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.AtmegaAbout = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pin_Label = new System.Windows.Forms.Label();
            this.UploadHex = new System.Windows.Forms.Button();
            this.hexLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disconnect = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.Label();
            this.Reconnect = new System.Windows.Forms.Button();
            this.ledStatus = new System.Windows.Forms.Label();
            this.Guideline_Label = new System.Windows.Forms.Label();
            this.BlinkOn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ms = new System.Windows.Forms.Label();
            this.BlinkOff = new System.Windows.Forms.Button();
            this.Chipname = new System.Windows.Forms.Label();
            this.ChipL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // On
            // 
            this.On.BackColor = System.Drawing.Color.LightGray;
            this.On.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.On.Location = new System.Drawing.Point(266, 169);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(82, 38);
            this.On.TabIndex = 0;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = false;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // Off
            // 
            this.Off.BackColor = System.Drawing.Color.LightGray;
            this.Off.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Off.Location = new System.Drawing.Point(446, 169);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(82, 40);
            this.Off.TabIndex = 1;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = false;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // AtmegaAbout
            // 
            this.AtmegaAbout.AutoSize = true;
            this.AtmegaAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtmegaAbout.Location = new System.Drawing.Point(310, 14);
            this.AtmegaAbout.Name = "AtmegaAbout";
            this.AtmegaAbout.Size = new System.Drawing.Size(192, 47);
            this.AtmegaAbout.TabIndex = 2;
            this.AtmegaAbout.Text = "ATMEGA";
            this.AtmegaAbout.Click += new System.EventHandler(this.AtmegaAbout_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(583, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1194F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pins";
            // 
            // Pin_Label
            // 
            this.Pin_Label.AutoSize = true;
            this.Pin_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pin_Label.Location = new System.Drawing.Point(296, 334);
            this.Pin_Label.Name = "Pin_Label";
            this.Pin_Label.Size = new System.Drawing.Size(37, 24);
            this.Pin_Label.TabIndex = 9;
            this.Pin_Label.Text = "Pin";
            // 
            // UploadHex
            // 
            this.UploadHex.BackColor = System.Drawing.Color.LightGray;
            this.UploadHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadHex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadHex.Location = new System.Drawing.Point(324, 415);
            this.UploadHex.Name = "UploadHex";
            this.UploadHex.Size = new System.Drawing.Size(149, 38);
            this.UploadHex.TabIndex = 14;
            this.UploadHex.Text = "Upload(.hex)";
            this.UploadHex.UseVisualStyleBackColor = false;
            this.UploadHex.Click += new System.EventHandler(this.UploadHex_Click);
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexLabel.ForeColor = System.Drawing.Color.Black;
            this.hexLabel.Location = new System.Drawing.Point(192, 469);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(53, 25);
            this.hexLabel.TabIndex = 15;
            this.hexLabel.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 58);
            this.label2.TabIndex = 22;
            this.label2.Text = "Connected Port:\r\n\r\n";
            // 
            // disconnect
            // 
            this.disconnect.BackColor = System.Drawing.Color.LightGray;
            this.disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnect.Location = new System.Drawing.Point(31, 305);
            this.disconnect.Name = "disconnect";
            this.disconnect.Size = new System.Drawing.Size(131, 38);
            this.disconnect.TabIndex = 23;
            this.disconnect.Text = "Disconnect";
            this.disconnect.UseVisualStyleBackColor = false;
            this.disconnect.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(46, 172);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(47, 24);
            this.Port.TabIndex = 24;
            this.Port.Text = "Port";
            // 
            // Reconnect
            // 
            this.Reconnect.BackColor = System.Drawing.Color.LightGray;
            this.Reconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reconnect.Location = new System.Drawing.Point(31, 227);
            this.Reconnect.Name = "Reconnect";
            this.Reconnect.Size = new System.Drawing.Size(131, 38);
            this.Reconnect.TabIndex = 25;
            this.Reconnect.Text = "Reconnect";
            this.Reconnect.UseVisualStyleBackColor = false;
            this.Reconnect.Click += new System.EventHandler(this.Reconnect_Click);
            // 
            // ledStatus
            // 
            this.ledStatus.AutoSize = true;
            this.ledStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledStatus.Location = new System.Drawing.Point(353, 374);
            this.ledStatus.Name = "ledStatus";
            this.ledStatus.Size = new System.Drawing.Size(65, 24);
            this.ledStatus.TabIndex = 26;
            this.ledStatus.Text = "Led is ";
            // 
            // Guideline_Label
            // 
            this.Guideline_Label.AutoSize = true;
            this.Guideline_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.74627F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guideline_Label.ForeColor = System.Drawing.Color.DarkGreen;
            this.Guideline_Label.Location = new System.Drawing.Point(651, 494);
            this.Guideline_Label.Name = "Guideline_Label";
            this.Guideline_Label.Size = new System.Drawing.Size(141, 25);
            this.Guideline_Label.TabIndex = 27;
            this.Guideline_Label.Text = "@GuideLine";
            this.Guideline_Label.Click += new System.EventHandler(this.Guideline_Label_Click);
            // 
            // BlinkOn
            // 
            this.BlinkOn.BackColor = System.Drawing.Color.LightGray;
            this.BlinkOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlinkOn.Location = new System.Drawing.Point(266, 270);
            this.BlinkOn.Name = "BlinkOn";
            this.BlinkOn.Size = new System.Drawing.Size(108, 40);
            this.BlinkOn.TabIndex = 28;
            this.BlinkOn.Text = "Blink On";
            this.BlinkOn.UseVisualStyleBackColor = false;
            this.BlinkOn.Click += new System.EventHandler(this.BlinkOn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms.Location = new System.Drawing.Point(459, 228);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(35, 24);
            this.ms.TabIndex = 30;
            this.ms.Text = "ms";
            // 
            // BlinkOff
            // 
            this.BlinkOff.BackColor = System.Drawing.Color.LightGray;
            this.BlinkOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlinkOff.Location = new System.Drawing.Point(420, 270);
            this.BlinkOff.Name = "BlinkOff";
            this.BlinkOff.Size = new System.Drawing.Size(108, 40);
            this.BlinkOff.TabIndex = 31;
            this.BlinkOff.Text = "Blink Off";
            this.BlinkOff.UseVisualStyleBackColor = false;
            this.BlinkOff.Click += new System.EventHandler(this.BlinkOff_Click);
            // 
            // Chipname
            // 
            this.Chipname.AutoSize = true;
            this.Chipname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chipname.Location = new System.Drawing.Point(186, 90);
            this.Chipname.Name = "Chipname";
            this.Chipname.Size = new System.Drawing.Size(53, 24);
            this.Chipname.TabIndex = 33;
            this.Chipname.Text = "Chip";
            // 
            // ChipL
            // 
            this.ChipL.AutoSize = true;
            this.ChipL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipL.Location = new System.Drawing.Point(4, 86);
            this.ChipL.Name = "ChipL";
            this.ChipL.Size = new System.Drawing.Size(192, 58);
            this.ChipL.TabIndex = 32;
            this.ChipL.Text = "Connected Chip:\r\n\r\n";
            // 
            // AVR_ATMEGA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 523);
            this.Controls.Add(this.Chipname);
            this.Controls.Add(this.ChipL);
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
            this.Controls.Add(this.hexLabel);
            this.Controls.Add(this.UploadHex);
            this.Controls.Add(this.Pin_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AtmegaAbout);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AVR_ATMEGA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AVR_ATMEGA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button On;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Label AtmegaAbout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Pin_Label;
        private System.Windows.Forms.Button UploadHex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button disconnect;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button Reconnect;
        private System.Windows.Forms.Label ledStatus;
        public System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Label Guideline_Label;
        private System.Windows.Forms.Button BlinkOn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.Button BlinkOff;
        private System.Windows.Forms.Label Chipname;
        private System.Windows.Forms.Label ChipL;
    }
}

