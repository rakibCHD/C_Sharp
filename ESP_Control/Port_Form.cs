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

namespace ESP_Control
{
    public partial class Port_Form : Form
    {
        public static string portName;

        bool isBrowseExe = false;
        public static bool isBrowseBin = false;
        int Pflag = 0;
        int Hflag = 0;

        public Port_Form()
        {
            InitializeComponent();

        }
        private void Port_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Browse_Exe;
            Gvar.count++;
            label5.Text = " ";
            arrow.Hide();
            flash.Hide();
            LeftArrow.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             FindPort();
        }

        private void FindPort()
        {
           
            if (isAnyBrowse())
            {
                if (isAllBrowse())
                {
                    string[] previousPorts = SerialPort.GetPortNames();

                    string previousPortsString = string.Join(", ", previousPorts);

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

                if (!isBrowseBin)
                    MessageBox.Show("Browse .bin file.");
            }
            else
                MessageBox.Show("Browse the necessary files.");

        }


        private string WaitForNewPort(string[] previousPorts, TimeSpan timeout)
        {
            SystemSounds.Asterisk.Play();
            MessageBox.Show("You have 30 Second to connect your ESP after press 'ok'.");

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
                }
                else
                {
                    button1.Enabled = true;
                    this.ActiveControl = Browse_Bin;
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


        private void Browse_Bin_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                errorProvider1.SetError(BinPath_tb, string.Empty);

                if (!Gvar.isDhexUploaded)
                {
                    if (openFileDialog2.FileName.Contains("ESP_With_C_Sharp.ino.nodemcu.bin"))
                    {
                        button1.Enabled = true;
                        this.ActiveControl = button1;
                        BinPath_tb.Text = openFileDialog2.FileName;
                        isBrowseBin = true;
                        Hflag = 1;
                    }
                    else
                    {
                        errorProvider1.SetError(BinPath_tb, "Please select a valid file.");
                        BinPath_tb.Text = string.Empty;
                        this.ActiveControl = Browse_Bin;
                        button1.Enabled = false;
                    }
                    if (isAllBrowse())
                    {
                        LeftArrow.Show();
                        this.ActiveControl = button1;
                    }
                }
                else
                {
                    if (openFileDialog2.FileName.Contains(".bin") && !openFileDialog2.FileName.Contains("ESP_With_C_Sharp.ino.nodemcu.bin"))
                    {
                        this.ActiveControl = button1;
                        BinPath_tb.Text = openFileDialog2.FileName;
                        Gvar.isNewHexUpload = true;

                    }
                    else if (openFileDialog2.FileName.Contains("ESP_With_C_Sharp.ino.nodemcu.bin"))
                    {
                        this.ActiveControl = button1;
                        BinPath_tb.Text = openFileDialog2.FileName;
                        Gvar.isNewHexUpload = false;
                    }
                    else
                    {
                        errorProvider1.SetError(BinPath_tb, "Please select a valid file.");
                        BinPath_tb.Text = string.Empty;
                        Gvar.isNewHexUpload = false;
                    }
                }
            }
        }

        private bool isAllBrowse()
        {
            if (Pflag == 1 && Hflag == 1)
                return true;
            else
                return false;
        }

        private bool isAnyBrowse()
        {
            if (Pflag == 1 || Hflag == 1)
                return true;
            else
                return false;
        }

        private void flash_Click(object sender, EventArgs e)
        {
            if (BinPath_tb.Text != string.Empty)
            {
                string ExePath = @Gvar.ExePath;
                string BinFilePath = @openFileDialog2.FileName;


                string flashMode = "dio";
                string flashAddress = "0x00000";

                string arguments = $"--port {portName} write_flash -fm {flashMode} {flashAddress} \"{BinFilePath}\"";



                MessageBox.Show("Flashing process will Start.");

                Process process = Process.Start(ExePath, arguments);
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
                MessageBox.Show("Browse a Bin file first");
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}