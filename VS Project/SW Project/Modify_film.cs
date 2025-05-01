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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SW_Project
{
    public partial class Modify_film : Form
    {
        public Modify_film()
        {
            InitializeComponent();
        }
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        private bool Is_full()
        {
            return title_tb.Text.Length > 0 && director_tb.Text.Length > 0 &&
                   cost_tb.Text.Length > 0 && duration_tb.Text.Length > 0 &&
                   dateTime.Text.Length > 0 && genre_tb.Text.Length > 0 &&
                   description_tb.Text.Length > 0;
        }
        private void id_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_cb.SelectedItem == null) return;

            try
            {
                // Get the selected MovieID from the combo box
                int selectedMovieId = Convert.ToInt32(id_cb.SelectedItem.ToString());

                // SQL query to get movie details
                string query = "SELECT Title, ReleaseDate, Description, Runtime, Rating, TicketCost, Director, Genre " +
                               "FROM Movie WHERE MovieID = :movieId";

                using (OracleConnection connection = new OracleConnection(ordb))
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":movieId", OracleDbType.Int32).Value = selectedMovieId;

                    connection.Open();
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate the form fields with data from the database
                            title_tb.Text = reader["Title"].ToString();
                            dateTime.Value = Convert.ToDateTime(reader["ReleaseDate"]);
                            description_tb.Text = reader["Description"].ToString();
                            duration_tb.Text = reader["Runtime"].ToString();
                            rating_num.Value = Convert.ToDecimal(reader["Rating"]);
                            cost_tb.Text = reader["TicketCost"].ToString();
                            director_tb.Text = reader["Director"].ToString();
                            genre_tb.Text = reader["Genre"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movie details: " + ex.Message);
            }
        }

        private void Modify_film_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT MOVIEID FROM MOVIE";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_cb.Items.Add(dr[0]);
            }
            dr.Close();
            conn.Close();
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            if (id_cb.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie to update.");
                return;
            }
            if (!Is_full())
            {
                MessageBox.Show("Please fill required data");
                return;
            }
            try
            {
                int movieId = Convert.ToInt32(id_cb.SelectedItem.ToString());

                using (OracleConnection connection = new OracleConnection(ordb))
                {
                    // Create DataAdapter with select command
                    string selectQuery = "SELECT * FROM Movie WHERE MovieID = :movieId";
                    OracleDataAdapter adapter = new OracleDataAdapter(selectQuery, connection);
                    adapter.SelectCommand.Parameters.Add(":movieId", OracleDbType.Int32).Value = movieId;

                    // Create CommandBuilder to generate update command
                    OracleCommandBuilder commandBuilder = new OracleCommandBuilder(adapter);

                    // Create and fill DataSet
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "Movie");

                    if (dataSet.Tables["Movie"].Rows.Count == 0)
                    {
                        MessageBox.Show("Movie not found.");
                        return;
                    }

                    // Get the row to update
                    DataRow row = dataSet.Tables["Movie"].Rows[0];

                    // Update the row with values from form controls
                    row["Title"] = title_tb.Text;
                    row["ReleaseDate"] = dateTime.Value;
                    row["Description"] = description_tb.Text;
                    row["Runtime"] = Convert.ToInt32(duration_tb.Text);
                    row["Rating"] = Convert.ToDecimal(rating_num.Value);
                    row["TicketCost"] = Convert.ToDecimal(cost_tb.Text);
                    row["Director"] = director_tb.Text;
                    row["Genre"] = genre_tb.Text;

                    // Update the database
                    adapter.Update(dataSet, "Movie");

                    MessageBox.Show("Movie updated successfully!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Duration, Rating, and Ticket Cost.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating movie: " + ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (id_cb.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            try
            {
                // Get confirmation from user
                DialogResult result = MessageBox.Show(
                    "This will delete ALL bookings for this movie. Continue?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return; // User cancelled the deletion
                }

                int movieId = Convert.ToInt32(id_cb.SelectedItem.ToString());

                using (OracleConnection connection = new OracleConnection(ordb))
                {
                    connection.Open();

                    // Start a transaction
                    using (OracleTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // First delete all bookings for this movie
                            string deleteBookingsQuery = "DELETE FROM Booking WHERE MovieID = :movieId";
                            using (OracleCommand deleteBookingsCommand = new OracleCommand(deleteBookingsQuery, connection))
                            {
                                deleteBookingsCommand.Transaction = transaction;
                                deleteBookingsCommand.Parameters.Add(":movieId", OracleDbType.Int32).Value = movieId;
                                int bookingsDeleted = deleteBookingsCommand.ExecuteNonQuery();
                                Console.WriteLine($"Deleted {bookingsDeleted} bookings");
                            }

                            // Then delete the movie
                            string deleteMovieQuery = "DELETE FROM Movie WHERE MovieID = :movieId";
                            using (OracleCommand deleteMovieCommand = new OracleCommand(deleteMovieQuery, connection))
                            {
                                deleteMovieCommand.Transaction = transaction;
                                deleteMovieCommand.Parameters.Add(":movieId", OracleDbType.Int32).Value = movieId;
                                int rowsAffected = deleteMovieCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit(); // Commit both operations
                                    MessageBox.Show("Movie and all associated bookings deleted successfully!");

                                    // Refresh the combo box
                                    id_cb.Items.Remove(id_cb.SelectedItem);

                                    // Clear all fields
                                    title_tb.Clear();
                                    dateTime.Value = DateTime.Now;
                                    description_tb.Clear();
                                    duration_tb.Clear();
                                    rating_num.Value = 0;
                                    cost_tb.Clear();
                                    director_tb.Clear();
                                    genre_tb.Clear();
                                }
                                else
                                {
                                    transaction.Rollback(); // No movie found, rollback bookings deletion
                                    MessageBox.Show("Movie not found. No changes were made.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Something went wrong, rollback everything
                            MessageBox.Show("Error during deletion: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
