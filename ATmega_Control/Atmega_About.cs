using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Arduino_Control
{
    public partial class Atmega_About : Form
    {
        public Atmega_About()
        {
            InitializeComponent();
        }

        private void ArduinoUno_About_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Atmega;
        }

        private void Linkedin_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/rakibchd/");
        }
        private void Facebook_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/rakib.chd");
        }
    }
}
