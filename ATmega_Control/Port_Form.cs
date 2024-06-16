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
using System.Media;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;

namespace Arduino_Control
{
    public partial class Port_Form : Form
    {
        public static string portName;

        bool isBrowseExe = false;
        bool isBrowseConfig = false;
        public static bool isBrowseHex = false;
        int Pflag = 0;
        int Cflag = 0;
        int Hflag = 0;
        int ChipFlag = 0;
        string targetChip;


        public Port_Form()
        {
            InitializeComponent();

        }
        private void Port_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Browse_Exe;
            loadChip();
            Gvar.count++;
            label5.Text = " ";
            arrow.Hide();
            flash.Hide();
            LeftArrow.Hide();
        }

        private void loadChip()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("ATmega328");
            comboBox1.Items.Add("ATmega8");

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChipFlag = 1;
            Gvar.ChipName = comboBox1.Text.ToString();

            errorProvider1.SetError(HexPath_tb, string.Empty);

            if (comboBox1.Text == "ATmega8")
            {
                targetChip = "m8";
                if (Hflag == 1)
                {
                    if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega8_16000000L.hex"))
                    {
                        button1.Enabled = true;
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                    }
                    else
                    {
                        errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                        HexPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_hex;
                        button1.Enabled = false;
                        LeftArrow.Hide();
                    }
                }

            }
            if (comboBox1.Text == "ATmega328")
            {
                targetChip = "m328p";
                if (Hflag == 1)
                {
                    if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega328p_16000000L.hex"))
                    {
                        button1.Enabled = true;
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                    }
                    else
                    {
                        errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                        HexPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_hex;
                        button1.Enabled = false;
                        LeftArrow.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindPort();
        }

        private void FindPort()
        {
            if (ChipFlag == 1)
            {
                if (isAnyBrowse())
                {
                    if (isAllBrowse())
                    {
                        string[] previousPorts = SerialPort.GetPortNames();

                        string newPort = WaitForNewPort(previousPorts, TimeSpan.FromSeconds(30));


                        if (newPort == null)
                        {
                            DialogResult result = MessageBox.Show("No new port detected within 30 Second!", "Timeout", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                MessageBox.Show("Operation canceled.");
                                this.Hide();
                            }
                        }
                        else
                        {
                            portName = newPort.Trim();

                            label5.Text += "Port- " + newPort + " is connected and ready to flash.";
                            arrow.Show();
                            flash.Show();
                        }
                    }
                    if (!isBrowseExe)
                        MessageBox.Show("Browse Programmer.exe file.");
                    if (!isBrowseConfig)
                        MessageBox.Show("Browse ChipConfig.conf file.");
                    if (!isBrowseHex)
                        MessageBox.Show("Browse .Hex file.");
                }
                else
                    MessageBox.Show("Browse the necessary files.");
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Select a Chip First.");
            }
        }


        private string WaitForNewPort(string[] previousPorts, TimeSpan timeout)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You have 30 Second to connect your "+Gvar.ChipName+" Board after press 'ok'.");

            DateTime startTime = DateTime.Now;

            while (DateTime.Now - startTime < timeout)
            {
                string[] currentPorts = SerialPort.GetPortNames();

                foreach (string port in currentPorts)
                {
                    if (!Array.Exists(previousPorts, element => element == port))
                    {
                        return port;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }

            return null;
        }

        private void Browse_Exe_Click(object sender, EventArgs e)
        {
            if (ChipFlag == 1)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    errorProvider1.SetError(ExePath_tb, string.Empty);

                    if (!openFileDialog1.FileName.Contains("Programmer.exe"))
                    {
                        errorProvider1.SetError(ExePath_tb, "Please select a valid file.");
                        ExePath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_Exe;
                        button1.Enabled = false;
                        Pflag = 0;
                    }
                    else
                    {
                        button1.Enabled = true;
                        this.ActiveControl = Browse_Config;
                        ExePath_tb.Text = openFileDialog1.FileName;
                        Gvar.ExePath = openFileDialog1.FileName;
                        isBrowseExe = true;
                        Pflag = 1;
                    }
                    if (isAllBrowse())
                    {
                        LeftArrow.Show();
                        this.ActiveControl = button1;
                    }
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Select a Chip First.");
            }
        }

        private void Browse_Config_Click(object sender, EventArgs e)
        {
            if (ChipFlag == 1)
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {

                    errorProvider1.SetError(ConfigPath_tb, string.Empty);

                    if (!openFileDialog2.FileName.Contains("ChipConfig.conf"))
                    {
                        errorProvider1.SetError(ConfigPath_tb, "Please select a valid file.");
                        ConfigPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_Config;
                        button1.Enabled = false;
                        Cflag = 0;
                    }
                    else
                    {
                        button1.Enabled = true;
                        this.ActiveControl = Browse_hex;
                        ConfigPath_tb.Text = openFileDialog2.FileName;
                        Gvar.ConfigPath = openFileDialog2.FileName;
                        isBrowseConfig = true;
                        Cflag = 1;
                    }
                    if (isAllBrowse())
                    {
                        LeftArrow.Show();
                        this.ActiveControl = button1;
                    }
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Select a Chip First.");
            }
        }

        private void Browse_hex_Click(object sender, EventArgs e)
        {
            if (ChipFlag == 1)
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    errorProvider1.SetError(HexPath_tb, string.Empty);

                    if (Gvar.ChipName == "ATmega8")
                    {
                        if (!Gvar.isDhexUploaded)
                        {
                            if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega8_16000000L.hex"))
                            {
                                button1.Enabled = true;
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                isBrowseHex = true;
                                Hflag = 1;
                            }
                            else
                            {
                                errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                                HexPath_tb.Text = string.Empty;
                                this.ActiveControl = Browse_hex;
                                button1.Enabled = false;
                                Hflag = 0;
                            }
                            if (isAllBrowse())
                            {
                                LeftArrow.Show();
                                this.ActiveControl = button1;
                            }
                        }
                        else
                        {
                            if (openFileDialog3.FileName.Contains(".hex") && !openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega8_16000000L.hex"))
                            {
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                Gvar.isNewHexUpload = true;

                            }
                            else if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega8_16000000L.hex"))
                            {
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                Gvar.isNewHexUpload = false;
                            }
                            else
                            {
                                errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                                HexPath_tb.Text = string.Empty;
                                Gvar.isNewHexUpload = false;
                            }
                        }
                    }
                    if(Gvar.ChipName=="ATmega328")
                    {
                        if (!Gvar.isDhexUploaded)
                        {
                            if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega328p_16000000L.hex"))
                            {
                                button1.Enabled = true;
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                isBrowseHex = true;
                                Hflag = 1;
                            }
                            else
                            {
                                errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                                HexPath_tb.Text = string.Empty;
                                this.ActiveControl = Browse_hex;
                                button1.Enabled = false;
                                Hflag = 0;
                            }
                            if (isAllBrowse())
                            {
                                LeftArrow.Show();
                                this.ActiveControl = button1;
                            }
                        }
                        else
                        {
                            if (openFileDialog3.FileName.Contains(".hex") && !openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega328p_16000000L.hex"))
                            {
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                Gvar.isNewHexUpload = true;

                            }
                            else if (openFileDialog3.FileName.Contains("ATmega_With_C_Sharp.ino_atmega328p_16000000L.hex"))
                            {
                                this.ActiveControl = button1;
                                HexPath_tb.Text = openFileDialog3.FileName;
                                Gvar.isNewHexUpload = false;
                            }
                            else
                            {
                                errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                                HexPath_tb.Text = string.Empty;
                                Gvar.isNewHexUpload = false;
                            }
                        }
                    }
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Select a Chip First.");
            }
        }

        private bool isAllBrowse()
        {
            if (Pflag == 1 && Cflag == 1 && Hflag == 1)
                return true;
            else
                return false;
        }

        private bool isAnyBrowse()
        {
            if (Pflag == 1 || Cflag == 1 || Hflag == 1)
                return true;
            else
                return false;
        }

        private void flash_Click(object sender, EventArgs e)
        {
            if (HexPath_tb.Text != string.Empty)
            {
                string ExePath = @Gvar.ExePath;
                string configPath = @Gvar.ConfigPath;
                string programmer = "arduino";

                int baudRate = 115200;
                string hexFilePath = @openFileDialog3.FileName;


                string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                MessageBox.Show("Flashing process will Start.");

                Process process = Process.Start(ExePath, arguments);
                process.WaitForExit();

                MessageBox.Show("Flashing successful.");

                AVR_ATMEGA.isUploadHex = true;
                AVR_ATMEGA.portFlag = 1;

                this.Hide();

                if (!Gvar.isNewHexUpload)
                {
                    Gvar.isDhexUploaded = true;
                    AVR_ATMEGA.isNewHexUpload = false;
                }
                else
                    AVR_ATMEGA.isNewHexUpload = true;
            }
            else
                MessageBox.Show("Browse a hex file first");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
