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
    public partial class ChangedPasswordForm : Form
    {
        SqlConnection con = new SqlConnection(GVar.connection_string);


        public string matchPass;

        public ChangedPasswordForm()
        {
            InitializeComponent();
        }

        private void ChangedPasswordForm_Load(object sender, EventArgs e)
        {
            label2.Text = GVar.username;
            button1.Enabled = false;
        }

        public void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
            errorProvider1.Dispose();

        }

        private bool IsValid()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Current Password required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("New Password required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Retype Password", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password do not match", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Clear();
                return false;
            }
            else
                return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GVar.user_id > 0 && IsValid() && matchPass=="yes")
            {
                SqlCommand cmd = new SqlCommand("UPDATE Users SET  Password=@password WHERE user_id=@user_id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@user_id", GVar.user_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Password is changed successfully.", "Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();

                DialogResult result = MessageBox.Show("Do you want to go to the login page?", "Login", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoginForm loginForm = new LoginForm();
                    this.Hide();
                    loginForm.Show();
                    this.FormClosing -= ChangedPasswordForm_FormClosing;
                }
                else
                    ResetForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string role = GVar.role;

            if (role == "freelancer")
            {
                Freelancer form = new Freelancer();
                this.Hide();
                form.Show();
                this.FormClosing -= ChangedPasswordForm_FormClosing;
            }

            if (role == "recruiter")
            {
                Recruiter Form = new Recruiter();
                this.Hide();
                Form.Show();
                this.FormClosing -= ChangedPasswordForm_FormClosing;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, string.Empty);

            if (textBox2.Text != "")
            {
                if (textBox2.Text.Length < 6)
                    errorProvider1.SetError(textBox2, "Password Length should be at least 6.");

                if (!textBox2.Text.Any(char.IsUpper))
                    errorProvider1.SetError(textBox2, "Provide at least one Upper case.");

                if (!textBox2.Text.Any(char.IsLower))
                    errorProvider1.SetError(textBox2, "Provide at least one Lower case.");

                if (!textBox2.Text.Any(char.IsDigit))
                    errorProvider1.SetError(textBox2, "Provide at least one Digit.");
            }
            else
                errorProvider1.SetError(textBox2, "Password required.");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.SetError(textBox3, string.Empty);

            if (textBox3.Text == textBox2.Text)
            {
                matchPass = "yes";
                button1.Enabled = true;
            }
            else
            {
                matchPass = "No";
                button1.Enabled = false;

                if (textBox3.TextLength >= textBox2.TextLength)
                    errorProvider2.SetError(textBox3, "Password dont match!!"); 
            }
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
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1.Focus();
            }
        }

        private void ChangedPasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.FormClosing -= ChangedPasswordForm_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
            
        }
    }
}
