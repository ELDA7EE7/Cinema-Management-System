﻿using System;
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
    public partial class UpdateDeleteScheduleForm : Form
    {
        string constr = "Data source=orcl;User Id=scott;Password=tiger;";

        public UpdateDeleteScheduleForm()
        {
            InitializeComponent();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(constr))
            {
                // Combine date from dtpScreenDate and time from dtpStartTime
                DateTime combinedDateTime = dtpScreenDate.Value.Date + dtpStartTime.Value.TimeOfDay;

                string updateCmd = @"UPDATE MOVIE_SCHEDULE 
                           SET MOVIEID = :movieId, 
                               START_TIME = :startTime,
                               SEATS_NUM = :seatsNum
                           WHERE SCHEDULE_ID = :schedId";

                OracleCommand cmd = new OracleCommand(updateCmd, conn);
                cmd.Parameters.Add("movieId", Convert.ToInt32(txtMovieId.Text));
                cmd.Parameters.Add("startTime", combinedDateTime);
                cmd.Parameters.Add("seatsNum", Convert.ToInt32(seats_num.Text));
                cmd.Parameters.Add("schedId", Convert.ToInt32(txtScheduleId.Text));

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("Schedule Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnLoadSchedule_Click_1(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(constr))
            {
                string selectCmd = "SELECT * FROM MOVIE_SCHEDULE WHERE SCHEDULE_ID = :schedId";
                OracleCommand cmd = new OracleCommand(selectCmd, conn);
                cmd.Parameters.Add("schedId", Convert.ToInt32(txtScheduleId.Text));

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtMovieId.Text = ds.Tables[0].Rows[0]["MOVIEID"].ToString();
                    seats_num.Text = ds.Tables[0].Rows[0]["Seats_Num"].ToString();
                    // Get the combined DateTime from database
                    DateTime startTime = Convert.ToDateTime(ds.Tables[0].Rows[0]["START_TIME"]);
                    // Set date portion to dtpScreenDate
                    dtpScreenDate.Value = startTime.Date;

                    // Set time portion to dtpStartTime
                    dtpStartTime.Value = startTime;
                }
                else
                {
                    MessageBox.Show("Schedule not found!");
                }
            }
        }

        private void btnDeleteSchedule_Click_1(object sender, EventArgs e)
        {
            using (OracleConnection conn = new OracleConnection(constr))
            {
                string deleteCmd = "DELETE FROM MOVIE_SCHEDULE WHERE SCHEDULE_ID = :schedId";
                OracleCommand cmd = new OracleCommand(deleteCmd, conn);
                cmd.Parameters.Add("schedId", Convert.ToInt32(txtScheduleId.Text));

                try
                {
                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Schedule Deleted Successfully!");
                        txtMovieId.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Back_To_Admin(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }
    }
}
