using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SW_Project
{
    public partial class Manage_User : Form
    {
        //test
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int cur_user_id = CurrUser.UserId;

        string user_name, user_email, user_password, user_phone, user_age;

        private void View_history_Button_Click(object sender, EventArgs e)
        {
            view_history view_History = new view_history();
            view_History.Show();
            this.Close();
        }

        private void SearchMoviesButton_Click(object sender, EventArgs e)
        {
            Search_Movie search_Movie = new Search_Movie();
            search_Movie.Show();
            this.Close();
        }

        private void Manage_User_Load(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                string query = "SELECT Username, Email, Password, PhoneNumber, Age FROM Users WHERE UserId = :userId";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;

                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    user_name = username.Text = reader["Username"].ToString();
                    user_email = email.Text = reader["Email"].ToString();
                    user_password = password.Text = reader["Password"].ToString();
                    user_phone = phonenumber.Text = reader["PhoneNumber"].ToString();
                    user_age = age.Text = reader["Age"].ToString();
                }
            }
        }

        public Manage_User()
        {
            conn = new OracleConnection(ordb);
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //if((username.Text.ToString() != user_name && !CheckUserInfo.Username_in_use(username.Text.ToString(),conn)) && 
            //    (email.Text.ToString() != user_email && !CheckUserInfo.Email_in_use(email.Text.ToString(),conn) && CheckUserInfo.Validate_Email(email.Text.ToString())) &&
            //    (phonenumber.Text.ToString() != user_phone && !CheckUserInfo.Phone_in_use(phonenumber.Text.ToString(),conn) && CheckUserInfo.Validate_Phone_Number(phonenumber.Text.ToString())) && 
            //    CheckUserInfo.Validate_Age(age.Text.ToString()) != -1 && CheckUserInfo.Validate_Password(password.Text.ToString()))
            conn.Open();
            bool valid = true;
            
            if (username.Text != user_name)
                valid &= !CheckUserInfo.Username_in_use(username.Text, conn);

            if (email.Text != user_email)
                valid &= !CheckUserInfo.Email_in_use(email.Text, conn) && CheckUserInfo.Validate_Email(email.Text);

            if (phonenumber.Text != user_phone)
                valid &= !CheckUserInfo.Phone_in_use(phonenumber.Text, conn) && CheckUserInfo.Validate_Phone_Number(phonenumber.Text);

            valid &= CheckUserInfo.Validate_Age(age.Text) != -1;
            valid &= CheckUserInfo.Validate_Password(password.Text);
            conn.Close();
            if (valid)
            {
                using (OracleConnection conn = new OracleConnection(ordb))
                {
                    string query = @"UPDATE Users 
                             SET Username = :username, Email = :email, Password = :password, 
                                 PhoneNumber = :phone, Age = :age 
                             WHERE UserId = :userId";
                    conn.Open();
                    OracleCommand cmd = new OracleCommand(query, conn);
                    cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username.Text.ToString();
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email.Text.ToString();
                    cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = password.Text.ToString();
                    cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phonenumber.Text.ToString();
                    cmd.Parameters.Add(":age", OracleDbType.Int32).Value = int.Parse(age.Text);
                    cmd.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;

                    int rowsUpdated = cmd.ExecuteNonQuery();
                    if (rowsUpdated > 0)
                        MessageBox.Show("User info updated successfully.");
                    else
                        MessageBox.Show("No changes were made.");
                }
                Manage_User_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }
    }
}