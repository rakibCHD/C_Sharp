using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Weather_Station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            Temperature.Hide();
            Humidity.Hide();
            Altitude.Hide();
            Pressure.Hide();
            Light.Hide();
            Prediction.Hide();
            Tunit.Hide();
            Punit.Hide();
            Aunit.Hide();
            Hunit.Hide();
            Lunit.Hide();
            Farenheight.Hide();
            Kelvin.Hide();
            Funit.Hide();
            Kunit.Hide();
            KiloP.Hide();
            Kpunit.Hide();
            Barp.Hide();
            Bpunit.Hide();
            pictureBox1.Hide();

            timer1.Interval = 10;
            timer1.Start();
        }
        private void UploadHex_Click(object sender, EventArgs e)
        {
            
            UploadHex.Hide();
            About.Hide();

            DialogResult result = MessageBox.Show("Is your Arduino already connected ?", "Connected??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {

                Form pf = new Port_Form();
                pf.ShowDialog();
            }
            else
            {
                Form2 customMessageBox = new Form2();
                customMessageBox.MessageText = "Disconnect your Arduino.";
                customMessageBox.NextButtonText = "Next";
                customMessageBox.ShowDialog();

                Form pf = new Port_Form();
                pf.ShowDialog();

            }

            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            Temperature.Show();
            Humidity.Show();
            Altitude.Show();
            Pressure.Show();
            Light.Show();
            Prediction.Show();
            Tunit.Show();
            Punit.Show();
            Aunit.Show();
            Hunit.Show();
            Lunit.Show();
            Farenheight.Show();
            Kelvin.Show();
            Funit.Show();
            Kunit.Show();
            KiloP.Show();
            Kpunit.Show();
            Barp.Show();
            Bpunit.Show();
            pictureBox1.Show();
        }


        private void LoadDataFromArduino()
        {
            SerialPort sp = new SerialPort();
            sp.BaudRate = 9600;

            if (Port_Form.portflag == 1)
            {
                sp.PortName =Port_Form.portName;
                sp.Open();

                while (true)
                {
                    string data = sp.ReadLine();

                    if (data.Contains("Temp"))
                    {
                        Temperature.Text = data.Replace("Temp", "");
                        Tunit.Text = "*C";



                        Farenheight.Text = (((extractFloat(Temperature.Text) * 9) / 5) + 32).ToString();
                        Funit.Text = "*F";

                        Kelvin.Text= (extractFloat(Temperature.Text) + 273).ToString();
                        Kunit.Text = "*k";
                    }
                    if (data.Contains("Prsr"))
                    {
                        Pressure.Text = data.Replace("Prsr", "");
                        Punit.Text = "Pa";

                        KiloP.Text = (extractFloat(Pressure.Text) / 1000).ToString();
                        Kpunit.Text = " kPa";

                        Barp.Text = (extractFloat(KiloP.Text) / 100).ToString();
                        Bpunit.Text = "bar";
                    }
                    if (data.Contains("Altd"))
                    {
                        Altitude.Text = data.Replace("Altd", "");
                        Aunit.Text = "m";
                    }
                    if (data.Contains("Hmdt"))
                    {
                        Humidity.Text = data.Replace("Hmdt", "");
                        Hunit.Text = "%";
                    }
                    if (data.Contains("Light"))
                    {
                        Light.Text = data.Replace("Light", "");
                        Lunit.Text = "%";
                    }
                    if (data.Contains("Prdt"))
                    {
                        float prediction = extractFloat(data.Replace("Prdt", ""));

                        if (prediction > 0.25)
                        {
                            Prediction.Text = "Sunny";
                            pictureBox1.Image = Properties.Resources.sunny;
                        }
                        if (prediction <= 0.25)
                        {
                            Prediction.Text = "Cloudy";
                            pictureBox1.Image = Properties.Resources.cloudy;

                        }
                        if (prediction < -0.25)
                        {
                            Prediction.Text = "Rainy";
                            pictureBox1.Image = Properties.Resources.rainy;

                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadDataFromArduino();
        }

        private float extractFloat(string input)
        {
            Regex regex = new Regex(@"\b(\d+)(\.\d+)?\b");

            MatchCollection matches = regex.Matches(input);

            float floatValue=0;

            foreach (Match match in matches)
            {
                string value = match.Value;

                if (value.Contains('.'))
                {
                    if (float.TryParse(value, out floatValue))
                        return floatValue;
                    
                }
            }
            return floatValue;
        }

        public void About_Click(object sender, EventArgs e)
        {
            Form ab = new About();
            ab.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= Form1_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
        }


    }
}
