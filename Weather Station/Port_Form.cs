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

namespace Weather_Station
{
    public partial class Port_Form : Form
    {
        public static string portName;
        public static int portflag = 0;
        int browseflag = 0;

        public Port_Form()
        {
            InitializeComponent();
        }

        private void Port_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Browse_Exe;
            label5.Text = " ";
            arrow.Hide();
            Flash.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FindPort();
        }

        private void FindPort()
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
                Flash.Show();
            }
             
        }

        private string WaitForNewPort(string[] previousPorts, TimeSpan timeout)
        {
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

        private void Browse_Exe_Click(object sender, EventArgs e)
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
                    browseflag = 0;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_Config;
                    ExePath_tb.Text = openFileDialog1.FileName;
                    Gvar.ExePath = openFileDialog1.FileName;
                    browseflag = 1;
                }
            }

        }

        private void Browse_Config_Click(object sender, EventArgs e)
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
                    browseflag = 0;
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_hex;
                    ConfigPath_tb.Text = openFileDialog2.FileName;
                    Gvar.ConfigPath = openFileDialog2.FileName;
                    browseflag = 1;
                }
            }
        }

        private void Browse_hex_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                errorProvider1.SetError(HexPath_tb, string.Empty);

                if (openFileDialog3.FileName.Contains("Weather_Station_G-5.ino.standard.hex"))
                {
                    button1.Enabled = true;
                    this.ActiveControl = button1;
                    HexPath_tb.Text = openFileDialog3.FileName;
                    browseflag = 1;
                }
                else
                {
                    errorProvider1.SetError(HexPath_tb, "Please select a valid file.");
                    HexPath_tb.Text = string.Empty;
                    this.ActiveControl = Browse_hex;
                    button1.Enabled = false;
                    browseflag = 0;
                }

            }
        }

        private void Flash_Click(object sender, EventArgs e)
        {
            if (browseflag == 1)
            {
                string ExePath = @Gvar.ExePath;
                string configPath = @Gvar.ConfigPath;
                string programmer = "arduino";
                string targetChip = "m328p";

                int baudRate = 115200;
                string hexFilePath = @openFileDialog3.FileName;


                string arguments = $"-C \"{configPath}\" -c {programmer} -p {targetChip} -P {portName} -b {baudRate} -U flash:w:\"{hexFilePath}\":a";

                MessageBox.Show("Flashing process will Start.");

                Process process = Process.Start(ExePath, arguments);
                process.WaitForExit();

                MessageBox.Show("Flashing successful.");

                portflag = 1;

                this.Hide();
            }
            else
                MessageBox.Show("Browse necessary files First.");
        }

    }
}
