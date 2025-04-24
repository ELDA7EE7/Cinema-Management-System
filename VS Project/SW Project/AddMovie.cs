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
    public partial class AddMovie : Form
    {

        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            
        }
        private bool Is_full()
        {
            return title_tb.Text.Length > 0 && director_tb.Text.Length > 0 &&
                   cost_tb.Text.Length > 0 && duration_tb.Text.Length > 0 &&
                   dateTime.Text.Length > 0 && genre_tb.Text.Length > 0 &&
                   description_tb.Text.Length > 0;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Is_full())
            {
                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to add this movie?",
                                                    "Confirmation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string title = title_tb.Text;
                        string director = director_tb.Text;
                        string genre = genre_tb.Text;
                        decimal cost = Convert.ToDecimal(cost_tb.Text);
                        int duration = Convert.ToInt32(duration_tb.Text);
                        DateTime release_date = dateTime.Value;
                        string description = description_tb.Text;
                        decimal rating = Convert.ToDecimal(rating_num.Value);

                        // Generate a new MovieID (you might want to use a sequence in Oracle)
                        int movieId = GetNextMovieId();

                        // Insert into database
                        InsertMovie(movieId, title, release_date, description, duration, rating, cost, director, genre);

                        MessageBox.Show("Movie added successfully!");
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the required fields", "Incomplete Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GetNextMovieId()
        {
            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
            string sql = "SELECT NVL(MAX(MovieID), 0) + 1 FROM Movie";

            using (OracleConnection connection = new OracleConnection(ordb))
            {
                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    connection.Open();
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void InsertMovie(int movieId, string title, DateTime releaseDate, string description,
                                int duration, decimal rating, decimal ticketCost,
                                string director, string genre)
        {
            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";

            string sql = @"INSERT INTO Movie (MovieID, Title, ReleaseDate, Description, 
                    Duration, Rating, TicketCost, Director, Genre)
                  VALUES (:MovieID, :Title, :ReleaseDate, :Description, 
                    :Duration, :Rating, :TicketCost, :Director, :Genre)";

            using (OracleConnection connection = new OracleConnection(ordb))
            {
                using (OracleCommand command = new OracleCommand(sql, connection))
                {
                    command.Parameters.Add(":MovieID", OracleDbType.Int32).Value = movieId;
                    command.Parameters.Add(":Title", OracleDbType.Varchar2).Value = title;
                    command.Parameters.Add(":ReleaseDate", OracleDbType.Date).Value = releaseDate;
                    command.Parameters.Add(":Description", OracleDbType.Clob).Value = description;
                    command.Parameters.Add(":Duration", OracleDbType.Int32).Value = duration;
                    command.Parameters.Add(":Rating", OracleDbType.Decimal).Value = rating;
                    command.Parameters.Add(":TicketCost", OracleDbType.Decimal).Value = ticketCost;
                    command.Parameters.Add(":Director", OracleDbType.Varchar2).Value = director;
                    command.Parameters.Add(":Genre", OracleDbType.Varchar2).Value = genre;

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void ClearForm()
        {
            // Clear all input fields after successful insertion
            title_tb.Text = "";
            director_tb.Text = "";
            genre_tb.Text = "";
            cost_tb.Text = "";
            duration_tb.Text = "";
            dateTime.Value = DateTime.Now;
            description_tb.Text = "";
            rating_num.Value = 0;
        }

        private void Back_to_AdminMenu(object sender, EventArgs e)
        {

        }
    }
}
