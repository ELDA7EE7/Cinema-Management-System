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
    public partial class view_history : Form
    {

        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        int cur_user_id = CurrUser.UserId;

        public view_history()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Replace this with the actual user ID in your app
            int cur_user_id = CurrUser.UserId;

            if (!int.TryParse(txt_price.Text, out int maxPrice))
            {
                MessageBox.Show("Please enter a valid number for the price.");
                return;
            }

            string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
            using (OracleConnection conn = new OracleConnection(ordb))
            {
                string query = @"SELECT M.Title, B.BookingDate, B.Quantity, B.TicketPrice, (B.Quantity * B.TicketPrice) AS TotalPrice
                         FROM Booking B
                         JOIN Movie M ON B.MovieID = M.MovieID
                         WHERE B.UserID = :userId AND (B.Quantity * B.TicketPrice) <= :maxPrice";

                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;
                cmd.Parameters.Add(":maxPrice", OracleDbType.Double).Value = maxPrice;

                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.Rows.Clear(); // Clear old results if any

                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row["Title"], row["BookingDate"], row["Quantity"], row["TicketPrice"], row["TotalPrice"]);
                }
            }
        }


        private void view_history_Load(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection(ordb);
            conn.Open();

            string query = @"
                    SELECT 
                        M.Title AS MovieTitle,
                        B.BookingDate,
                        B.Quantity,
                        B.TicketPrice,
                        B.Quantity * B.TicketPrice AS TotalPrice
                    FROM 
                        Booking B
                    JOIN 
                        Movie M ON B.MovieID = M.MovieID
                    WHERE 
                        B.UserID = :userId
                    ORDER BY 
                        B.BookingDate DESC";

            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(":userId", OracleDbType.Int32).Value = cur_user_id;

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(
                    row["MovieTitle"],
                    Convert.ToDateTime(row["BookingDate"]).ToString("yyyy-MM-dd HH:mm"),
                    row["Quantity"],
                    row["TicketPrice"],
                    row["TotalPrice"]
                );
            }
        }
    }
}
