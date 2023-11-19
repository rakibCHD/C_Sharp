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
    public partial class Financials : Form
    {
        
        public Financials()
        {              
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Financials_Load(object sender, EventArgs e)
        {          
            label2.Text = Convert.ToString(Math.Round(Freelancer.financials, 2)) + " $";
            listBox1.DataSource = Notification.getFinancialHistory(Freelancer.freelancer_id).ToList();           
        }
    }
}
