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

namespace ESP_Control
{
    public partial class Form2 : Form
    {
        public string MessageText { get; set; }
        public string NextButtonText { get; set; }

        private string[] _previousPorts;

        private Timer _timer;

        public Form2()
        {
            InitializeComponent();
            _previousPorts = SerialPort.GetPortNames();
            InitializeTimer();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            messageLabel.Text = MessageText;
            nextButton.Text = NextButtonText;
            Removed.Hide();
            Click.Hide();
            Arrow.Hide();
            nextButton.Hide();
            Stay.Hide();
        }
        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CheckDisconnectedPorts();
        }

        private void CheckDisconnectedPorts()
        {
            string[] currentPorts = SerialPort.GetPortNames();
            string[] disconnectedPorts = _previousPorts.Except(currentPorts).ToArray();

            if (disconnectedPorts.Length > 0)
            {
                Removed.Show();
                Stay.Show();
                Click.Show();
                Arrow.Show();
                nextButton.BackColor = Color.SeaGreen;
                nextButton.Show();
            }

            _previousPorts = currentPorts;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gvar.isForm2Closed = true;
        }

    }
}
