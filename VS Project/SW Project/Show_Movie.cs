using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        int selectedScheduleId = -1;
        int seatsNum = 0;
        decimal ticketCost;
        public Show_Movie(int movieID)
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            this.movieID = movieID;
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            // Validate input first
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a show time.");
                return;
            }

            int countRequired = (int)tickets_num_up_down.Value;

            if (countRequired <= 0)
            {
                MessageBox.Show("Please select at least one ticket.");
                return;
            }

            if (countRequired > seatsNum)
            {
                MessageBox.Show($"Not enough available seats. Only {seatsNum} seats remaining.");
                return;
            }

            // Ask for user confirmation
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to book {countRequired} tickets for this show?",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                // Update available seats in MOVIE_SCHEDULE
                string updateSeatsSql = @"
            UPDATE MOVIE_SCHEDULE 
            SET SEATS_NUM = SEATS_NUM - :countRequired 
            WHERE SCHEDULE_ID = :scheduleId";
                conn.Open();
                using (OracleCommand updateCmd = new OracleCommand(updateSeatsSql, conn))
                {
                    updateCmd.Parameters.Add("countRequired", OracleDbType.Int32).Value = countRequired;
                    updateCmd.Parameters.Add("scheduleId", OracleDbType.Int32).Value = selectedScheduleId;

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Failed to update seats. Show schedule not found.");
                        return;
                    }
                }

                // Insert new booking record
                string insertBookingSql = @"
            INSERT INTO Booking (
                BookingID, 
                UserID, 
                MovieID, 
                Quantity, 
                TicketPrice
            ) VALUES (
                booking_seq.NEXTVAL,
                :userId, 
                :movieId, 
                :quantity, 
                :ticketPrice
            )";

                using (OracleCommand insertCmd = new OracleCommand(insertBookingSql, conn))
                {
                    insertCmd.Parameters.Add("userId", OracleDbType.Int32).Value = CurrUser.UserId;
                    insertCmd.Parameters.Add("movieId", OracleDbType.Int32).Value = movieID;
                    insertCmd.Parameters.Add("quantity", OracleDbType.Int32).Value = countRequired;
                    insertCmd.Parameters.Add("ticketPrice", OracleDbType.Decimal).Value = ticketCost;

                    insertCmd.ExecuteNonQuery();
                }

                // Update local seats count
                seatsNum -= countRequired;
                seatsAvailable.Text = "Tickets Available: " + seatsNum.ToString();
                tickets_num_up_down.Value = 1;
                tickets_num_up_down.Maximum = seatsNum;
                MessageBox.Show($"Successfully booked {countRequired} tickets!");


            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing booking: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Show_Movie_Load(object sender, EventArgs e)
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
                        ticketCost = reader.GetDecimal(5);
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
            finally
            {
                conn.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Parse the selected show time
            DateTime parsedStartTime;
            try
            {
                string selectedShow = comboBox1.SelectedItem.ToString();
                string[] parts = selectedShow.Split(new[] { " - " }, StringSplitOptions.None);

                // Extract just the date-time part before the first " - "
                string dateTimePart = parts[0].Trim();
                parsedStartTime = DateTime.ParseExact(dateTimePart, "yyyy-MM-dd | HH:mm", CultureInfo.InvariantCulture);

                // Oracle command
                string oracleCmd = "SELECT SCHEDULE_ID, SEATS_NUM FROM MOVIE_SCHEDULE " +
                                  "WHERE START_TIME = TO_TIMESTAMP(:startTime, 'YYYY-MM-DD HH24:MI:SS')";

                conn.Open();
                // Assuming you have an OracleConnection object named oracleConnection
                using (OracleCommand command = new OracleCommand(oracleCmd, conn))
                {
                    command.Parameters.Add("startTime", OracleDbType.Varchar2).Value = parsedStartTime.ToString("yyyy-MM-dd HH:mm:ss");

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            selectedScheduleId = Convert.ToInt32(reader.GetValue(0));
                            seatsNum =Convert.ToInt32(reader.GetValue(1));
                            seatsAvailable.Text = "Tickets Available: " + seatsNum.ToString();
                            tickets_num_up_down.Value = 1;
                            tickets_num_up_down.Maximum = seatsNum;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Invalid show time format: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Search_Movie search_Movie = new Search_Movie();
            search_Movie.Show();
            this.Close();
        }

        
    }
}