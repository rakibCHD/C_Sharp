using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {

        SqlConnection connection = new SqlConnection(GVar.connection_string);
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            textBox1.Focus();
            timer1.Start();         
        }

        public void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                textBox1.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_id=0;
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = "";
            string email = "";

            GVar.username = username;
            GVar.password = password;
            
            
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT user_id,role,email FROM Users WHERE username=@username AND password=@password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);


                SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows && reader.Read())
            {
                user_id = Convert.ToInt32(reader["user_id"]);
                role = reader["role"].ToString();
                email = reader["email"].ToString();
            }

            GVar.user_id = user_id;
            GVar.role = role;
            GVar.email = email;

                reader.Close();
                connection.Close();


            switch (role)
            {
                case "admin":
                    adminform admin = new adminform();
                    admin.Show();
                    this.Hide();
                    this.FormClosing -= LoginForm_FormClosing;
                    break;
                case "recruiter":
                    Recruiter recruiterForm = new Recruiter();
                    recruiterForm.Show();
                    this.Hide();
                    this.FormClosing -= LoginForm_FormClosing;
                    break;
                case "freelancer":
                    Freelancer freelancerForm = new Freelancer();
                    freelancerForm.Show();
                    this.Hide();
                    this.FormClosing -= LoginForm_FormClosing;
                    break;
                default:
                    MessageBox.Show("Invalid username or password");
                    ResetForm();
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.FormClosing -= LoginForm_FormClosing;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
        }
  
        private void checkBox1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            timer2.Stop();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {              
                this.FormClosing -= LoginForm_FormClosing;                
                Application.Exit();
            }
            else         
                e.Cancel = true;
            
        }
    }
}
