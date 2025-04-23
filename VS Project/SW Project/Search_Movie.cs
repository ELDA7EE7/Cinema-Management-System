using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace SW_Project
{
    public partial class Search_Movie : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Search_Movie()
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Search_Movie_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.ColumnCount - 1 && e.RowIndex >= 0)
            {
                int movieId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                // Movie_form movieDetailsForm = new Movie_form(movieId);
                // movieDetailsForm.Show();
                // this.Hide();
                //conn.Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string search_text = search_txt.Text;
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "SearchMovies";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_search_term", search_text);
                command.Parameters.Add("p_results", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    int movie_id = Convert.ToInt32(reader[0]);
                    string name = Convert.ToString(reader[1]);
                    int rating = Convert.ToInt32(reader[2]);
                    int ticket_cost = Convert.ToInt32(reader[3]);

                    dataGridView1.Rows.Add(movie_id, name, rating, ticket_cost, "View");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_User anotherForm = new Manage_User();
            anotherForm.Show();
            this.Hide();
            conn.Close();
        }
    }
}