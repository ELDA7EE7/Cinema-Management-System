using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SW_Project
{
    internal class CheckUserInfo
    {
        //put any check function here
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
            var addr = new MailAddress(email);
            if(addr.Address != email)
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
            if (!CheckUserInfo.check_only_numbers(number) || size != 11 || number[0] != '0' || number[1] != '1' || !valid.Contains(number[2]))
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

            if (!CheckUserInfo.check_only_numbers(age))
                return -1;

            foreach (char c in age)
                result = result * 10 + (c - '0');

            if(result > 100)
            {
                MessageBox.Show("Not Valid Age");
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
