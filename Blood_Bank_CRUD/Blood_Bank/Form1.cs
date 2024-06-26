﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
 
namespace Blood_Bank
{
    public partial class Blood_Bank_Register : Form
    {
        public Blood_Bank_Register()
        {
            InitializeComponent();
        }

        public int SL_No;
        SqlConnection con = new SqlConnection(@"Data Source=rakib\sql19;Initial Catalog=Blood_Bank;Integrated Security=True");

        private void Blood_Bank_Register_Load(object sender, EventArgs e)
        {
            GetRecord();
        }

        private void GetRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Blood_Bank_Table", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            DGV.DataSource = dt;
        }

        private void B_Insert_Click(object sender, EventArgs e)
        {
            if (IsValid() == true)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Blood_Bank_Table VALUES(@Name,@NID,@Profession,@BG,@Phone,@Address)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", TB_Name.Text);
                cmd.Parameters.AddWithValue("@NID", TB_NID.Text);
                cmd.Parameters.AddWithValue("@Profession", TB_Profession.Text);
                cmd.Parameters.AddWithValue("@BG", TB_BG.Text);
                cmd.Parameters.AddWithValue("@Phone", TB_Phone.Text);
                cmd.Parameters.AddWithValue("@Address", TB_Address.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Doner is Saved.", "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                ResetForm();
            }
        }

        private bool IsValid()
        {
            if (TB_Name.Text == string.Empty)
            {
                MessageBox.Show("Name required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (TB_NID.Text == string.Empty)
            {
                MessageBox.Show("NID required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (TB_BG.Text == string.Empty)
            {
                MessageBox.Show("Blood Group required", "Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else
                return true;
        }

        private void L_Address_Click(object sender, EventArgs e)
        {

        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            SL_No = 0;

            TB_Name.Clear();
            TB_NID.Clear();
            TB_Profession.Clear();
            TB_BG.Clear();
            TB_Phone.Clear();
            TB_Address.Clear();

            TB_Name.Focus();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SL_No = Convert.ToInt32(DGV.SelectedRows[0].Cells[0].Value);

            TB_Name.Text = DGV.SelectedRows[0].Cells[1].Value.ToString();
            TB_NID.Text = DGV.SelectedRows[0].Cells[2].Value.ToString();
            TB_Profession.Text = DGV.SelectedRows[0].Cells[3].Value.ToString();
            TB_BG.Text = DGV.SelectedRows[0].Cells[4].Value.ToString();
            TB_Phone.Text = DGV.SelectedRows[0].Cells[5].Value.ToString();
            TB_Address.Text = DGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            if (SL_No > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE  Blood_Bank_Table set Name=@Name,NID=@NID,Profession=@Profession,BG=@BG,Phone=@Phone,Address=@Address WHERE SL_No=@SL", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", TB_Name.Text);
                cmd.Parameters.AddWithValue("@NID", TB_NID.Text);
                cmd.Parameters.AddWithValue("@Profession", TB_Profession.Text);
                cmd.Parameters.AddWithValue("@BG", TB_BG.Text);
                cmd.Parameters.AddWithValue("@Phone", TB_Phone.Text);
                cmd.Parameters.AddWithValue("@Address", TB_Address.Text);
                cmd.Parameters.AddWithValue("@SL", this.SL_No);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Doner information is Updated successfully.", "Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                ResetForm();
            }

            else
              MessageBox.Show("Select a Doner to Update", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Error); 

        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            if (SL_No > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE from  Blood_Bank_Table WHERE SL_No=@SL", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@SL", this.SL_No);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted successfully.", "Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetRecord();
                ResetForm();
            }

            else
                MessageBox.Show("Select a Doner to Delete", "Select!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
