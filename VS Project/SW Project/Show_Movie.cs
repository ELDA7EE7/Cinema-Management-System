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
    public partial class Show_Movie : Form
    {
        int movieID;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public Show_Movie(int movieID)
        {
            InitializeComponent();
            conn = new OracleConnection(ordb);
            conn.Open();
            this.movieID = movieID;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                OracleCommand command = new OracleCommand();
                command.Connection = conn;
                command.CommandText = "GETMOVIE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("p_MovieID", this.movieID);
                command.Parameters.Add("p_Result", OracleDbType.RefCursor, ParameterDirection.Output);

                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime screenDate = reader.GetDateTime(0);
                    TimeSpan startTime = reader.GetTimeSpan(1);
                    TimeSpan endTime = reader.GetTimeSpan(2);

                    string display = screenDate.ToString("yyyy-MM-dd")
                        + " | " + startTime.ToString(@"hh\:mm")
                        + " - " + endTime.ToString(@"hh\:mm");
                    comboBox1.Items.Add(display);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedShow = comboBox1.SelectedItem.ToString();

            string[] parts = selectedShow.Split(' ');
            DateTime screenDate = DateTime.Parse(parts[0]);
            TimeSpan startTime = TimeSpan.Parse(parts[1]);

            int countRequired = int.Parse(textBox1.Text);

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

                MessageBox.Show("Booking successful!");
            }
            else
            {
                string msg = "Not enough number of tickets, max is " + availableTickets.ToString();
                MessageBox.Show(msg);
            }
        }
       
    }
}
