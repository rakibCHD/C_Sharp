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
    public partial class SignUpForm : Form     
    {
        public int count;

        SqlConnection con = new SqlConnection(GVar.connection_string);

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            count = 0;
            button1.Enabled = false;
        }

        private void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex=-1;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();

            if (checkBox1.Checked == true)
                checkBox1.Checked = false;           
        }

        private bool IsValid()
        {
           if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                return false;
            
           else if ( comboBox1.Text == string.Empty|| comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else 
                return true; 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string role = comboBox1.Text;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, string.Empty);

            if (textBox1.Text != string.Empty)
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username = @username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    button1.Enabled = false;
                    errorProvider1.SetError(textBox1, "Username already exists.Please choose a different username.");
                }
                else
                    button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                errorProvider1.SetError(textBox1, "Username required.");
                textBox1.Focus();
            }

            if (count > 0 ||textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(textBox2, string.Empty);

            if (textBox2.Text != "")
            {
                if (textBox2.Text.Length < 6)
                {
                    button1.Enabled = false;
                    errorProvider2.SetError(textBox2, "Password Length should be at least 6.");
                    textBox2.Focus();
                }
                if (!textBox2.Text.Any(char.IsUpper))
                {
                    button1.Enabled = false;
                    errorProvider2.SetError(textBox2, "Provide at least one Upper case.");
                    textBox2.Focus();
                }
                if (!textBox2.Text.Any(char.IsLower))
                {
                    button1.Enabled = false;
                    errorProvider2.SetError(textBox2, "Provide at least one Lower case.");
                    textBox2.Focus();
                }
                if (!textBox2.Text.Any(char.IsDigit))
                {
                    button1.Enabled = false;
                    errorProvider2.SetError(textBox2, "Provide at least one Digit.");
                    textBox2.Focus();
                }

                if (textBox2.Text.Length >= 6)
                    button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                errorProvider2.SetError(textBox2, "Password required.");
                textBox2.Focus();
            }

            if (count > 0 || textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                button1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider3.SetError(textBox3, string.Empty);

            if (textBox3.Text != string.Empty)
            {
                if (!textBox3.Text.Any(c => c == '@') || !textBox3.Text.EndsWith(".com"))
                {
                    button1.Enabled = false;
                    errorProvider3.SetError(textBox3, "Provide a valid Email Address.");
                    textBox3.Focus();
                }
                else
                    button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
                errorProvider3.SetError(textBox3, "Email required.");
                textBox3.Focus();
            }

            if (count > 0 || textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string username = textBox1.Text;
            string password = textBox2.Text;
            string email = textBox3.Text;
            string role=comboBox1.Text;

            if (IsValid())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (username, password, email, role) VALUES (@username, @password, @email, @role)", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Account created successfully.");
                ResetForm();
                

                DialogResult result = MessageBox.Show("Do you want to go to the login page?", "Login", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                    this.FormClosing -= SignUpForm_FormClosing;
                }  
              con.Close();

            }

            textBox1.Focus();
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.FormClosing -= SignUpForm_FormClosing;
                Application.Exit();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.Show();
            this.FormClosing -= SignUpForm_FormClosing;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
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
                textBox3.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                comboBox1.Focus();
            }
            if (e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                comboBox1.Focus();
            }
        
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                textBox3.Focus();
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

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= SignUpForm_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;           
        }      
      
    }
}
