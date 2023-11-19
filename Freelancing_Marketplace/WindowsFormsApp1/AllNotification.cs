using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AllNotification : Form
    {

        public AllNotification()
        {
            InitializeComponent();
        }

        private void AllNotification_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Notification.getAllNotification(Freelancer.freelancer_id).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
