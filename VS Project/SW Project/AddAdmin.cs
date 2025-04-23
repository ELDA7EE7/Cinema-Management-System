using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_Project
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }
        private bool All_filled()
        {
            return username_tb.Text!="" && password_tb.Text!=""
                && email_tb.Text!="" && phone_tb.Text!=""
                && age_tb.Text!="";
        }
        private void add_button_Click(object sender, EventArgs e)
        {
            OracleConnection conn;
            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
            if (All_filled())
            {
                if(!CheckUserInfo.Validate_Password(password_tb.Text))
                {
                    MessageBox.Show("Password is not valid. It must be at least" +
                        " 8 characters long, has one upper case letter, one lower " +
                        "case letter, one number and one symbol");
                    return;
                }
                if (CheckUserInfo.Validate_Age(age_tb.Text) == -1)
                {
                    return;
                }
                conn = new OracleConnection(ordb);
                conn.Open();
                if(!CheckUserInfo.Validate_Email(email_tb.Text) || 
                    CheckUserInfo.Email_in_use(email_tb.Text,conn)
                    || CheckUserInfo.Username_in_use(username_tb.Text,conn)) {
                    conn.Close();
                    return;
                }
                
                if(!CheckUserInfo.Validate_Phone_Number(phone_tb.Text) ||
                    CheckUserInfo.Phone_in_use(phone_tb.Text,conn))
                {
                    conn.Close();
                    return;
                }
                DialogResult result = MessageBox.Show(
                        $"Are you sure you want to Add this user as Admin?",
                        "Confirm Registering",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int isAdmin = 1;
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "INSERT INTO Users (UserID, Email, Password, Username, PhoneNumber, Age, isAdmin) " +
                      "SELECT NVL(MAX(UserID), 0) + 1, :email, :password, :username, :phone, :age, :isAdmin FROM Users";

                    // Add parameters to prevent SQL injection
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email_tb.Text;
                    cmd.Parameters.Add(":password", OracleDbType.Varchar2).Value = password_tb.Text;
                    cmd.Parameters.Add(":username", OracleDbType.Varchar2).Value = username_tb.Text;
                    cmd.Parameters.Add(":phone", OracleDbType.Varchar2).Value = phone_tb.Text;
                    cmd.Parameters.Add(":age", OracleDbType.Int32).Value = int.Parse(age_tb.Text);
                    cmd.Parameters.Add(":isAdmin", OracleDbType.Int32).Value = isAdmin;

                    // Execute the command
                    int r = cmd.ExecuteNonQuery();
                    if (r == 0)
                    {
                        MessageBox.Show("Error Occured Didnt Add");
                    }
                    else
                    {
                        MessageBox.Show("Admin Added Successfully");
                    }
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the Data");
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
