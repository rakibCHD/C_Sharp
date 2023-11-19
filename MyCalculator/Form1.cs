using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        public double num1;

        public double num2;

        public double result;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            label4.Text = "-----";
            sign.Text = "";
        }

        public bool IsValid()
        {
            double value;

            if (textBox1.Text == string.Empty || !double.TryParse(textBox1.Text, out value))
            {
                return false;
            }
            else if (textBox2.Text == string.Empty || !double.TryParse(textBox2.Text, out value))
            {
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                result = num1 + num2;
                label4.Text = "-----";
                sign.Text = "+";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 - num2;
                label4.Text = "-----";
                sign.Text = "-";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 * num2;
                label4.Text = "-----";
                sign.Text = "x";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                num1 = double.Parse(textBox1.Text);
                num2 = double.Parse(textBox2.Text);
                result = num1 / num2;
                label4.Text = "-----";
                sign.Text = "/";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label4.Enabled = true;
            label4.Text = result.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            result = 0;
            textBox1.Clear();
            textBox2.Clear();

            label4.Text = "-----";
            sign.Text = "";
            textBox1.Focus();
            errorProvider1.Clear();
            errorProvider2.Clear();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double value;
            sign.Text = "";

            errorProvider1.SetError(textBox1, string.Empty);

            if (textBox1.Text == string.Empty || !double.TryParse(textBox1.Text, out value))
            {
                errorProvider1.SetError(textBox1, "Valid number required!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double value;
            sign.Text = "";

            errorProvider2.SetError(textBox2, string.Empty);

            if (textBox2.Text == string.Empty || !double.TryParse(textBox2.Text, out value))
            {
                errorProvider2.SetError(textBox2, "Valid number required!!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if(label4.Text!="-----")
            { 
                textBox1.Text = Convert.ToString(result);

                textBox2.Clear();
                textBox2.Focus();
                errorProvider2.Clear();
                sign.Text="";

            }
         
        }
    }
}
