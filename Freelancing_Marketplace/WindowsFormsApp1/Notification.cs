using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Notification
    {
       static SqlConnection con = new SqlConnection(GVar.connection_string);
        public static Stack<string> getNewNotification(string value)
        {
            Stack<string> notifications = new Stack<string>();

                con.Open();

                SqlCommand command = new SqlCommand("SELECT notification_string FROM Notification Where f_id=@f_id AND is_seen=@is_seen", con);
                command.Parameters.AddWithValue("@f_id", value);
                command.Parameters.AddWithValue("@is_seen", "No");

                command.ExecuteNonQuery();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string notification = reader["notification_string"].ToString(); 
                        notifications.Push(notification);
                    }                 
                
                   reader.Close();
                }                                    
                con.Close();

            return notifications;    
        }

        public static void setNotification(int job_id,string rId, string fId, string notification, string isConORpay)
        {
            DateTime date = DateTime.Now;

            SqlCommand cmd = new SqlCommand("INSERT INTO Notification (notification_string, job_id, r_id, f_id, is_seen, is_con ,is_pay, date) VALUES (@notification_string,@job_id, @r_id, @f_id, @is_seen,@is_con,@is_pay,@date)", con);

            cmd.Parameters.AddWithValue("@notification_string", notification);
            cmd.Parameters.AddWithValue("@job_id",job_id);
            cmd.Parameters.AddWithValue("@r_id", rId);
            cmd.Parameters.AddWithValue("@f_id", fId);
            cmd.Parameters.AddWithValue("@is_seen","No");
            cmd.Parameters.AddWithValue("@date", date.ToShortDateString());

            if (isConORpay == "Confirm")
            {
                cmd.Parameters.AddWithValue("@is_con","Yes");
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


        public static int notificationCount(string value)
        {
            int fnotCount = 0;

            con.Open();

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Notification Where f_id=@f_id AND is_seen=@is_seen", con);
            command.Parameters.AddWithValue("@f_id", value);
            command.Parameters.AddWithValue("@is_seen", "No");

            command.ExecuteNonQuery();

            object result1 = command.ExecuteScalar();

            if (result1 != DBNull.Value)
                fnotCount = Convert.ToInt32(result1);
   

           con.Close();

            return fnotCount;
        }


        public static Stack<string> getFinancialHistory(string value)
        {
            Stack<string> financialNotifications = new Stack<string>();

            con.Open();

            SqlCommand command = new SqlCommand("SELECT notification_string,date FROM Notification Where f_id=@f_id AND is_pay=@is_pay", con);
            command.Parameters.AddWithValue("@f_id", value);
            command.Parameters.AddWithValue("@is_pay", "Yes");

            command.ExecuteNonQuery();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string financialNotification = reader["notification_string"].ToString();
                    string date = reader["date"].ToString();

                    int stringLength = financialNotification.Length;                 
                 
                    for(int i=stringLength;i<=35;i++)
                       financialNotification += "  ";
                 
                    string space = new string(' ',25);
                  
                    financialNotifications.Push(financialNotification+space+date);
                }
                reader.Close();
            }
            con.Close();
            return financialNotifications;
        }


        public static Stack<string> getAllNotification(string value)
        {
            Stack<string> notifications = new Stack<string>();

            con.Open();

            SqlCommand command = new SqlCommand("SELECT notification_string,date FROM Notification Where f_id=@f_id", con);
            command.Parameters.AddWithValue("@f_id", value);

            command.ExecuteNonQuery();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string notification = reader["notification_string"].ToString();
                    string date = reader["date"].ToString();

                    if (notification.Contains("Pay"))
                    {
                        int stringLength = notification.Length;

                        for (int i = stringLength; i <= 35; i++)
                            notification += "  ";

                        string space = new string(' ',25);

                        notifications.Push(notification + space + date);
                    }
                    if (notification.Contains("Confirm"))
                    {                     
                        int stringLength = notification.Length;

                        for (int i = stringLength; i < 35; i++)     
                                notification += "  ";

                        string space = new string(' ',25);

                        notifications.Push(notification + space + date);
                    }
                        
                }

                reader.Close();
            }
            con.Close();

            return notifications;
        }

    }
}
