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
        }

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn = new OracleConnection(ordb);
        conn.Open();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            string username = textBox3.Text.Trim();
            string phone = textBox4.Text.Trim();
            string ageText = textBox5.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(ageText))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!CheckUserInfo.Validate_Email(email,conn))
            {
                MessageBox.Show("Please enter a valid email.");
                return;
            }
            else
            {
                if (CheckUserInfo.Email_in_use(email, conn))
                {
                    MessageBox.Show("Please enter a different email.");
                    return;
                }
                else
                {  }

            }
            if (!CheckUserInfo.Validate_Password(password, conn))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, digit, and special character.");
                return;
            }

            if (!int.TryParse(ageText, out int age))
            {
                MessageBox.Show("Age must be a valid number.");
                return;
            }
            else
            {
                CheckUserInfo.Validate_Age(ageText);
            }

            if(!CheckUserInfo.Validate_Phone_Number(phone))
            {
                MessageBox.Show("Phone Number must be valid.");
                return;
            }

            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                conn.Open();

                // Insert the new user
                OracleCommand insertCmd = new OracleCommand("INSERT INTO Users (UserID, Email, Password, Username, PhoneNumber, Age) " +
                                                            "VALUES (user_seq.NEXTVAL, :email, :password, :username, :phone, :age)", conn);

                insertCmd.Parameters.Add("email", email);
                insertCmd.Parameters.Add("password", password);
                insertCmd.Parameters.Add("username", username);
                insertCmd.Parameters.Add("phone", phone);
                insertCmd.Parameters.Add("age", age);

                int rowsInserted = insertCmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                {
                    MessageBox.Show("Registration successful!");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please try again.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Register_Load(object sender, EventArgs e)
        {

        }
    }

}
