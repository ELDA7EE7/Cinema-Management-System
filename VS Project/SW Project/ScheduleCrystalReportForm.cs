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
using CrystalDecisions.Shared;
namespace SW_Project
{
    public partial class ScheduleCrystalReportForm : Form
    {
        CrystalReport1 crystal;
        OracleConnection conn;
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        public ScheduleCrystalReportForm()
        {
            conn = new OracleConnection(ordb);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystal.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = crystal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crystal = new CrystalReport1();
            // Fetch distinct genre values from your database
            DataTable genres = GetGenresFromDatabase();

            // Populate ComboBox
            comboBox1.DataSource = genres;
            comboBox1.DisplayMember = "Genre"; // Replace "Genre" with your column name
        }
        private DataTable GetGenresFromDatabase()
        {
            DataTable dt = new DataTable();
            string query = "SELECT DISTINCT Genre FROM Movie"; // Adjust table/column name

            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);


            return dt;
        }
    }
}
