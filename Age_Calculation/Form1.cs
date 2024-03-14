using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Calculation
{
    public partial class Form1 : Form
    {
        int age;
        bool unvalidDate = false;
        DateTime selectedDate;
        DateTime currentDate = DateTime.Today;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromKnownColor(KnownColor.Azure);
        }
        private int CalculateAge(DateTime birthDate)
        {
            int age = currentDate.Year - birthDate.Year;

            if (birthDate > currentDate.AddYears(-age) )
                age--;

            return age;
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = monthCalendar1.SelectionStart;


            if (selectedDate >= currentDate)
            {
                unvalidDate = true;
                MessageBox.Show("Please select a valid Date first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                unvalidDate = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedDate == DateTime.MinValue)
            {
                MessageBox.Show("Please select a date of birth first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (unvalidDate == false)
            {
                age = CalculateAge(selectedDate);
                MessageBox.Show($"You are {age} years old.", "Age");
            }
            else
                MessageBox.Show("Error", "Error....");


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.FormClosing -= Form1_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
        }
    }
}
