using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rating : Form
    {
        SqlConnection con = new SqlConnection(GVar.connection_string);

        public static string rating;

        public  int job_id=Payment.job_id;

        public string freelancer_id = Payment.freelancer_id;

        public string recruiter_id = Recruiter.recruiter_id;

        public Rating()
        {
            InitializeComponent();
        }
        private void Rating_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label3.Text = "--";
        }

        public void setRating()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Payment SET rating = @rating WHERE job_id=@job_id AND recruiter_id = @recruiter_id AND freelancer_id=@freelancer_id", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@job_id", job_id);
            cmd.Parameters.AddWithValue("@rating",Convert.ToInt32(rating));
            cmd.Parameters.AddWithValue("@freelancer_id", freelancer_id);
            cmd.Parameters.AddWithValue("@recruiter_id", recruiter_id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.whiteStar;
            pictureBox3.Image = Properties.Resources.whiteStar;
            pictureBox4.Image = Properties.Resources.whiteStar;
            pictureBox5.Image = Properties.Resources.whiteStar;

            pictureBox1.Image = Properties.Resources.goldenStar;
            label3.Text = "1";
            rating=label3.Text;

            button1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.whiteStar;
            pictureBox4.Image = Properties.Resources.whiteStar;
            pictureBox5.Image = Properties.Resources.whiteStar;

            pictureBox2.Image = Properties.Resources.goldenStar;
            pictureBox1.Image = Properties.Resources.goldenStar;
            label3.Text = "2";
            rating = label3.Text;

            button1.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.whiteStar;
            pictureBox5.Image = Properties.Resources.whiteStar;

            pictureBox3.Image = Properties.Resources.goldenStar;
            pictureBox2.Image = Properties.Resources.goldenStar;
            pictureBox1.Image = Properties.Resources.goldenStar;
            label3.Text = "3";
            rating = label3.Text;

            button1.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.whiteStar;

            pictureBox4.Image = Properties.Resources.goldenStar;
            pictureBox3.Image = Properties.Resources.goldenStar;
            pictureBox2.Image = Properties.Resources.goldenStar;
            pictureBox1.Image = Properties.Resources.goldenStar;
            label3.Text = "4";
            rating = label3.Text;

            button1.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.goldenStar;
            pictureBox4.Image = Properties.Resources.goldenStar;
            pictureBox3.Image = Properties.Resources.goldenStar;
            pictureBox2.Image = Properties.Resources.goldenStar;
            pictureBox1.Image = Properties.Resources.goldenStar;
            label3.Text = "5";
            rating = label3.Text;

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setRating();
            this.Hide();
        }
    }
}
