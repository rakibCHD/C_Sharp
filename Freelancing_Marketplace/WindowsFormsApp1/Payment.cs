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
    public partial class Payment : Form
    {
        SqlConnection con = new SqlConnection(GVar.connection_string);

        public int flag;

        public static int job_id;

        public string amount;

        public static string freelancer_id;

        public string recruiter_id=Recruiter.recruiter_id;

        public int cRow;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Review_Load(object sender, EventArgs e)
        {
            flag = 0;
            GetRecord();
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            button1.Enabled = false;
            alwaysFocus();
        }

        public void alwaysFocus()
        {
            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
        }

        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select job_id,title,description,budget,hourly_rate,freelancer_id from Jobs WHERE hired_job=@hired_job AND recruiter_id=@recruiter_id ", con);

            cmd.Parameters.AddWithValue("@hired_job", "yes");
            cmd.Parameters.AddWithValue("@recruiter_id", recruiter_id);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
        }
        public void ResetForm()
        {          
             
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            textBox1.Text = "";
            richTextBox1.Text = "";
            errorProvider1.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            job_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            label6.Text = Convert.ToString(job_id);
            freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            label7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            label5.Text = freelancer_id;

            cRow = dataGridView1.CurrentRow.Index;

            IsValid();
        }

        public void IsValid()
        {
            int jobId = 0;

            con.Open();

            SqlCommand cmd = new SqlCommand("Select job_id from Payment", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<int> jobIds = new List<int>();
            while (reader.Read())
            {
                jobId = (int)reader["job_id"];
                jobIds.Add(jobId);

            }
            reader.Close();
            con.Close();

            int[] jobIdArray = jobIds.ToArray();
            if (jobIdArray.Contains(job_id))
            {
                flag = 1;
                ResetForm();
                textBox1.Enabled = false;
                MessageBox.Show("Payment Already Done for Job-"+Convert.ToString(job_id), "Done");
            }
            else
            {
                flag = 0;
                textBox1.Enabled = true;
            }

            if (dataGridView1.SelectedRows.Count > 0)
                dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];

            alwaysFocus();
        }

       
        public bool IsPayDone(int value)
        {
            int jobId = 0;

            con.Open();

            SqlCommand cmd = new SqlCommand("Select job_id from Payment", con);
            SqlDataReader reader = cmd.ExecuteReader();

            List<int> jobIds = new List<int>();
            while (reader.Read())
            {
                jobId = (int)reader["job_id"];
                jobIds.Add(jobId);

            }
            reader.Close();
            con.Close();

            int[] jobIdArray = jobIds.ToArray();

            if (jobIdArray.Contains(value))
                return true;
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag!=1 && !IsPayDone(job_id))
            { 
                SqlCommand cmd = new SqlCommand("INSERT INTO Payment (job_id,recruiter_id, freelancer_id, Amount) VALUES (@job_id,@recruiter_id,@freelancer_id,@Amount)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@job_id", job_id);
                cmd.Parameters.AddWithValue("@recruiter_id", recruiter_id);
                cmd.Parameters.AddWithValue("@freelancer_id", label5.Text);
                cmd.Parameters.AddWithValue("@Amount",textBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Payment done successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult result = MessageBox.Show("Do you like to Review?", "Question", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    ResetForm();
                    GetRecord();
                    Rating form = new Rating();
                    form.ShowDialog();                 
                }
                else
                {
                    ResetForm();
                    GetRecord();
                }

                string notification = "Recruiter: " + Recruiter.recruiter_name + " Pay("+ amount + ")$ for Job-" + Convert.ToString(job_id);
                Notification.setNotification(job_id,recruiter_id, freelancer_id, notification,"Payment");

                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
            }           
            
            alwaysFocus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, string.Empty);
            double number;

            if (double.TryParse(textBox1.Text, out number))
            {
                button1.Enabled = true;
                amount = textBox1.Text;
            }
            else
            {
                errorProvider1.SetError(textBox1, "Valid Amount required!!");
                button1.Enabled = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recruiter form = new Recruiter();
            form.Show();
            this.FormClosing -= Payment_FormClosing;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int job = Convert.ToInt32(r.Cells[0].Value);

                if (IsPayDone(job))
                {
                    r.DefaultCellStyle.BackColor = Color.LightGreen;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.LightYellow;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }

            }

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ResetForm();
            GetRecord();
            alwaysFocus();
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= Payment_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index > 0)
                {
                    int newIndex = dataGridView1.CurrentRow.Index - 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    e.Handled = true;
                }

                job_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                label6.Text = Convert.ToString(job_id);
                freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                label7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label5.Text = freelancer_id;
                cRow = dataGridView1.CurrentRow.Index;
            }
            if (e.KeyCode == Keys.Down)
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count - 1)
                {
                    int newIndex = dataGridView1.CurrentRow.Index + 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                    e.Handled = true;
                }

                job_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                label6.Text = Convert.ToString(job_id);
                freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                label7.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                richTextBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                label5.Text = freelancer_id;
                cRow = dataGridView1.CurrentRow.Index;
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1.Enabled = true;
                button1.Focus();

                int newIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                e.Handled = true;
            }
            if (e.KeyCode != Keys.Up || e.KeyCode != Keys.Down || e.KeyCode != Keys.Enter)
            {
                int newIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                e.Handled = true;
            }

            if (IsPayDone(job_id))           
                textBox1.Enabled = false;                         
            else
                textBox1.Enabled = true;
        }
    }
}
