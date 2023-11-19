using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Recruiter : Form
    {
        SqlConnection con = new SqlConnection(GVar.connection_string);

        public Recruiter()
        {
            InitializeComponent();
        }

        public string r_id;

        public int job_id;

        public static string recruiter_id;
        public static string recruiter_name;

        public string freelancer_id;

        public string hired_job;

        public bool IsAnotherFormOpen;

        public int cRow;


        private void createjob_Load(object sender, EventArgs e)
        {      
            GetRecord();
            getRId();
            label9.Text = GVar.username;
            recruiter_name = GVar.username;
            label4.Text = recruiter_id;

            cRow = -1;
            IsAnotherFormOpen = false;

            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
        }

        public void getRId()
        {
            string username = GVar.username;
            string password = GVar.password;
            string role = GVar.role;

            con.Open();

            SqlCommand comand = new SqlCommand("SELECT user_id FROM Users WHERE username=@username AND password=@password And role=@role ", con);
            comand.Parameters.AddWithValue("@username", username);
            comand.Parameters.AddWithValue("@password", password);
            comand.Parameters.AddWithValue("@role", role);

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows && reader.Read())
            {
                recruiter_id = reader["user_id"].ToString();
            }

            reader.Close();
            con.Close();

        }

        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select job_id,title,description,budget,hourly_rate,freelancer_id,hired_job from Jobs", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
          
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;           
        }

        private bool IsValid()
        {
            if (txttitle.Text == String.Empty || txtdescrip.Text == string.Empty || txtbudget.Text == String.Empty || txthr.Text == string.Empty)
            {   
                return false;
            }
            return true;
        }


        public bool IsJobExist()
        {
            string title = "";
            string description = "";
            string budget = "";
            string hourly_rate = "";

            con.Open();
            SqlCommand comand = new SqlCommand("SELECT * FROM Jobs WHERE recruiter_id=@recruiter_id", con);
            comand.Parameters.AddWithValue("@recruiter_id", recruiter_id);
            SqlDataReader reader = comand.ExecuteReader();

            List<string> titles = new List<string>();
            List<string> descriptions = new List<string>();
            List<string> budgets = new List<string>();
            List<string> hourly_rates = new List<string>();

            while (reader.Read())
            {
                title = reader["title"].ToString();
                titles.Add(title);

                description = reader["description"].ToString();
                descriptions.Add(description);

                budget = reader["budget"].ToString();
                budgets.Add(budget);

                hourly_rate = reader["hourly_rate"].ToString();
                hourly_rates.Add(hourly_rate);
            }
            reader.Close();
            con.Close();

            string[] titleArray =titles.ToArray();

            string[] descriptionArray = descriptions.ToArray();

            string[] budgetArray = budgets.ToArray();

            string[] hourly_rateArray = hourly_rates.ToArray();

            if (titleArray.Contains(txttitle.Text.Trim()) && descriptionArray.Contains(txtdescrip.Text.Trim())  && budgetArray.Contains(txtbudget.Text.Trim()) && hourly_rateArray.Contains(txthr.Text.Trim()))
            {
                return true;
            }
            else
                 return false;
        }

        public bool IsThisRId()
        {
            con.Open();
            SqlCommand comand = new SqlCommand("SELECT recruiter_id FROM Jobs WHERE job_id=@job_id ", con);
            comand.Parameters.AddWithValue("@job_id", job_id);

            SqlDataReader reader = comand.ExecuteReader();

            if (reader.HasRows && reader.Read())
            {
                r_id = reader["recruiter_id"].ToString();
            }

            reader.Close();
            con.Close();

            if (r_id == recruiter_id)
            {
                return true;
            }
            else
                return false;
        }

        private void ResetForm()
        {
            job_id = 0;

            txtdescrip.Clear();
            txttitle.Clear();
            txtbudget.Clear();
            txthr.Clear();

            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
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
            if (IsJobExist())
            {
                MessageBox.Show("Job is already Posted.", "Posted!!", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (dataGridView1.SelectedRows.Count > 0)          
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
                         
            }           
            
            if (IsValid() && !IsJobExist())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Jobs (title, description, budget, hourly_rate, recruiter_id, hired_job, applied) VALUES (@title, @description, @budget, @hourly_rate, @recruiter_id, @hired_job,@applied)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@title", txttitle.Text);
                cmd.Parameters.AddWithValue("@description", txtdescrip.Text);
                cmd.Parameters.AddWithValue("@budget", txtbudget.Text);
                cmd.Parameters.AddWithValue("@hourly_rate", txthr.Text);
                cmd.Parameters.AddWithValue("@recruiter_id", recruiter_id);
                cmd.Parameters.AddWithValue("@hired_job", "No");
                cmd.Parameters.AddWithValue("@applied", "No");

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Job Posted successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetRecord();
                if (dataGridView1.Rows.Count > 0)
                {
                    int lastIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[lastIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[lastIndex].Cells[0];
                    dataGridView1.FirstDisplayedScrollingRowIndex = lastIndex;
                }
            }
           
            if (!IsValid())
                MessageBox.Show("Provide Job Details.", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            ResetForm();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool IsUpdated = false;

            if (job_id > 0)
            {
                if (IsThisRId() && !IsJobExist())
                {
                    if (hired_job == "No" && !IsPayDone(job_id))
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE  Jobs set title=@title, description=@description, budget=@budget, hourly_rate=@hourly_rate WHERE job_id=@job_id", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@job_id", job_id);
                        cmd.Parameters.AddWithValue("@title", txttitle.Text);
                        cmd.Parameters.AddWithValue("@description", txtdescrip.Text);
                        cmd.Parameters.AddWithValue("@budget", txtbudget.Text);
                        cmd.Parameters.AddWithValue("@hourly_rate", txthr.Text);


                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Job information is Edited successfully.", "Editedted.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        IsUpdated = true;
                        GetRecord();
                    }
                    
                    if (IsPayDone(job_id) == true)
                        MessageBox.Show("Nothing to Edit. Payment is done.", "Can't Edit.");
                }

                if (IsThisRId() && IsJobExist() && hired_job == "Yes")
                    MessageBox.Show("Already hired for Freelancer: " + freelancer_id, "Can't Edit.", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (IsUpdated==false && IsThisRId() && IsJobExist() && hired_job=="No")
                    MessageBox.Show("Nothing to Edit.Job is already exist.", "Can't Edit.",MessageBoxButtons.OK, MessageBoxIcon.None);
                if (!IsThisRId())               
                    MessageBox.Show("You can't edit this job.This Job posted by Recruiter: " + r_id, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            
                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
            }
            else
                MessageBox.Show("Select a job to Edit.", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            ResetForm();      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (job_id > 0)
            {
                if ((IsThisRId() && IsPayDone(job_id)) || (hired_job == "No" && IsThisRId()))
                {
                    DialogResult result = MessageBox.Show("Are you sure to Delete Job-" + job_id + " ?", "Delete??", MessageBoxButtons.YesNo);
                    if (result != DialogResult.No)
                    {
                        SqlCommand cmd = new SqlCommand("DELETE from  Jobs WHERE job_id=@job_id", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@job_id", job_id);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Job-" + job_id + " deleted succesfully.", "Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetRecord();
                    }
                   
                }
                if(IsThisRId() && hired_job == "Yes" && !IsPayDone(job_id))
                    MessageBox.Show("Freelancer- " + freelancer_id +" already Hired.", "Can't Delete!!", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (IsThisRId() == false)             
                    MessageBox.Show("You can't Delete this job.This Job posted by Recruiter: " + r_id, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                             
            }
            else
                MessageBox.Show("Select a job to Delete.", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);       
            ResetForm();
        }


        private void Confirm_Click(object sender, EventArgs e)
        {
            if (job_id > 0)
            {
                if (IsThisRId())
                {
                    if (freelancer_id != "" && hired_job != "Yes")
                    {
                        MessageBox.Show("Job-"+job_id+" confirmed.", "Confirmed.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand cmd = new SqlCommand("UPDATE  Jobs set hired_job=@hired_job WHERE job_id=@job_id", con);
                        cmd.CommandType = CommandType.Text;

                        cmd.Parameters.AddWithValue("@job_id", job_id);
                        cmd.Parameters.AddWithValue("@hired_job", "Yes");


                        string notification = "Recruiter: "+label9.Text+" Confirm Job-"+Convert.ToString(job_id);
                        Notification.setNotification(job_id,recruiter_id,freelancer_id,notification,"Confirm");

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        GetRecord();
                    }
                    else if (hired_job == "Yes")                 
                        MessageBox.Show("This job is already hired for Freelancer: " + freelancer_id, "You Already Hired.", MessageBoxButtons.OK, MessageBoxIcon.None);

                    else if (freelancer_id == "")                   
                        MessageBox.Show("Not applied yet.", "Not Appleid.", MessageBoxButtons.OK, MessageBoxIcon.None);                   
                }
                else
                    MessageBox.Show("You can't confirm this job.This Job posted by Recruiter: " + r_id, "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
            }
            else
                MessageBox.Show("Select a talent first.", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            ResetForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
            this.FormClosing -= Recruiter_FormClosing;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            this.Hide();
            form.Show();
            this.FormClosing -= Recruiter_FormClosing;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (recruiter_id == Convert.ToString(GVar.user_id))
            {
                ChangedPasswordForm form = new ChangedPasswordForm();
                this.Hide();
                form.Show();
                this.FormClosing -= Recruiter_FormClosing;
            }
        }
 
        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int job = Convert.ToInt32(r.Cells[0].Value);
                string freelancer = Convert.ToString(r.Cells[5].Value);
                string hired_job = Convert.ToString(r.Cells[6].Value);

                if (IsPayDone(job))
                {
                    r.DefaultCellStyle.BackColor = Color.LightGreen;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (hired_job == "Yes" && !IsPayDone(job))
                {
                    r.DefaultCellStyle.BackColor = Color.SkyBlue;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (freelancer != "" && hired_job == "No")
                {
                    r.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GetRecord();
            ResetForm();         
        }

        public bool IsMyJob(string value)
        {
            string jobId = "";
            con.Open();

            SqlCommand cmd = new SqlCommand("Select job_id from Jobs WHERE recruiter_id=@recruiter_id", con);
            cmd.Parameters.AddWithValue("@recruiter_id", recruiter_id);
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> jobIds = new List<string>();
            while (reader.Read())
            {
                jobId = reader["job_id"].ToString();
                jobIds.Add(jobId);

            }
            reader.Close();
            con.Close();

            string[] jobIdArray = jobIds.ToArray();

            if (jobIdArray.Contains(value))
                return true;
            else
                return false;

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            job_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            txttitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtdescrip.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtbudget.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txthr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            cRow = dataGridView1.CurrentRow.Index;

        }

        
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                e.PaintBackground(e.CellBounds, false);

                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value != null)
                {
                    string jobId = cell.Value.ToString();
                    
                    int starX = e.CellBounds.Left + 2;
                    int starY = e.CellBounds.Top + (e.CellBounds.Height - 16) / 2; 

                   if(IsMyJob(jobId)==true)
                        e.Graphics.DrawImage(Properties.Resources.BlueStar, starX, starY, 9, 9);


                    int textX = starX + 5 + 4; 
                    int textY = e.CellBounds.Top + (e.CellBounds.Height - e.CellStyle.Font.Height) / 2; 
                    
                    e.Graphics.DrawString(jobId, e.CellStyle.Font, Brushes.Black, textX, textY);
                }
                e.Handled = true;
            }
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

                txttitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtdescrip.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtbudget.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txthr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

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

                txttitle.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtdescrip.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtbudget.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txthr.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                freelancer_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                cRow = dataGridView1.CurrentRow.Index;             
            }
            if(e.KeyCode !=Keys.Up|| e.KeyCode != Keys.Down)
            {
                int newIndex = dataGridView1.CurrentRow.Index;
                dataGridView1.CurrentCell = dataGridView1.Rows[newIndex].Cells[dataGridView1.CurrentCell.ColumnIndex];
                e.Handled = true;
            }
        }

        private void Recruiter_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= Recruiter_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;
            
        }

       
    }
}


