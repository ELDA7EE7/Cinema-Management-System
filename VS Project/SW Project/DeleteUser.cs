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
namespace SW_Project
{
    public partial class DeleteUser : Form
    {
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT USERID FROM USERS";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedItem);

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SearchUserById";//Procedure name 
            // Input parameter
            cmd.Parameters.Add("p_user_id", OracleDbType.Int32).Value = id;

            // Output parameters
            cmd.Parameters.Add("p_email", OracleDbType.Varchar2, 100).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_username", OracleDbType.Varchar2, 50).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_phone", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_age", OracleDbType.Int32).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("p_is_admin", OracleDbType.Int32).Direction = ParameterDirection.Output;
            
            cmd.ExecuteNonQuery();

            // Retrieve output values
            string email = cmd.Parameters["p_email"].Value.ToString();
            string username = cmd.Parameters["p_username"].Value.ToString();
            string phone = cmd.Parameters["p_phone"].Value.ToString();
            string age = cmd.Parameters["p_age"].Value.ToString();
            string isAdmin = cmd.Parameters["p_is_admin"].Value.ToString();

            email_tb.Text = email;
            username_tb.Text = username;
            phone_tb.Text = phone;
            age_tb.Text = age;
            IsAdmin_cb.Checked = isAdmin.Equals("1");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                try
                {
                    // Get the selected user ID
                    int userId = Convert.ToInt32(comboBox1.SelectedItem);

                    // Show confirmation dialog
                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete user with ID {userId}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // User confirmed - proceed with deletion
                        using (OracleCommand cmd = new OracleCommand())
                        {
                            cmd.Connection = conn;
                            cmd.CommandText = "DELETE FROM Users WHERE UserID = :user_id";
                            cmd.Parameters.Add("user_id", OracleDbType.Int32).Value = userId;
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                                // Clear EveryThing
                                comboBox1.Items.Remove(comboBox1.SelectedItem);
                                comboBox1.SelectedItem = null;
                                IsAdmin_cb.Checked = false;
                                username_tb.Clear();
                                phone_tb.Clear();
                                age_tb.Clear();
                                email_tb.Clear();

                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
