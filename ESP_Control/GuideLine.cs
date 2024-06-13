using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESP_Control
{
    public partial class GuideLine : Form
    {
        public GuideLine()
        {
            InitializeComponent();
        }
        private void GuideLine_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.GuideLine;
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
