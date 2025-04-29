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
    public partial class AddScheduleForm : Form
    {
        string constr = "Data source=orcl;User Id=scott;Password=tiger;";

        public AddScheduleForm()
        {
            InitializeComponent();
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constr);

            try
            {
                // First, check if the movie exists
                string checkMovieCmd = "SELECT COUNT(1) FROM MOVIE WHERE MOVIEID = :movieId";
                conn.Open();
                OracleCommand checkCmd = new OracleCommand(checkMovieCmd, conn);
                checkCmd.Parameters.Add("movieId", Convert.ToInt32(txtMovieId.Text));

                int movieExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (movieExists == 0)
                {
                    MessageBox.Show("Error: Movie ID does not exist in the database.");
                    return;
                }

                // Get the next schedule ID first
                string getNextIdCmd = "SELECT NVL(MAX(SCHEDULE_ID), 0) + 1 FROM MOVIE_SCHEDULE";
                OracleCommand idCmd = new OracleCommand(getNextIdCmd, conn);
                int nextId = Convert.ToInt32(idCmd.ExecuteScalar());

                // Then insert with all parameters
                string insertCmd = @"INSERT INTO MOVIE_SCHEDULE 
                            (SCHEDULE_ID, MOVIEID, SCREEN_DATE, START_TIME, END_TIME)
                            VALUES 
                            (:scheduleId, :movieId, :screenDate, :startTime, :endTime)";

                OracleCommand cmd = new OracleCommand(insertCmd, conn);
                cmd.Parameters.Add("scheduleId", nextId);
                cmd.Parameters.Add("movieId", Convert.ToInt32(txtMovieId.Text));
                cmd.Parameters.Add("screenDate", dtpScreenDate.Value.Date);
                cmd.Parameters.Add("startTime", dtpStartTime.Value);
                cmd.Parameters.Add("endTime", dtpEndTime.Value);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Schedule Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                // Consider logging the full error details
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void Back_to_Admin_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
