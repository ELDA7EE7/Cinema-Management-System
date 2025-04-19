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
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool data_changed = false;

            OracleCommand command = new OracleCommand();
            command.Connection = conn;

            command.CommandText = "";

            //Email
            if (textBox1.Text.ToString() != "")
            {
                if (CheckUserInfo.Validate_Email(textBox1.Text.ToString()))
                {
                    //Code (only need to check if is uniqe)
                }
            }
            //Password
            if (textBox2.Text.ToString() != "")
            {
                if(CheckUserInfo.Validate_Password(textBox2.Text.ToString()))
                {
                    //Code (Update)
                }
            }
            //Age
            if (textBox3.Text.ToString() != "")
            {
                int age = CheckUserInfo.Validate_Age(textBox3.Text.ToString());
                if (age != -1)
                {
                    //Code (Update)
                }
            }
            //Phone Number
            if (textBox4.Text.ToString() != "")
            {
                if(CheckUserInfo.Validate_Phone_Number(textBox4.Text.ToString()))
                {
                    //Code (only need to check if is uniqe)
                }
            }
            //UserName
            if (textBox5.Text.ToString() != "")
            {
                //Code (only need to check if is uniqe)
            }
        }
    }
}