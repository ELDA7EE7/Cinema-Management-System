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
        public Manage_User()
        {
            InitializeComponent();
        }

        private void Mange_account_Load(object sender, EventArgs e)
        {
            //higit add .
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool data_changed = false;

            OracleCommand command = new OracleCommand();
            command.Connection = conn;

            command.CommandText = "";

            if (textBox1.Text.ToString() != "")//Email
            {
                string email = textBox1.Text.ToString();
                var addr = new MailAddress(email);

                if (addr.Address != email)
                {
                    MessageBox.Show("Not Valid Email");
                }
                else
                {
                    //Code (only need to check if is uniqe)
                }
            }
            if (textBox2.Text.ToString() != "")//Password
            {

            }
            if (textBox3.Text.ToString() != "")//Age
            {
                bool stop = false;
                string age = textBox3.Text.ToString();
                int result = 0;

                if (check_only_numbers(age) == false)
                    stop = true;
                else
                {
                    foreach (char c in age)
                        result = result * 10 + (c - '0');
                }

                if (!stop && result > 100)
                    MessageBox.Show("Not Valid Age");
                else
                {
                    //Code Update
                }
            }
            if (textBox4.Text.ToString() != "")//Phone Number
            {
                bool stop = false;

                string num = textBox4.Text.ToString();
                int size = num.Length;

                if (check_only_numbers(num) == false)
                    stop = true;

                string valid = "0125";
                if (!stop && size != 11 || num[0] != '0' || num[1] != '1' || !valid.Contains(num[2]))
                {
                    MessageBox.Show("Not Valid Phone Number");
                    stop = true;
                }

                if (!stop)
                {
                    //Code (only need to check if is uniqe)
                }
            }
            if (textBox5.Text.ToString() != "")//Username
            {
                //Code (only need to check if is uniqe)
            }
        }
        private static bool check_only_numbers(string s)
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
    }
}