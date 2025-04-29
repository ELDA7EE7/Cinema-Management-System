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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void Add_Admin_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            addAdmin.Show();
            this.Close();
        }

        private void Add_Movie_Click(object sender, EventArgs e)
        {
            AddMovie addMovie = new AddMovie();
            addMovie.Show();
            this.Close();
        }

        private void Add_Schedule_Click(object sender, EventArgs e)
        {
            AddScheduleForm addScheduleForm = new AddScheduleForm();
            addScheduleForm.Show();
            this.Close();
        }

        private void delete_user_Click(object sender, EventArgs e)
        {
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.Show();
            this.Close();
        }

        private void update_Movie_Click(object sender, EventArgs e)
        {
            Modify_film modify_Film = new Modify_film();
            modify_Film.Show();
            this.Close();
        }

        private void update_schedule_Click(object sender, EventArgs e)
        {
            UpdateDeleteScheduleForm updateDeleteScheduleForm = new UpdateDeleteScheduleForm();
            updateDeleteScheduleForm.Show();
            this.Close();
        }
    }
}
