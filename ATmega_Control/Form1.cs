using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Media;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace Arduino_Control
{
    public partial class AVR_ATMEGA : Form
    {

        SerialPort sp = new SerialPort();
        public static bool isNewHexUpload = false;
        int pinFlag = 0;
        int blinkFlag = 0;
        public static int portFlag = 0;
        public static bool isUploadHex = false;
        public bool isPortDisConected = false;
        public int blinking_value = 0;

        private System.Windows.Forms.Timer valueDetectionTimer;

        public AVR_ATMEGA()
        {
            InitializeComponent();
            valueDetectionTimer = new System.Windows.Forms.Timer();
            valueDetectionTimer.Interval = 10;
            valueDetectionTimer.Tick += ValueDetectionTimer_Tick;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = AtmegaAbout;
            loadPinList();

            ms.Hide();
            textBox1.Hide();
            hexLabel.Text = "";
            Pin_Label.Text = "";
            ChipL.Hide();
            Chipname.Text= "";
            label2.Hide();
            label4.Hide();
            comboBox1.Hide();
            Port.Text = "";
            Reconnect.Hide();
            disconnect.Hide();
            ledStatus.Hide();
            valueDetectionTimer.Start();
        }

        private void ValueDetectionTimer_Tick(object sender, EventArgs e)
        {
            if (Gvar.count > 1 && Gvar.isDhexUploaded)
            {
                if (isNewHexUpload)
                {
                    hexLabel.Text = "        A Hex file is Uploaded via " + Port_Form.portName;
                    UploadHex.BackColor = Color.LightGray;

                }
                else
                {
                    hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port_Form.portName;
                    UploadHex.BackColor = Color.SeaGreen;

                }
            }
        }

        private void loadPinList()
        {
            string[] pin = new string[12];
            for (int i = 2; i <= 13; i++)
                pin[i - 2] = i.ToString();

            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(pin);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sp = new SerialPort(Port_Form.portName.Trim(), 9600);
            if (sp.IsOpen)
            {
                pinFlag = 1;
                sp.Write("p" + comboBox1.Text.ToString());
                Pin_Label.Show();
                Pin_Label.Text = "Digital Output Pin : " + comboBox1.Text;
                On.BackColor = Color.LightGray;
                Off.BackColor = Color.LightGray;
                ledStatus.Text = "";
                sp.Close();
            }
            else
            {
                sp.Open();
                pinFlag = 1;
                sp.Write("p" + comboBox1.Text.ToString());
                Pin_Label.Show();
                Pin_Label.Text = "Digital Output Pin : " + comboBox1.Text;
                On.BackColor = Color.LightGray;
                Off.BackColor = Color.LightGray;
                ledStatus.Text = "";
            }
        }

        private void UploadHex_Click(object sender, EventArgs e)
        {
            if (portFlag == 0)
            {
                SystemSounds.Asterisk.Play();

                DialogResult result = MessageBox.Show("Is your ATmega Board already connected ?", "Connected??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {

                    Form pf = new Port_Form();
                    pf.ShowDialog();

                    if (Gvar.isDhexUploaded)
                    {
                        ChipL.Show();
                        Chipname.Text= Gvar.ChipName;
                        Port.Text = Port_Form.portName;
                        hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port.Text;
                        UploadHex.BackColor = Color.SeaGreen;
                        Reconnect.Show();
                        disconnect.Show();
                        label4.Show();
                        comboBox1.Show();
                        label2.Show();
                        ms.Show();
                        textBox1.Show();
                        Pin_Label.Text = string.Empty;
                        ledStatus.Text = "";
                        On.BackColor = Color.LightGray;
                        Off.BackColor = Color.LightGray;
                        BlinkOn.BackColor = Color.LightGray;
                        BlinkOff.BackColor = Color.LightGray;

                    }
                }
                else
                {
                    Form2 customMessageBox = new Form2();
                    customMessageBox.MessageText = "Disconnect your Arduino.";
                    customMessageBox.NextButtonText = "Next";
                    customMessageBox.ShowDialog();

                    if (!Gvar.isForm2Closed)
                    {
                        Form pf = new Port_Form();
                        pf.ShowDialog();
                        if (Gvar.isDhexUploaded)
                        {
                            ChipL.Show();
                            Chipname.Text = Gvar.ChipName;
                            Port.Text = Port_Form.portName;
                            hexLabel.Text = "Dedicated Hex file is Uploaded via " + Port.Text;
                            UploadHex.BackColor = Color.SeaGreen;
                            Reconnect.Show();
                            disconnect.Show();
                            label4.Show();
                            comboBox1.Show();
                            label2.Show();
                            ms.Show();
                            textBox1.Show();
                            Pin_Label.Text = string.Empty;
                            ledStatus.Text = "";
                            On.BackColor = Color.LightGray;
                            Off.BackColor = Color.LightGray;
                            BlinkOn.BackColor = Color.LightGray;
                            BlinkOff.BackColor = Color.LightGray;
                        }
                    }

                }

            }
            else
            {
                DialogResult result = MessageBox.Show("A hex file is already Uploaded. Do you want to upload another Hex file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Port_Form pf = new Port_Form();
                    pf.Show();

                    if (Gvar.count > 1)
                    {
                        pf.label1.Text = "      Upload Any hex file for Arduino";
                        pf.Chip.Hide();
                        pf.comboBox1.Hide();
                        pf.button1.Hide();
                        pf.Browse_Exe.Hide();
                        pf.Browse_Config.Hide();
                        pf.label2.Hide();
                        pf.label3.Hide();
                        pf.ExePath_tb.Hide();
                        pf.ConfigPath_tb.Hide();

                        pf.Browse_hex.Location = new Point(220, 100);
                        pf.label4.Location = new Point(280, 103);
                        pf.HexPath_tb.Location = new Point(100, 140);

                        pf.label5.Text += " " + Port_Form.portName + " is connected and ready to flash. ";
                        pf.arrow.Show();
                        pf.flash.Show();
                    }

                    Pin_Label.Text = string.Empty;
                    ledStatus.Text = "";
                    On.BackColor = Color.LightGray;
                    Off.BackColor = Color.LightGray;
                    BlinkOn.BackColor = Color.LightGray;
                    BlinkOff.BackColor = Color.LightGray;
                }
                pinFlag = 0;
                comboBox1.Text = string.Empty;
                ledStatus.Hide();
                Pin_Label.Hide();
                On.BackColor = Color.LightGray;
                Off.BackColor = Color.LightGray;
                this.ActiveControl = AtmegaAbout;
            }
        }

        private void On_Click(object sender, EventArgs e)
        {
            if (Gvar.isDhexUploaded && !Gvar.isNewHexUpload)
            {
                if (isPortDisConected == false)
                {
                    if (pinFlag == 1)
                    {
                        if (blinkFlag == 0)
                        {
                            if (sp.IsOpen)
                            {
                                sp.Write("1");
                                On.BackColor = Color.SeaGreen;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Show();
                                ledStatus.Text = "Led is ON.";
                                sp.Close();
                            }
                            else
                            {
                                sp.Open();
                                sp.Write("1");
                                On.BackColor = Color.SeaGreen;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Show();
                                ledStatus.Text = "Led is ON.";
                                sp.Close();
                            }
                        }
                        else
                        {
                            this.ActiveControl = BlinkOff;
                            MessageBox.Show("Make Sure led Blinking is off.");
                        }
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();

                        MessageBox.Show("Select a pin first!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Reconnect the Port.");
            }
            else
            {
                this.ActiveControl = UploadHex;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Upload dedicated Hex File first.");
            }
        }

        private void Off_Click(object sender, EventArgs e)
        {
            if (Gvar.isDhexUploaded && !Gvar.isNewHexUpload)
            {
                if (isPortDisConected == false)
                {
                    if (pinFlag == 1)
                    {
                        if (blinkFlag == 0)
                        {
                            if (sp.IsOpen)
                            {
                                sp.Write("0");
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.IndianRed;
                                ledStatus.Show();
                                ledStatus.Text = "Led is OFF.";
                                sp.Close();
                            }
                            else
                            {
                                sp.Open();
                                sp.Write("0");
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.IndianRed;
                                ledStatus.Show();
                                ledStatus.Text = "Led is OFF.";
                                sp.Close();
                            }
                        }
                        else
                        {
                            this.ActiveControl = BlinkOff;
                            MessageBox.Show("Make Sure led Blinking is off.");
                        }

                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();

                        MessageBox.Show("Select a pin first!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Reconnect the Port.");
            }
            else
            {
                this.ActiveControl = UploadHex;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Upload dedicated Hex File first.");
            }
        }

        private void BlinkOn_Click(object sender, EventArgs e)
        {
            if (Gvar.isDhexUploaded && !Gvar.isNewHexUpload)
            {
                if (isPortDisConected == false)
                {
                    if (pinFlag == 1)
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            if (sp.IsOpen)
                            {
                                sp.Write("b" + int.Parse(textBox1.Text));
                                BlinkOn.BackColor = Color.SeaGreen;
                                BlinkOff.BackColor = Color.LightGray;
                                ledStatus.Show();
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Text = "Led is Blinking.";
                                sp.Close();
                            }
                            else
                            {
                                sp.Open();
                                sp.Write("b" + int.Parse(textBox1.Text));
                                BlinkOn.BackColor = Color.SeaGreen;
                                BlinkOff.BackColor = Color.LightGray;
                                ledStatus.Show();
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Text = "Led is Blinking.";
                                sp.Close();
                            }
                            blinkFlag = 1;
                        }
                        else
                            MessageBox.Show("Provide blinking value.");
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Select a pin first!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Reconnect the Port.");
            }
            else
            {
                this.ActiveControl = UploadHex;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Upload dedicated Hex File first.");
            }
        }

        private void BlinkOff_Click(object sender, EventArgs e)
        {
            if (Gvar.isDhexUploaded && !Gvar.isNewHexUpload)
            {
                if (isPortDisConected == false)
                {
                    if (pinFlag == 1)
                    {
                        if (blinkFlag == 1)
                        {
                            if (sp.IsOpen)
                            {
                                sp.Write("o");
                                BlinkOn.BackColor = Color.LightGray;
                                BlinkOff.BackColor = Color.IndianRed;
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Text = "Blinking is Off.";
                                sp.Close();
                            }
                            else
                            {
                                sp.Open();
                                sp.Write("o");
                                BlinkOn.BackColor = Color.LightGray;
                                BlinkOff.BackColor = Color.IndianRed;
                                On.BackColor = Color.LightGray;
                                Off.BackColor = Color.LightGray;
                                ledStatus.Text = "Blinking is Off.";
                                sp.Close();
                            }
                            blinkFlag = 0;
                        }
                        else
                            MessageBox.Show("Led is not Blinking!!");
                    }
                    else
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Select a pin first!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                    MessageBox.Show("Reconnect the Port.");
            }
            else
            {
                this.ActiveControl = UploadHex;
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Upload dedicated Hex File first.");
            }

        }


        private void Reconnect_Click(object sender, EventArgs e)
        {
            isPortDisConected = false;
            MessageBox.Show("Reconnected port " + Port_Form.portName + " sucessfully");
            label2.Text = "Connected port";
            Reconnect.BackColor = Color.SeaGreen;
            disconnect.BackColor = Color.LightGray;
        }

        private void disconnect_Click(object sender, EventArgs e)
        {
            isPortDisConected = true;
            MessageBox.Show("Disconnected port " + Port_Form.portName + " sucessfully");
            label2.Text = "Disconnected port";
            disconnect.BackColor = Color.IndianRed;
            Reconnect.BackColor = Color.LightGray;

        }

        private void AtmegaAbout_Click(object sender, EventArgs e)
        {
            Atmega_About form = new Atmega_About();
            form.ShowDialog();
        }

        private void Guideline_Label_Click(object sender, EventArgs e)
        {
            GuideLine form = new GuideLine();
            form.ShowDialog();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[^0-9]";

            errorProvider1.SetError(textBox1, string.Empty);

            if (textBox1.Text != string.Empty && !Regex.IsMatch(textBox1.Text, pattern))
            {
                blinking_value = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                errorProvider1.SetError(textBox1, "Please provide integer Value.");
                textBox1.Text = string.Empty;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemSounds.Asterisk.Play();
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
