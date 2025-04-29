using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SW_Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
        }

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                conn.Open();
                string email = email_tb.Text;
                string password = password_tb.Text;
                string username = username_tb.Text;
                string phone = phone_tb.Text;
                string ageText = age_tb.Text;

                if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(phone) ||
                    string.IsNullOrWhiteSpace(ageText))
                {
                    conn.Close();
                    return;
                }

                if (!CheckUserInfo.Validate_Email(email))
                {
                    conn.Close();

                    return;
                }

                if (CheckUserInfo.Email_in_use(email, conn))
                {
                    conn.Close();

                    return;
                }



                if (!CheckUserInfo.Validate_Password(password))
                {
                    MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, digit, and special character.");
                    conn.Close();
                    return;
                }

                if (!int.TryParse(ageText, out int age))
                {
                    MessageBox.Show("Age must be a valid number.");
                    conn.Close();
                    return;
                }
                else if (CheckUserInfo.Validate_Age(ageText) == -1)
                {
                    conn.Close();
                    return;
                }

                if (!CheckUserInfo.Validate_Phone_Number(phone))
                {
                    conn.Close();
                    return;
                }



                // Insert the new user
                OracleCommand insertCmd = new OracleCommand("INSERT INTO Users (UserID, Email, Password, Username, PhoneNumber, Age, ISADMIN) " +
                                                            "VALUES (user_seq.NEXTVAL, :email, :password, :username, :phone, :age, 0)", conn);

                insertCmd.Parameters.Add("email", email);
                insertCmd.Parameters.Add("password", password);
                insertCmd.Parameters.Add("username", username);
                insertCmd.Parameters.Add("phone", phone);
                insertCmd.Parameters.Add("age", age);

                int rowsInserted = insertCmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                {
                    MessageBox.Show("Registration successful!");
                    LoginPage loginPage = new LoginPage();
                    loginPage.Show();
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                conn.Close();
                this.Close();

            }
        }

        private void Go_to_Login_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }

}
