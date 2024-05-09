using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_Control
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
    }
}
