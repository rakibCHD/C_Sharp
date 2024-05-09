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

        bool isBrowseAvrExe = false;
        bool isBrowseAvrConfig = false;
        public static bool isBrowseHex = false;
        int browseflag = 0;

        public Port_Form()
        {
            InitializeComponent();

        }
        private void Port_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Browse_avrdude;
            Gvar.count++;
            label5.Text = " ";
            arrow.Hide();
            flash.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindPort();
        }

        private void FindPort()
        {
            if (browseflag == 1)
            {
                if (isBrowseAvrExe && isBrowseAvrConfig && isBrowseHex)
                {
                    string[] previousPorts = SerialPort.GetPortNames();

                    string previousPortsString = string.Join(", ", previousPorts);

                    string newPort = WaitForNewPort(previousPorts, TimeSpan.FromSeconds(30));


                    if (newPort == null)
                    {
                        DialogResult result = MessageBox.Show("No new port detected within 30 Second. Do you want to reconnect?", "Timeout", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                            FindPort();
                        else
                            MessageBox.Show("Operation canceled.");
                    }
                    else
                    {
                        portName = newPort.Trim();

                        label5.Text += "Port- " + newPort + " is connected and ready to flash.";
                        arrow.Show();
                        flash.Show();
                    }
                }
                if (!isBrowseAvrExe)
                    MessageBox.Show("Browse AvrDude.exe file.");
                if (!isBrowseAvrConfig)
                    MessageBox.Show("Browse AvrDude.conf file.");
                if (!isBrowseHex)
                    MessageBox.Show("Browse Hex file.");
            }
            else
                MessageBox.Show("Browse the necessary files.");

        }


        private string WaitForNewPort(string[] previousPorts, TimeSpan timeout)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You have 30 Second to connect your Arduino after press 'ok'.");

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

        private void Browse_avrdude_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                errorProvider1.SetError(AvrdudePath_tb, string.Empty);

                if (!openFileDialog1.FileName.Contains("Programmer.exe"))
                {
                    errorProvider1.SetError(AvrdudePath_tb, "Please select a valid file.");
                    AvrdudePath_tb.Text = string.Empty;
                    this.ActiveControl = Browse_avrdude;
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_avrconfig;
                    AvrdudePath_tb.Text = openFileDialog1.FileName;
                    Gvar.AvrdudeExePath = openFileDialog1.FileName;
                    isBrowseAvrExe = true;
                    browseflag = 1;
                }
            }
        }

        private void Browse_avrconfig_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {

                errorProvider1.SetError(AvrConfigPath_tb, string.Empty);

                if (!openFileDialog2.FileName.Contains("ChipConfig.conf"))
                {
                    errorProvider1.SetError(AvrConfigPath_tb, "Please select a valid file.");
                    AvrConfigPath_tb.Text = string.Empty;
                    this.ActiveControl = Browse_avrconfig;

                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_hex;
                    AvrConfigPath_tb.Text = openFileDialog2.FileName;
                    Gvar.AvrConfigPath = openFileDialog2.FileName;

                    isBrowseAvrConfig = true;
                    browseflag = 1;
                }
            }
        }

        private void Browse_hex_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                errorProvider1.SetError(HexPath_tb, string.Empty);

                if (!Gvar.isDhexUploaded)
                {
                    if (openFileDialog3.FileName.Contains("Arduino_With_C_Sharp.ino.standard.hex"))
                    {
                        button1.Enabled = true;
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                        isBrowseHex = true;
                        browseflag = 1;
                    }
                    else
                    {
                        errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                        HexPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_hex;
                        button1.Enabled = false;
                    }
                }
                else
                {
                    if (openFileDialog3.FileName.Contains(".hex") && !openFileDialog3.FileName.Contains("Arduino_With_C_Sharp.ino.standard.hex"))
                    {
                        this.ActiveControl = button1;
                        HexPath_tb.Text = openFileDialog3.FileName;
                        Gvar.isNewHexUpload = true;

                    }
                    else if(openFileDialog3.FileName.Contains("Arduino_With_C_Sharp.ino.standard.hex"))
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

        private void flash_Click_1(object sender, EventArgs e)
        {
            if (HexPath_tb.Text != string.Empty)
            {
                string avrdudePath = @Gvar.AvrdudeExePath;
                string configPath = @Gvar.AvrConfigPath;
                string programmer = "arduino";
                string targetChip = "m328p";

                int baudRate = 115200;
                string hexFilePath = @openFileDialog3.FileName;


                string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                MessageBox.Show("Flashing process will Start.");

                Process process = Process.Start(avrdudePath, arguments);
                process.WaitForExit();

                MessageBox.Show("Flashing successful.");

                Form1.isUploadHex = true;
                Form1.portFlag = 1;

                this.Hide();

                if (!Gvar.isNewHexUpload)
                {
                    Gvar.isDhexUploaded = true;
                    Form1.isNewHexUpload = false;
                }
                else
                    Form1.isNewHexUpload = true;
            }
            else
                MessageBox.Show("Browse a hex file first");
        }

            

        
    }
}
