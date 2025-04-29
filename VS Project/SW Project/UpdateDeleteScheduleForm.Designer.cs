namespace SW_Project
{
    partial class UpdateDeleteScheduleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtScheduleId = new System.Windows.Forms.TextBox();
            this.btnLoadSchedule = new System.Windows.Forms.Button();
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.dtpScreenDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateSchedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.lblScheduleId = new System.Windows.Forms.Label();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblScreenDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtScheduleId
            // 
            this.txtScheduleId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScheduleId.Location = new System.Drawing.Point(161, 81);
            this.txtScheduleId.Name = "txtScheduleId";
            this.txtScheduleId.Size = new System.Drawing.Size(200, 25);
            this.txtScheduleId.TabIndex = 1;
            // 
            // btnLoadSchedule
            // 
            this.btnLoadSchedule.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadSchedule.FlatAppearance.BorderSize = 0;
            this.btnLoadSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSchedule.ForeColor = System.Drawing.Color.White;
            this.btnLoadSchedule.Location = new System.Drawing.Point(380, 80);
            this.btnLoadSchedule.Name = "btnLoadSchedule";
            this.btnLoadSchedule.Size = new System.Drawing.Size(100, 30);
            this.btnLoadSchedule.TabIndex = 2;
            this.btnLoadSchedule.Text = "Load";
            this.btnLoadSchedule.UseVisualStyleBackColor = false;
            this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click_1);
            // 
            // txtMovieId
            // 
            this.txtMovieId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieId.Location = new System.Drawing.Point(162, 130);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(200, 25);
            this.txtMovieId.TabIndex = 3;
            // 
            // dtpScreenDate
            // 
            this.dtpScreenDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreenDate.Location = new System.Drawing.Point(162, 183);
            this.dtpScreenDate.Name = "dtpScreenDate";
            this.dtpScreenDate.Size = new System.Drawing.Size(200, 25);
            this.dtpScreenDate.TabIndex = 4;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(162, 233);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(200, 25);
            this.dtpStartTime.TabIndex = 5;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndTime.Location = new System.Drawing.Point(162, 277);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(200, 25);
            this.dtpEndTime.TabIndex = 6;
            // 
            // btnUpdateSchedule
            // 
            this.btnUpdateSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.btnUpdateSchedule.FlatAppearance.BorderSize = 0;
            this.btnUpdateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSchedule.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSchedule.Location = new System.Drawing.Point(150, 330);
            this.btnUpdateSchedule.Name = "btnUpdateSchedule";
            this.btnUpdateSchedule.Size = new System.Drawing.Size(120, 40);
            this.btnUpdateSchedule.TabIndex = 7;
            this.btnUpdateSchedule.Text = "Update";
            this.btnUpdateSchedule.UseVisualStyleBackColor = false;
            this.btnUpdateSchedule.Click += new System.EventHandler(this.btnUpdateSchedule_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteSchedule.FlatAppearance.BorderSize = 0;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(290, 330);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteSchedule.TabIndex = 8;
            this.btnDeleteSchedule.Text = "Delete";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click_1);
            // 
            // lblScheduleId
            // 
            this.lblScheduleId.AutoSize = true;
            this.lblScheduleId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleId.Location = new System.Drawing.Point(50, 83);
            this.lblScheduleId.Name = "lblScheduleId";
            this.lblScheduleId.Size = new System.Drawing.Size(79, 17);
            this.lblScheduleId.TabIndex = 9;
            this.lblScheduleId.Text = "Schedule ID:";
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(50, 133);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(63, 17);
            this.lblMovieId.TabIndex = 10;
            this.lblMovieId.Text = "Movie ID:";
            // 
            // lblScreenDate
            // 
            this.lblScreenDate.AutoSize = true;
            this.lblScreenDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenDate.Location = new System.Drawing.Point(50, 183);
            this.lblScreenDate.Name = "lblScreenDate";
            this.lblScreenDate.Size = new System.Drawing.Size(81, 17);
            this.lblScreenDate.TabIndex = 11;
            this.lblScreenDate.Text = "Screen Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(50, 233);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(70, 17);
            this.lblStartTime.TabIndex = 12;
            this.lblStartTime.Text = "Start Time:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(50, 283);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(65, 17);
            this.lblEndTime.TabIndex = 13;
            this.lblEndTime.Text = "End Time:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 60);
            this.panel1.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update/Delete Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Back_To_Admin);
            // 
            // UpdateDeleteScheduleForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblScreenDate);
            this.Controls.Add(this.lblMovieId);
            this.Controls.Add(this.lblScheduleId);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnUpdateSchedule);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpScreenDate);
            this.Controls.Add(this.txtMovieId);
            this.Controls.Add(this.btnLoadSchedule);
            this.Controls.Add(this.txtScheduleId);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateDeleteScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Management";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScheduleId;
        private System.Windows.Forms.Button btnLoadSchedule;
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.DateTimePicker dtpScreenDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.Button btnUpdateSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.Label lblScheduleId;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Label lblScreenDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button button1;
    }
}