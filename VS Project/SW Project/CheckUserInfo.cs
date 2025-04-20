using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
namespace SW_Project
{
    internal class CheckUserInfo
    {
        //put any check function here
        public static bool Email_in_use(string email, OracleConnection conn)
        {
            int count = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(EMAIL) FROM USERS WHERE EMAIL=:em";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("em", email);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Email is already in use");
                return true;
            }
            return false;
        }
        public static bool Username_in_use(string username, OracleConnection conn)
        {
            int count = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(USERNAME) FROM USERS WHERE USERNAME=:em";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("em", username);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Username is already in use");
                return true;
            }
            return false;
        }
        public static bool Phone_in_use(string phone, OracleConnection conn)
        {
            int count = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT COUNT(PHONENUMBER) FROM USERS WHERE PHONENUMBER=:em";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("em", phone);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("phone number is already in use");
                return true;
            }
            return false;
        }
        public static bool check_only_numbers(string s)
        {
            int size = s.Length;
            for (int i = 0; i < size; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    MessageBox.Show("Must Only Contain Number");
                    return false;
                }
            }
            return true;
        }
        public static bool Validate_Email(string email) 
        {
            try
            {
                var addr = new MailAddress(email);

                if(addr.Address != email)
                {
                    MessageBox.Show("Not Valid Email");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Not Valid Email");
                return false;
            }
                return true;
        }
        public static bool Validate_Phone_Number(string number)
        {
            int size = number.Length;
            string valid = "0125";
            if (!check_only_numbers(number) || size != 11 || number[0] != '0' || number[1] != '1' || !valid.Contains(number[2]))
            {
                MessageBox.Show("Not Valid Phone Number");
                return false;
            }
            return true;
        }
        //Returns (-1) If Not Valid
        public static int Validate_Age(string age)
        {
            int result = 0;

            if (!check_only_numbers(age))
                return -1;

            foreach (char c in age)
                result = result * 10 + (c - '0');

            if(result > 100)
            {
                MessageBox.Show("Not A Valid Age");
                return -1;
            }

            return result;
        }
        public static bool Validate_Password (string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.Any(ch => "!@#$%^&*()_+-=[]{}|;:'\",.<>/?".Contains(ch));
        }
    }
}
