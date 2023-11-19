using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Freelancer : Form 
    {
        SqlConnection con = new SqlConnection(GVar.connection_string);


        public int job_id;

        public int notCount;

        public static string freelancer_id;

        public string recruiter_id;

        public string hired_job;

        public string applied;

        public double rating;
        public double row;
        public double rat;
        public static double financials;
        public int cRow;

        public bool[] isCountDecremented;

        public Freelancer()
        {
            InitializeComponent();
        }
     
       
        private void Freelancer_Load(object sender, EventArgs e)
        {
            label11.Visible = false;
            notCount = 0;
            cRow = -1;
            listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            GetRecord();
            alwaysFocus();
            getFId();
            label5.Text = GVar.username;
            label4.Text = freelancer_id;
            getRating();
            getFinancials();           
            getNotification();          
        }

        public void alwaysFocus()
        {
            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
        }

        public void getNotification()
        {
            panel1.Visible = false;
            label12.Visible = false;

            listBox1.Visible = false; 
            notCount = Notification.notificationCount(freelancer_id);

            if (notCount != 0)
                label10.Text = Convert.ToString(notCount);
            else
                label10.Text = "";

            if (notCount != 0)                          
                listBox1.DataSource = Notification.getNewNotification(freelancer_id).ToList();
            
            else                       
                label12.Text = "No new Notification to show.";
                                                              
        }

        public void getRating()
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SUM(rating) FROM Payment WHERE freelancer_id=@freelancer_id", con);
            cmd.Parameters.AddWithValue("@freelancer_id", freelancer_id);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
                 rating = Convert.ToInt32(result);

            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Payment WHERE freelancer_id=@freelancer_id AND rating IS NOT NULL", con);
            cmd1.Parameters.AddWithValue("@freelancer_id", freelancer_id);

            object result1= cmd1.ExecuteScalar();

            if (result1 != DBNull.Value)
                row = Convert.ToInt32(result1);

            cmd.ExecuteNonQuery();
            con.Close();

            rat = Math.Truncate((rating/row) *10)/10;

            if(Convert.ToString(rat)=="NaN")
                label7.Text = "";       
            else
                label7.Text = Convert.ToString(rat);
        }

        public void getFinancials()
        {           
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT SUM(amount) FROM Payment WHERE freelancer_id=@freelancer_id", con);
            cmd.Parameters.AddWithValue("@freelancer_id", freelancer_id);

            object result = cmd.ExecuteScalar();

            if (result != DBNull.Value)
                financials = Convert.ToDouble(result);

            cmd.ExecuteNonQuery();
            con.Close();

            label9.Text = Convert.ToString(Math.Round(financials,2)) + " $";
        }

        public void getFId()
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
                freelancer_id = reader["user_id"].ToString(); 
            }
            
            reader.Close();
            con.Close();

        }

        private void GetRecord()
        {           
            SqlCommand cmd = new SqlCommand("Select job_id,title,description,budget,hourly_rate,recruiter_id,hired_job,applied from Jobs", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;  
            dataGridView1.AllowUserToAddRows = false;                 
        }

        private void GetNewRecord()
        {
            SqlCommand cmd = new SqlCommand("Select job_id,title,description,budget,hourly_rate,recruiter_id,hired_job,applied from Jobs", con);

            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            applied = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

            cRow = dataGridView1.CurrentRow.Index;

            if (applied == "Yes" && hired_job == "No")
            {
                MessageBox.Show("Already Applied.", "Applied!!", MessageBoxButtons.OK, MessageBoxIcon.None);             
            }
            else if (hired_job == "Yes")
            {
                MessageBox.Show("Already Hired.", "Hired!!", MessageBoxButtons.OK, MessageBoxIcon.None);              
            }
            else
            {             
                job_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                recruiter_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

 
        private void button1_Click(object sender, EventArgs e)
        {       
            if (job_id > 0)
            {
                if (recruiter_id != "" && hired_job != "Yes" && applied!="Yes")
                {
                    MessageBox.Show("Applied successfully.", "Applied.", MessageBoxButtons.OK, MessageBoxIcon.None);

                    SqlCommand cmd = new SqlCommand("UPDATE  Jobs set freelancer_id=@freelancer_id, applied=@applied WHERE job_id=@job_id", con);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@job_id", job_id);
                    cmd.Parameters.AddWithValue("@freelancer_id", freelancer_id);
                    cmd.Parameters.AddWithValue("@applied", "Yes");

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetNewRecord();
                   
                }
                if (applied == "Yes" && hired_job == "No")
                {
                    MessageBox.Show("Already Applied.", "Applied!!", MessageBoxButtons.OK, MessageBoxIcon.None);                  
                }
                if (hired_job == "Yes")
                {
                    MessageBox.Show("Already Hired.", "Hired!!", MessageBoxButtons.OK, MessageBoxIcon.None);                                
                }

                if (dataGridView1.SelectedRows.Count > 0)
                    dataGridView1.CurrentCell = dataGridView1.Rows[cRow].Cells[0];
            }
            else
                MessageBox.Show("Select a job first.", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            alwaysFocus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
            financials = 0;
            this.FormClosing -= Freelancer_FormClosing;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (freelancer_id == Convert.ToString(GVar.user_id))
            {
                ChangedPasswordForm form = new ChangedPasswordForm();
                this.Hide();
                form.Show();
                this.FormClosing -= Freelancer_FormClosing;
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {          
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {             
                string hired_job = Convert.ToString(r.Cells[6].Value);

                if (hired_job == "Yes")
                {
                    r.DefaultCellStyle.BackColor = Color.SkyBlue;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }
                if (hired_job == "No")
                {
                    r.DefaultCellStyle.BackColor = Color.LightYellow;
                    r.DefaultCellStyle.ForeColor = Color.Black;
                }              
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GetRecord();
            this.ActiveControl = dataGridView1;
            dataGridView1.Focus();
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
                recruiter_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                applied = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
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
                recruiter_id = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                hired_job = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                applied = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cRow = dataGridView1.CurrentRow.Index;
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1.Enabled=true;
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (notCount == 0)
            {
                if (panel1.Visible)
                {
                    label11.Visible = false;
                    panel1.Visible = false;
                    label12.Visible = false;
                }
                else
                {
                    label11.Visible = true;
                    panel1.Visible = true;
                    label12.Visible = true;
                }
            }
            else
            {

                if (listBox1.Visible)
                {
                    label11.Visible = false;
                    listBox1.Visible = false;
                    listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                    alwaysFocus();
                }
                else
                {
                    label11.Visible = true;
                    listBox1.Visible = true;
                    listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

                    this.ActiveControl = listBox1;
                    listBox1.Focus();
                }
            }        
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (notCount == 0)
            {
                if (panel1.Visible)
                {
                    label11.Visible = false;
                    panel1.Visible = false;
                    label12.Visible = false;
                }
                else
                {
                    label11.Visible = true;
                    panel1.Visible = true;
                    label12.Visible = true;
                }
            }
            else
            {

                if (listBox1.Visible)
                {
                    label11.Visible = false;
                    listBox1.Visible = false;
                    listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                    alwaysFocus();
                }
                else
                {
                    label11.Visible = true;
                    listBox1.Visible = true;
                    listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

                    this.ActiveControl = listBox1;
                    listBox1.Focus();
                }
            }
        }

        public void updateNotification(int value, string isConORpay)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Notification SET is_seen=@is_seen WHERE job_id=@job_id AND is_con=@is_con AND is_pay=@is_pay", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@job_id", value);
            cmd.Parameters.AddWithValue("@is_seen", "Yes");

            if (isConORpay == "Confirm")
            {
                cmd.Parameters.AddWithValue("@is_con", "Yes");
                cmd.Parameters.AddWithValue("@is_pay", "No");
            }
            if (isConORpay == "Payment")
            {
                cmd.Parameters.AddWithValue("@is_con", "No");
                cmd.Parameters.AddWithValue("@is_pay", "Yes");
            }

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int job_id = 0;
            
            int index = listBox1.SelectedIndex;

            if (notCount != 0 && index != -1)
            {
                listBox1.SelectedIndexChanged -= listBox1_SelectedIndexChanged;

                string selectedValue = listBox1.SelectedItem.ToString();

                int hyphenIndex = selectedValue.IndexOf("-");

                if (hyphenIndex != -1)
                {
                    string job_id_Num = selectedValue.Substring(hyphenIndex + 1);
                    bool success = int.TryParse(job_id_Num, out job_id);
                    MessageBox.Show(selectedValue,"Notification");
                }

                if (selectedValue.Contains("Confirm"))
                    updateNotification(job_id, "Confirm");

                if (selectedValue.Contains("Pay"))
                    updateNotification(job_id, "Payment");

                Stack<string> notifications = Notification.getNewNotification(freelancer_id);
                List<string> notificationList = new List<string>(notifications);
                notificationList.Remove(selectedValue);

                notifications = new Stack<string>(notificationList);
                listBox1.DataSource = notifications.ToList();

                if(listBox1.Items.Count!=0)
                     label10.Text = Convert.ToString(listBox1.Items.Count);

                listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

                if (listBox1.Items.Count == 0)
                {
                    label10.Text = "";
                    listBox1.Visible = false;
                    label11.Visible = false;
                    panel1.Visible = false;
                    label12.Visible = false;
                    label12.Text = "No new Notification to show.";
                    notCount = 0;
                }
            }
                        
            alwaysFocus();  
        }

        private void Freelancer_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.FormClosing -= Freelancer_FormClosing;
                Application.Exit();
            }
            else
                e.Cancel = true;                       
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Financials form = new Financials();         
            form.ShowDialog();                    
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Financials form = new Financials();
            form.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            AllNotification form = new AllNotification();
            form.ShowDialog();
            listBox1.Visible = false;
            label11.Visible = false;
            panel1.Visible = false;
            label12.Visible = false;
        }

    }
}
