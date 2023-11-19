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
    public partial class adminform : Form
    {

        SqlConnection con = new SqlConnection(GVar.connection_string);

        public int count;
        public int flag;
        public int user_id;
        public int cRow;


        public adminform()
        {
            InitializeComponent();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            count = 0;
            flag = 0;
            cRow = -1;
            GetRecord();
            label5.Text = GVar.username;

            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
        }

        public int getAdminCount()
        {
            int count = 0;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE role=@role", con);
            cmd.Parameters.AddWithValue("@role", "admin");

            object result1 = cmd.ExecuteScalar();

            if (result1 != DBNull.Value)
                count = Convert.ToInt32(result1);

            cmd.ExecuteNonQuery();
            con.Close();

            return count;
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Rows[getAdminCount()].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.Rows[getAdminCount()].Cells[0];
        }


        private void ResetForm()
        {
            user_id = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();

        }

        private bool IsValid()
        {
            if (textBox1.Text != string.Empty)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please provide a different username.", "Error!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    textBox1.Clear();
                    this.ActiveControl = dataGridView1;
                    return false;
                }
            }

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("User Name required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Password required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Email required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Role required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {

                return true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = comboBox1.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            user_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            string roleText = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            cRow = dataGridView1.CurrentRow.Index;

            if (roleText == "admin")
            {
                ResetForm();
                MessageBox.Show("Authorized Admin. Select another user.", "Admin!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                GetRecord();
            }
            else
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox1.Text = roleText;
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "password" && e.RowIndex >= 0)
            {
                DataGridViewCell roleCell = dataGridView1.Rows[e.RowIndex].Cells["role"];
                if (roleCell.Value != null && roleCell.Value.ToString() == "admin")
                {
                    e.Value = new String('*', e.Value.ToString().Length);
                }
            }

            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                string role = Convert.ToString(r.Cells[4].Value);


                if (role == "admin")
                {
                    r.DefaultCellStyle.BackColor = Color.Salmon;
                    r.DefaultCellStyle.ForeColor = Color.White;
                }
                if (role == "freelancer")
                {
                    r.DefaultCellStyle.BackColor = Color.ForestGreen;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (role == "recruiter")
                {
                    r.DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }

            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES(@username,@password,@email,@role)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@role", comboBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New User is Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                ResetForm();

                if (dataGridView1.Rows.Count > 0)
                {
                    int lastIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[lastIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[lastIndex].Cells[0];
                    dataGridView1.FirstDisplayedScrollingRowIndex = lastIndex;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (user_id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Users SET UserName=@username, Password=@password, Email=@email, Role=@role WHERE user_id=@user_id", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@role", comboBox1.Text);
                cmd.Parameters.AddWithValue("@user_id", user_id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User information is updated successfully.", "Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                ResetForm();

                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
            }
            else
                MessageBox.Show("Select a User to Update", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (user_id > 0)
            {

                DialogResult result = MessageBox.Show("Are you sure to Delete?", "Delete??", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("DELETE from  Users WHERE user_id=@user_id", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@user_id", user_id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetRecord();
                    ResetForm();
                }
            }
            else
                MessageBox.Show("Select a User to Delete", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
            this.FormClosing -= adminform_FormClosing;
        }

        private void label6_Click(object sender, EventArgs e)
        {

            ViewJobs form = new ViewJobs();
            this.Hide();
            form.Show();
            this.FormClosing -= adminform_FormClosing;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox2, string.Empty);

            if (textBox2.Text != "")
            {
                if (textBox2.Text.Length < 6)
                {
                    button1.Enabled = false;
                    errorProvider1.SetError(textBox2, "Password Length should be at least 6.");
                }
                if (!textBox2.Text.Any(char.IsUpper))
                {
                    button1.Enabled = false;
                    errorProvider1.SetError(textBox2, "Provide at least one Upper case.");
                  
                }
                if (!textBox2.Text.Any(char.IsLower))
                {
                    button1.Enabled = false;
                    errorProvider1.SetError(textBox2, "Provide at least one Lower case.");
                   
                }
                if (!textBox2.Text.Any(char.IsDigit))
                {
                    button1.Enabled = false;
                    errorProvider1.SetError(textBox2, "Provide at least one Digit.");
                    
                }

                if (textBox2.Text.Length >= 6)
                    button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GetRecord();
            ResetForm();
        }

        private void adminform_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.FormClosing -= adminform_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (getAdminCount() != dataGridView1.CurrentRow.Index)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > 0)
                    {
                        int newIndex = dataGridView1.CurrentRow.Index - 1;
                        dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                        e.Handled = true;
                    }

                    user_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    cRow = dataGridView1.CurrentRow.Index;
                }
            }
            else
                GetRecord();

            if (e.KeyCode == Keys.Down)
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
                {
                    int newIndex = dataGridView1.CurrentRow.Index + 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    e.Handled = true;
                }

                user_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cRow = dataGridView1.CurrentRow.Index;
            }

            if (e.KeyCode != Keys.Up || e.KeyCode != Keys.Down)
            {
                int newIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                e.Handled = true;
            }
        }
    }
}
