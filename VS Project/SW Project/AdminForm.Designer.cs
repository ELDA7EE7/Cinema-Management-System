namespace SW_Project
{
    partial class AdminForm
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
            this.add_admin_button = new System.Windows.Forms.Button();
            this.add_movie = new System.Windows.Forms.Button();
            this.add_schedule = new System.Windows.Forms.Button();
            this.delete_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_Movie = new System.Windows.Forms.Button();
            this.delete_movie = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.update_schedule = new System.Windows.Forms.Button();
            this.remove_schedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_admin_button
            // 
            this.add_admin_button.Location = new System.Drawing.Point(19, 65);
            this.add_admin_button.Name = "add_admin_button";
            this.add_admin_button.Size = new System.Drawing.Size(141, 23);
            this.add_admin_button.TabIndex = 0;
            this.add_admin_button.Text = "Add Admin";
            this.add_admin_button.UseVisualStyleBackColor = true;
            this.add_admin_button.Click += new System.EventHandler(this.manage_user_Click);
            // 
            // add_movie
            // 
            this.add_movie.Location = new System.Drawing.Point(19, 172);
            this.add_movie.Name = "add_movie";
            this.add_movie.Size = new System.Drawing.Size(141, 23);
            this.add_movie.TabIndex = 1;
            this.add_movie.Text = "Add Movie";
            this.add_movie.UseVisualStyleBackColor = true;
            this.add_movie.Click += new System.EventHandler(this.manage_movie_Click);
            // 
            // add_schedule
            // 
            this.add_schedule.Location = new System.Drawing.Point(19, 272);
            this.add_schedule.Name = "add_schedule";
            this.add_schedule.Size = new System.Drawing.Size(141, 23);
            this.add_schedule.TabIndex = 2;
            this.add_schedule.Text = "Add To Schedule";
            this.add_schedule.UseVisualStyleBackColor = true;
            this.add_schedule.Click += new System.EventHandler(this.manage_schedule_Click);
            // 
            // delete_user
            // 
            this.delete_user.Location = new System.Drawing.Point(166, 65);
            this.delete_user.Name = "delete_user";
            this.delete_user.Size = new System.Drawing.Size(141, 23);
            this.delete_user.TabIndex = 3;
            this.delete_user.Text = "Delete User";
            this.delete_user.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "User Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie Management";
            // 
            // update_Movie
            // 
            this.update_Movie.Location = new System.Drawing.Point(166, 172);
            this.update_Movie.Name = "update_Movie";
            this.update_Movie.Size = new System.Drawing.Size(141, 23);
            this.update_Movie.TabIndex = 6;
            this.update_Movie.Text = "Update Movie";
            this.update_Movie.UseVisualStyleBackColor = true;
            // 
            // delete_movie
            // 
            this.delete_movie.Location = new System.Drawing.Point(313, 172);
            this.delete_movie.Name = "delete_movie";
            this.delete_movie.Size = new System.Drawing.Size(141, 23);
            this.delete_movie.TabIndex = 7;
            this.delete_movie.Text = "Delete Movie";
            this.delete_movie.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Schedule Management";
            // 
            // update_schedule
            // 
            this.update_schedule.Location = new System.Drawing.Point(166, 272);
            this.update_schedule.Name = "update_schedule";
            this.update_schedule.Size = new System.Drawing.Size(141, 23);
            this.update_schedule.TabIndex = 9;
            this.update_schedule.Text = "Update Schedule";
            this.update_schedule.UseVisualStyleBackColor = true;
            // 
            // remove_schedule
            // 
            this.remove_schedule.Location = new System.Drawing.Point(313, 272);
            this.remove_schedule.Name = "remove_schedule";
            this.remove_schedule.Size = new System.Drawing.Size(141, 23);
            this.remove_schedule.TabIndex = 10;
            this.remove_schedule.Text = "Remove From Schedule";
            this.remove_schedule.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.remove_schedule);
            this.Controls.Add(this.update_schedule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete_movie);
            this.Controls.Add(this.update_Movie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_user);
            this.Controls.Add(this.add_schedule);
            this.Controls.Add(this.add_movie);
            this.Controls.Add(this.add_admin_button);
            this.Name = "AdminForm";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_admin_button;
        private System.Windows.Forms.Button add_movie;
        private System.Windows.Forms.Button add_schedule;
        private System.Windows.Forms.Button delete_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_Movie;
        private System.Windows.Forms.Button delete_movie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button update_schedule;
        private System.Windows.Forms.Button remove_schedule;
    }
}