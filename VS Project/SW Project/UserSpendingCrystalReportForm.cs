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
    public partial class UserSpendingCrystalReportForm : Form
    {
        CrystalReport2 crystal;
        public UserSpendingCrystalReportForm()
        {
            InitializeComponent();
        }

        private void UserSpendingCrystalReportForm_Load(object sender, EventArgs e)
        {
            crystal = new CrystalReport2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                crystal.SetParameterValue(0, Convert.ToInt32(textBox1.Text));
                crystalReportViewer1.ReportSource = crystal;
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid Number");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm admin = new AdminForm();
            admin.Show();
            this.Close();
        }
    }
}
