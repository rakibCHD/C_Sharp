using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_Control
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        int pin;
        public Form1()
        {
            InitializeComponent();
            sp = new SerialPort("COM4", 9600);

            try 
            {
                sp.Open();
            }
            catch
            {
                Console.WriteLine("Unable to connect with Arduino!!!");
            }

        }

        private void On_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("1");
            }
        }

        private void Off_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                sp.Write("0");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pin = comboBox1.SelectedIndex + 2;
        }
    }
}
