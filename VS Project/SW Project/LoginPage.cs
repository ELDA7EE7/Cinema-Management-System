//using Oracle.DataAccess.Client;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
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
    public partial class LoginPage : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data source=orcl;User Id=scott;Password=tiger;";
            string cmdstr = @"select UserID,isAdmin
                              from Users
                              where Username=:un and Password=:pass";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr,constr);
            adapter.SelectCommand.Parameters.Add("un", usernameText.Text);
            adapter.SelectCommand.Parameters.Add("pass", PasswordText.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                // User found
                int userId = Convert.ToInt32(ds.Tables[0].Rows[0]["UserID"]);
                bool isAdmin = ds.Tables[0].Rows[0]["isAdmin"].ToString() == "1";

                CurrUser.LogIn(usernameText.Text, userId, isAdmin);

                if (isAdmin)
                { //goto admin homepage
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();

                }
                else
                { //user homepage
                    Manage_User manage_User = new Manage_User();
                    manage_User.Show();
                }
                CurrUser.LogIn(usernameText.Text,userId, isAdmin);
                this.Close();
            }
            else
            {
                // No user found
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Go_to_Register_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }
    }
}
