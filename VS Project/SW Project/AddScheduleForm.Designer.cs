namespace SW_Project
{
    partial class AddScheduleForm
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
            this.txtMovieId = new System.Windows.Forms.TextBox();
            this.dtpScreenDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.lblMovieId = new System.Windows.Forms.Label();
            this.lblScreenDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Back_to_Admin = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.seats_num = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMovieId
            // 
            this.txtMovieId.BackColor = System.Drawing.Color.White;
            this.txtMovieId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMovieId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieId.Location = new System.Drawing.Point(240, 55);
            this.txtMovieId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMovieId.Name = "txtMovieId";
            this.txtMovieId.Size = new System.Drawing.Size(333, 26);
            this.txtMovieId.TabIndex = 1;
            // 
            // dtpScreenDate
            // 
            this.dtpScreenDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreenDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpScreenDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpScreenDate.Location = new System.Drawing.Point(240, 121);
            this.dtpScreenDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpScreenDate.Name = "dtpScreenDate";
            this.dtpScreenDate.Size = new System.Drawing.Size(332, 26);
            this.dtpScreenDate.TabIndex = 2;
            this.dtpScreenDate.Value = new System.DateTime(2029, 12, 25, 23, 59, 59, 0);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartTime.Location = new System.Drawing.Point(240, 183);
            this.dtpStartTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(332, 26);
            this.dtpStartTime.TabIndex = 3;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddSchedule.FlatAppearance.BorderSize = 0;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(159, 348);
            this.btnAddSchedule.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(333, 55);
            this.btnAddSchedule.TabIndex = 5;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // lblMovieId
            // 
            this.lblMovieId.AutoSize = true;
            this.lblMovieId.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieId.Location = new System.Drawing.Point(40, 58);
            this.lblMovieId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMovieId.Name = "lblMovieId";
            this.lblMovieId.Size = new System.Drawing.Size(69, 19);
            this.lblMovieId.TabIndex = 7;
            this.lblMovieId.Text = "Movie ID:";
            // 
            // lblScreenDate
            // 
            this.lblScreenDate.AutoSize = true;
            this.lblScreenDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenDate.Location = new System.Drawing.Point(40, 121);
            this.lblScreenDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScreenDate.Name = "lblScreenDate";
            this.lblScreenDate.Size = new System.Drawing.Size(87, 19);
            this.lblScreenDate.TabIndex = 8;
            this.lblScreenDate.Text = "Screen Date:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(40, 183);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(77, 19);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "Start Time:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.Back_to_Admin);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(667, 86);
            this.panelHeader.TabIndex = 11;
            // 
            // Back_to_Admin
            // 
            this.Back_to_Admin.Location = new System.Drawing.Point(484, 32);
            this.Back_to_Admin.Margin = new System.Windows.Forms.Padding(4);
            this.Back_to_Admin.Name = "Back_to_Admin";
            this.Back_to_Admin.Size = new System.Drawing.Size(100, 28);
            this.Back_to_Admin.TabIndex = 1;
            this.Back_to_Admin.Text = "Back";
            this.Back_to_Admin.UseVisualStyleBackColor = true;
            this.Back_to_Admin.Click += new System.EventHandler(this.Back_to_Admin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Schedule";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.seats_num);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.txtMovieId);
            this.panelForm.Controls.Add(this.lblStartTime);
            this.panelForm.Controls.Add(this.lblMovieId);
            this.panelForm.Controls.Add(this.dtpScreenDate);
            this.panelForm.Controls.Add(this.lblScreenDate);
            this.panelForm.Controls.Add(this.dtpStartTime);
            this.panelForm.Controls.Add(this.btnAddSchedule);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 86);
            this.panelForm.Margin = new System.Windows.Forms.Padding(4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panelForm.Size = new System.Drawing.Size(667, 468);
            this.panelForm.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Available Seats:";
            // 
            // seats_num
            // 
            this.seats_num.BackColor = System.Drawing.Color.White;
            this.seats_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seats_num.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seats_num.Location = new System.Drawing.Point(240, 241);
            this.seats_num.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.seats_num.Name = "seats_num";
            this.seats_num.Size = new System.Drawing.Size(333, 26);
            this.seats_num.TabIndex = 11;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(667, 554);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Management";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtMovieId;
        private System.Windows.Forms.DateTimePicker dtpScreenDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.Label lblMovieId;
        private System.Windows.Forms.Label lblScreenDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button Back_to_Admin;
        private System.Windows.Forms.TextBox seats_num;
        private System.Windows.Forms.Label label1;
    }
}