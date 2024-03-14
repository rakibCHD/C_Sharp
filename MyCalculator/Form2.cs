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
    public partial class Form2 : Form
    {
        public double result;

        public double value;
        public int flag = 0;



        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DegreeSet();
            label8.Hide();
            label10.Text = "-----";  
        }


        public bool IsValid()
        {
            double value;

            if (textBox1.Text == string.Empty || !double.TryParse(textBox1.Text, out value))
                return false;

            else
                return true;
        }


        private void label11_Click(object sender, EventArgs e)
        {
            label8.Hide();
            textBox1.Clear();
            label10.Text = "-----";
            errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                label10.Text = Convert.ToString(result);
            else
            {
                label10.Text = "Ꝏ";
                flag = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double value;
            
            errorProvider1.SetError(textBox1, string.Empty);

            if (!double.TryParse(textBox1.Text, out value))
            {
                errorProvider1.SetError(textBox1, "Valid number required!!");
            }
             DegreeSet();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Calculator form = new Calculator();
            this.Hide();
            form.Show();  
        }

        public void DegreeSet()
        {
            if (textBox1.Text != string.Empty)
                value = Convert.ToDouble(textBox1.Text) * (Math.PI / 180);
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int mul = 0;

            for (int i = 1; i < 100; i++)
            {
                if (Convert.ToDouble(textBox1.Text) == i * 90)
                {
                    mul = i;
                    break;

                }
            }

            if (IsValid())
            {
                result = Math.Sin(value);
                label8.Text = "sin(" + textBox1.Text + ")";
                label8.Show();

            }

            if (mul!=0 && mul % 2 == 0)
            {
                result = 0;
                label8.Text = "sin(" + textBox1.Text + ")";
                label8.Show();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int mul = 0;

            for (int i = 1; i<100; i++) 
            {
                if (Convert.ToDouble(textBox1.Text) == i * 90)
                {
                    mul = i;
                
                    break;
                    
                }
            }

            if (IsValid())
            {
                result = Math.Cos(value);
                label8.Text = "cos(" + textBox1.Text + ")";
                label8.Show();

            }

            if ( mul % 2 != 0)
            {
                result = 0;
                label8.Text = "cos(" + textBox1.Text + ")";
                label8.Show();
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mul = 0;

            for (int i = 1; i < 100; i++)
            {
                if (Convert.ToDouble(textBox1.Text) == i * 90)
                {
                    mul = i;
                    break;

                }
            }

            if (IsValid() )
            {
                result = Math.Tan(value);
                label8.Text = "tan(" + textBox1.Text + ")";
                label8.Show();
            }

            if (mul % 2 !=0)
            {
                flag = 1;
                result = 0;
                label8.Text = "tan(" + textBox1.Text + ")";
                label8.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                result = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                label8.Text = "sqrt(" + textBox1.Text + ")";
                label8.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                result = Math.Log10 (Convert.ToDouble(textBox1.Text));
                label8.Text = "log(" + textBox1.Text + ")";
                label8.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                result = Math.Pow(Convert.ToDouble(textBox1.Text), -1);
                label8.Text = "Inverse of(" + textBox1.Text + ")";
                label8.Show();
            }
        }


    }
}
