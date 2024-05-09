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
    public partial class ArduinoUno_About : Form
    {
        public ArduinoUno_About()
        {
            InitializeComponent();
        }

        private void ArduinoUno_About_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.Arduino_Uno;

        }
    }
}
