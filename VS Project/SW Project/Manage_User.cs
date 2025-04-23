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
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        //int cur_user_id = CurrUser.UserId;
        int cur_user_id = 3;

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
            List<OracleCommand>commands = new List<OracleCommand>();
            bool data_changed = false;
            
            conn = new OracleConnection(ordb);
            conn.Open();


            //Email
            if (textBox1.Text.ToString() != "") 
            {
                //Code (only need to check if is uniqe) Then Update
                if (CheckUserInfo.Validate_Email(textBox1.Text.ToString()) &&
                    !CheckUserInfo.Email_in_use(textBox1.Text.ToString(), conn))
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE USERS SET EMAIL =:email WHERE USERID =:userId";
                    command.Parameters.Add("email", OracleDbType.Varchar2).Value = textBox1.Text.ToString();
                    command.Parameters.Add("userId", OracleDbType.Int32).Value = cur_user_id;
                    data_changed = true;

                    commands.Add(command);
                }
            }
            //Password
            if (textBox2.Text.ToString() != "")
            {
                //Code (Update)
                if (CheckUserInfo.Validate_Password(textBox2.Text.ToString()))
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Users SET Password = :password WHERE UserID = :userId";
                    command.Parameters.Add(":password", OracleDbType.Varchar2).Value = textBox2.Text.ToString();
                    command.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;
                    data_changed = true;
                    commands.Add(command);
                }
            }
            //Age
            if (textBox3.Text.ToString() != "")
            {
                //Code (Update)
                int age = CheckUserInfo.Validate_Age(textBox3.Text.ToString());
                if (age != -1)
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Users SET Age = :age WHERE UserID = :userId";
                    command.Parameters.Add(":age", OracleDbType.Int32).Value = int.Parse(textBox3.Text.ToString());
                    command.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;
                    data_changed = true;
                    commands.Add(command);
                }
            }
            //Phone Number
            if (textBox4.Text.ToString() != "")
            {
                //Code (only need to check if is uniqe)
                if (CheckUserInfo.Validate_Phone_Number(textBox4.Text.ToString()) &&
                    !CheckUserInfo.Phone_in_use(textBox4.Text.ToString(),conn))
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Users SET PhoneNumber = :phone WHERE UserID = :userId";
                    command.Parameters.Add(":phone", OracleDbType.Varchar2).Value = textBox4.Text.ToString();
                    command.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;
                    data_changed = true;
                    commands.Add(command);
                }
            }
            //UserName
            if (textBox5.Text.ToString() != "")
            {
                //Code (only need to check if is uniqe)
                if(!CheckUserInfo.Username_in_use(textBox5.Text.ToString(),conn))
                {
                    OracleCommand command = new OracleCommand();
                    command.Connection = conn;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Users SET Username = :user WHERE UserID = :userId";
                    command.Parameters.Add(":user", OracleDbType.Varchar2).Value = textBox5.Text.ToString();
                    command.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;
                    data_changed = true;
                    commands.Add(command);
                }
            }
            foreach (var cmd in commands)
            {
                MessageBox.Show(cmd.CommandText);
                int r = cmd.ExecuteNonQuery();

                if (r != 1)
                {
                    data_changed = false;
                    MessageBox.Show("Error Occured Didnt Update");
                }
            }

            conn.Close();
            if(data_changed)
            {
                MessageBox.Show("Data Updated");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}