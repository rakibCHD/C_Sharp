
namespace Weather_Station
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Pressure = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.Label();
            this.UploadHex = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Prediction = new System.Windows.Forms.Label();
            this.Light = new System.Windows.Forms.Label();
            this.Punit = new System.Windows.Forms.Label();
            this.Tunit = new System.Windows.Forms.Label();
            this.Lunit = new System.Windows.Forms.Label();
            this.Funit = new System.Windows.Forms.Label();
            this.Farenheight = new System.Windows.Forms.Label();
            this.Kunit = new System.Windows.Forms.Label();
            this.Kelvin = new System.Windows.Forms.Label();
            this.Kpunit = new System.Windows.Forms.Label();
            this.KiloP = new System.Windows.Forms.Label();
            this.Hunit = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Aunit = new System.Windows.Forms.Label();
            this.Altitude = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bpunit = new System.Windows.Forms.Label();
            this.Barp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.About = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.26866F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digital Weather Station\r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Air Pressure:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(618, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Light:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(561, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Prediction:";
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pressure.Location = new System.Drawing.Point(278, 292);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(30, 29);
            this.Pressure.TabIndex = 10;
            this.Pressure.Text = "P";
            // 
            // Temperature
            // 
            this.Temperature.AutoSize = true;
            this.Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperature.Location = new System.Drawing.Point(281, 112);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(30, 29);
            this.Temperature.TabIndex = 7;
            this.Temperature.Text = "T";
            // 
            // UploadHex
            // 
            this.UploadHex.BackColor = System.Drawing.Color.LightGray;
            this.UploadHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadHex.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadHex.Location = new System.Drawing.Point(390, 486);
            this.UploadHex.Name = "UploadHex";
            this.UploadHex.Size = new System.Drawing.Size(149, 38);
            this.UploadHex.TabIndex = 15;
            this.UploadHex.Text = "Upload(.hex)";
            this.UploadHex.UseVisualStyleBackColor = false;
            this.UploadHex.Click += new System.EventHandler(this.UploadHex_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Prediction
            // 
            this.Prediction.AutoSize = true;
            this.Prediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prediction.Location = new System.Drawing.Point(701, 349);
            this.Prediction.Name = "Prediction";
            this.Prediction.Size = new System.Drawing.Size(28, 29);
            this.Prediction.TabIndex = 17;
            this.Prediction.Text = "p";
            // 
            // Light
            // 
            this.Light.AutoSize = true;
            this.Light.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Light.Location = new System.Drawing.Point(694, 272);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(27, 29);
            this.Light.TabIndex = 16;
            this.Light.Text = "L";
            // 
            // Punit
            // 
            this.Punit.AutoSize = true;
            this.Punit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punit.Location = new System.Drawing.Point(404, 292);
            this.Punit.Name = "Punit";
            this.Punit.Size = new System.Drawing.Size(27, 29);
            this.Punit.TabIndex = 21;
            this.Punit.Text = "u";
            // 
            // Tunit
            // 
            this.Tunit.AutoSize = true;
            this.Tunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tunit.Location = new System.Drawing.Point(369, 112);
            this.Tunit.Name = "Tunit";
            this.Tunit.Size = new System.Drawing.Size(27, 29);
            this.Tunit.TabIndex = 18;
            this.Tunit.Text = "u";
            // 
            // Lunit
            // 
            this.Lunit.AutoSize = true;
            this.Lunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunit.Location = new System.Drawing.Point(738, 272);
            this.Lunit.Name = "Lunit";
            this.Lunit.Size = new System.Drawing.Size(27, 29);
            this.Lunit.TabIndex = 24;
            this.Lunit.Text = "u";
            // 
            // Funit
            // 
            this.Funit.AutoSize = true;
            this.Funit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Funit.Location = new System.Drawing.Point(369, 157);
            this.Funit.Name = "Funit";
            this.Funit.Size = new System.Drawing.Size(27, 29);
            this.Funit.TabIndex = 27;
            this.Funit.Text = "u";
            // 
            // Farenheight
            // 
            this.Farenheight.AutoSize = true;
            this.Farenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Farenheight.Location = new System.Drawing.Point(282, 157);
            this.Farenheight.Name = "Farenheight";
            this.Farenheight.Size = new System.Drawing.Size(29, 29);
            this.Farenheight.TabIndex = 26;
            this.Farenheight.Text = "F";
            // 
            // Kunit
            // 
            this.Kunit.AutoSize = true;
            this.Kunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kunit.Location = new System.Drawing.Point(369, 202);
            this.Kunit.Name = "Kunit";
            this.Kunit.Size = new System.Drawing.Size(27, 29);
            this.Kunit.TabIndex = 29;
            this.Kunit.Text = "u";
            // 
            // Kelvin
            // 
            this.Kelvin.AutoSize = true;
            this.Kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kelvin.Location = new System.Drawing.Point(281, 202);
            this.Kelvin.Name = "Kelvin";
            this.Kelvin.Size = new System.Drawing.Size(30, 29);
            this.Kelvin.TabIndex = 28;
            this.Kelvin.Text = "K";
            // 
            // Kpunit
            // 
            this.Kpunit.AutoSize = true;
            this.Kpunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kpunit.Location = new System.Drawing.Point(407, 341);
            this.Kpunit.Name = "Kpunit";
            this.Kpunit.Size = new System.Drawing.Size(27, 29);
            this.Kpunit.TabIndex = 31;
            this.Kpunit.Text = "u";
            // 
            // KiloP
            // 
            this.KiloP.AutoSize = true;
            this.KiloP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KiloP.Location = new System.Drawing.Point(277, 343);
            this.KiloP.Name = "KiloP";
            this.KiloP.Size = new System.Drawing.Size(45, 29);
            this.KiloP.TabIndex = 30;
            this.KiloP.Text = "Kp";
            // 
            // Hunit
            // 
            this.Hunit.AutoSize = true;
            this.Hunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hunit.Location = new System.Drawing.Point(742, 209);
            this.Hunit.Name = "Hunit";
            this.Hunit.Size = new System.Drawing.Size(27, 29);
            this.Hunit.TabIndex = 34;
            this.Hunit.Text = "u";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Humidity.Location = new System.Drawing.Point(691, 208);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(31, 29);
            this.Humidity.TabIndex = 33;
            this.Humidity.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Humidity:";
            // 
            // Aunit
            // 
            this.Aunit.AutoSize = true;
            this.Aunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aunit.Location = new System.Drawing.Point(798, 141);
            this.Aunit.Name = "Aunit";
            this.Aunit.Size = new System.Drawing.Size(27, 29);
            this.Aunit.TabIndex = 37;
            this.Aunit.Text = "u";
            // 
            // Altitude
            // 
            this.Altitude.AutoSize = true;
            this.Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altitude.Location = new System.Drawing.Point(692, 141);
            this.Altitude.Name = "Altitude";
            this.Altitude.Size = new System.Drawing.Size(29, 29);
            this.Altitude.TabIndex = 36;
            this.Altitude.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Altitude:";
            // 
            // Bpunit
            // 
            this.Bpunit.AutoSize = true;
            this.Bpunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bpunit.Location = new System.Drawing.Point(407, 395);
            this.Bpunit.Name = "Bpunit";
            this.Bpunit.Size = new System.Drawing.Size(27, 29);
            this.Bpunit.TabIndex = 39;
            this.Bpunit.Text = "u";
            // 
            // Barp
            // 
            this.Barp.AutoSize = true;
            this.Barp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barp.Location = new System.Drawing.Point(277, 397);
            this.Barp.Name = "Barp";
            this.Barp.Size = new System.Drawing.Size(45, 29);
            this.Barp.TabIndex = 38;
            this.Barp.Text = "Bp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(705, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.20895F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.Color.Teal;
            this.About.Location = new System.Drawing.Point(793, 540);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(85, 24);
            this.About.TabIndex = 41;
            this.About.Text = "@About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 577);
            this.Controls.Add(this.About);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Bpunit);
            this.Controls.Add(this.Barp);
            this.Controls.Add(this.Aunit);
            this.Controls.Add(this.Altitude);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Hunit);
            this.Controls.Add(this.Humidity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kpunit);
            this.Controls.Add(this.KiloP);
            this.Controls.Add(this.Kunit);
            this.Controls.Add(this.Kelvin);
            this.Controls.Add(this.Funit);
            this.Controls.Add(this.Farenheight);
            this.Controls.Add(this.Lunit);
            this.Controls.Add(this.Punit);
            this.Controls.Add(this.Tunit);
            this.Controls.Add(this.Prediction);
            this.Controls.Add(this.Light);
            this.Controls.Add(this.UploadHex);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Temperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Station";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label Pressure;
        public System.Windows.Forms.Label Temperature;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button UploadHex;
        public System.Windows.Forms.Label Prediction;
        public System.Windows.Forms.Label Light;
        public System.Windows.Forms.Label Punit;
        public System.Windows.Forms.Label Tunit;
        public System.Windows.Forms.Label Lunit;
        public System.Windows.Forms.Label Funit;
        public System.Windows.Forms.Label Farenheight;
        public System.Windows.Forms.Label Kunit;
        public System.Windows.Forms.Label Kelvin;
        public System.Windows.Forms.Label Kpunit;
        public System.Windows.Forms.Label KiloP;
        public System.Windows.Forms.Label Hunit;
        public System.Windows.Forms.Label Humidity;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Aunit;
        public System.Windows.Forms.Label Altitude;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label Bpunit;
        public System.Windows.Forms.Label Barp;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label About;
    }
}

