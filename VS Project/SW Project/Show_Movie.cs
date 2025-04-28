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
    public partial class Show_Movie : Form
    {
        int movieID;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Show_Movie(int movieID)
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            this.movieID = movieID;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            string selectedShow = comboBox1.SelectedItem.ToString();

            string[] parts = selectedShow.Split(' ');
            DateTime screenDate = DateTime.Parse(parts[0]);
            TimeSpan startTime = TimeSpan.Parse(parts[1]);

            int countRequired = Convert.ToInt32(tickets_num_up_down.Value);

            OracleCommand checkCommand = new OracleCommand();
            checkCommand.Connection = conn;
            checkCommand.CommandText = "SELECT available_tickets FROM movie_schedule WHERE movieid = :movieID AND screen_date = :sdate AND start_time = :stime";
            checkCommand.Parameters.Add("movieID", movieID);
            checkCommand.Parameters.Add("sdate", screenDate);
            checkCommand.Parameters.Add("stime", startTime);

            int availableTickets = Convert.ToInt32(checkCommand.ExecuteScalar());

            if (countRequired <= availableTickets)
            {
                OracleCommand insertCommand = new OracleCommand();
                insertCommand.Connection = conn;
                insertCommand.CommandText = "INSERT INTO Booking (booking_id, movieid, screen_date, start_time, tickets_booked) VALUES (booking_seq.NEXTVAL, :movieID, :sdate, :stime, :count)";
                insertCommand.Parameters.Add("movieID", movieID);
                insertCommand.Parameters.Add("sdate", screenDate);
                insertCommand.Parameters.Add("stime", startTime);
                insertCommand.Parameters.Add("count", countRequired);
                insertCommand.ExecuteNonQuery();

                OracleCommand updateCommand = new OracleCommand();
                updateCommand.Connection = conn;
                updateCommand.CommandText = "UPDATE movie_schedule SET available_tickets = available_tickets - :count WHERE movieid = :movieID AND screen_date = :sdate AND start_time = :stime";
                updateCommand.Parameters.Add("count", countRequired);
                updateCommand.Parameters.Add("movieID", movieID);
                updateCommand.Parameters.Add("sdate", screenDate);
                updateCommand.Parameters.Add("stime", startTime);
                updateCommand.ExecuteNonQuery();
                Show_Movie_Load_1(sender, e);
                MessageBox.Show("Booking successful!");
            }
            else
            {
                string msg = "Not enough number of tickets, max is " + availableTickets.ToString();
                MessageBox.Show(msg);
            }
            conn.Close();
        }

        private void Show_Movie_Load_1(object sender, EventArgs e)
        {
            conn.Open();

            try
            {
                // First get the movie details
                OracleCommand command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "GETMOVIE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_MovieID", OracleDbType.Int32).Value = this.movieID;
                command.Parameters.Add("p_Result", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader reader = command.ExecuteReader();

                bool firstRow = true;
                while (reader.Read())
                {
                    // On first row, get movie details and display them
                    if (firstRow)
                    {
                        // Movie details (columns 0-8)
                        string title = reader.GetString(0);
                        DateTime releaseDate = reader.GetDateTime(1);
                        string description = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        int duration = 0;
                        try
                        {
                            duration = reader.GetInt32(3); // Try direct INT read
                        }
                        catch (InvalidCastException)
                        {
                            // If direct cast fails, try converting from other types
                            object durationValue = reader.GetValue(3);
                            duration = Convert.ToInt32(durationValue);
                        }
                        decimal rating = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4);
                        decimal ticketCost = reader.GetDecimal(5);
                        string director = reader.GetString(6);
                        string genre = reader.IsDBNull(7) ? "Unknown" : reader.GetString(7);

                        // Display movie info in your form controls
                        lblTitle.Text = title;
                        lblDirector.Text = "Director: " + director;
                        lblGenre.Text = "Genre: " + genre;
                        lblRating.Text = "Rating: " + rating.ToString("0.0");
                        lblDuration.Text = "Duration: " + duration + " mins";
                        lblPrice.Text = "Price: $" + ticketCost.ToString("0.00");
                        txtDescription.Text = description;

                        firstRow = false;
                    }

                    if (!reader.IsDBNull(8)) 
                    {
                        DateTime startTime = reader.GetDateTime(8);
                        int duration = 0;
                        // If direct cast fails, try converting from other types
                        object durationValue = reader.GetValue(3);
                        duration = Convert.ToInt32(durationValue);
                        
                        DateTime endTime = startTime.AddMinutes(duration);

                        string display = startTime.ToString("yyyy-MM-dd | HH:mm") +
                                        " - " + endTime.ToString("HH:mm");
                        comboBox1.Items.Add(display);
                    }
                    int seatsAv = Convert.ToInt32(reader.GetValue(9));
                    seatsAvailable.Text ="Seats Available: " + seatsAv.ToString();
                }

                reader.Close();

                if (comboBox1.Items.Count == 0)
                {
                    comboBox1.Items.Add("No schedules available");
                    comboBox1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Error loading movie data: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
    }
}