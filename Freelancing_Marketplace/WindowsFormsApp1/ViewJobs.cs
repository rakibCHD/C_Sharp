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
    public partial class ViewJobs : Form
    {
        public bool IsAnotherFormOpen;

        SqlConnection con = new SqlConnection(GVar.connection_string);
        
        public ViewJobs()
        {
            InitializeComponent();
        }

        private void ViewJobs_Load(object sender, EventArgs e)
        {
            IsAnotherFormOpen = false;
            GetRecord();
        }
        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("select * from Jobs", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt;
            dataGridView1.CurrentCell = null;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminform form = new adminform();
            this.Hide();
            form.Show();
            IsAnotherFormOpen = true;
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                int job = Convert.ToInt32(r.Cells[0].Value);
                string freelancer = Convert.ToString(r.Cells[6].Value);
                string hired_job = Convert.ToString(r.Cells[7].Value);

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
        }

        private void ViewJobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsAnotherFormOpen == false)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.FormClosing -= ViewJobs_FormClosing;
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }
    }
}
