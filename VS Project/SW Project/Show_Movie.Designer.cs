namespace SW_Project
{
    partial class Show_Movie
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.tickets_num_up_down = new System.Windows.Forms.NumericUpDown();
            this.seatsAvailable = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelBooking = new System.Windows.Forms.Panel();
            this.panelMovieInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tickets_num_up_down)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelBooking.SuspendLayout();
            this.panelMovieInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(20, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Tickets:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(20, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book Tickets";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(101, 41);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "label2";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDirector.Location = new System.Drawing.Point(20, 70);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(65, 28);
            this.lblDirector.TabIndex = 6;
            this.lblDirector.Text = "label2";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGenre.Location = new System.Drawing.Point(20, 100);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(65, 28);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "label2";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRating.Location = new System.Drawing.Point(20, 130);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(65, 28);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "label2";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDuration.Location = new System.Drawing.Point(20, 160);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(65, 28);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "label2";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrice.Location = new System.Drawing.Point(20, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 28);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "label2";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDescription.Location = new System.Drawing.Point(20, 230);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(500, 150);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "label2";
            // 
            // tickets_num_up_down
            // 
            this.tickets_num_up_down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tickets_num_up_down.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tickets_num_up_down.Location = new System.Drawing.Point(20, 90);
            this.tickets_num_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tickets_num_up_down.Name = "tickets_num_up_down";
            this.tickets_num_up_down.Size = new System.Drawing.Size(120, 30);
            this.tickets_num_up_down.TabIndex = 12;
            this.tickets_num_up_down.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatsAvailable
            // 
            this.seatsAvailable.AutoSize = true;
            this.seatsAvailable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.seatsAvailable.Location = new System.Drawing.Point(20, 120);
            this.seatsAvailable.Name = "seatsAvailable";
            this.seatsAvailable.Size = new System.Drawing.Size(140, 23);
            this.seatsAvailable.TabIndex = 13;
            this.seatsAvailable.Text = "Available Tickets:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.button2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(935, 70);
            this.panelHeader.TabIndex = 14;
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.panelBooking);
            this.panelForm.Controls.Add(this.panelMovieInfo);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 70);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(935, 530);
            this.panelForm.TabIndex = 15;
            // 
            // panelBooking
            // 
            this.panelBooking.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBooking.Controls.Add(this.comboBox1);
            this.panelBooking.Controls.Add(this.label1);
            this.panelBooking.Controls.Add(this.seatsAvailable);
            this.panelBooking.Controls.Add(this.tickets_num_up_down);
            this.panelBooking.Controls.Add(this.button1);
            this.panelBooking.Location = new System.Drawing.Point(580, 20);
            this.panelBooking.Name = "panelBooking";
            this.panelBooking.Size = new System.Drawing.Size(340, 210);
            this.panelBooking.TabIndex = 17;
            // 
            // panelMovieInfo
            // 
            this.panelMovieInfo.BackColor = System.Drawing.Color.White;
            this.panelMovieInfo.Controls.Add(this.lblTitle);
            this.panelMovieInfo.Controls.Add(this.lblDirector);
            this.panelMovieInfo.Controls.Add(this.txtDescription);
            this.panelMovieInfo.Controls.Add(this.lblGenre);
            this.panelMovieInfo.Controls.Add(this.lblPrice);
            this.panelMovieInfo.Controls.Add(this.lblRating);
            this.panelMovieInfo.Controls.Add(this.lblDuration);
            this.panelMovieInfo.Location = new System.Drawing.Point(20, 20);
            this.panelMovieInfo.Name = "panelMovieInfo";
            this.panelMovieInfo.Size = new System.Drawing.Size(540, 490);
            this.panelMovieInfo.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(303, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 57);
            this.label2.TabIndex = 5;
            this.label2.Text = "Movie details";
            // 
            // Show_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(935, 600);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Show_Movie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Details";
            this.Load += new System.EventHandler(this.Show_Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tickets_num_up_down)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelBooking.ResumeLayout(false);
            this.panelBooking.PerformLayout();
            this.panelMovieInfo.ResumeLayout(false);
            this.panelMovieInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.NumericUpDown tickets_num_up_down;
        private System.Windows.Forms.Label seatsAvailable;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelBooking;
        private System.Windows.Forms.Panel panelMovieInfo;
        private System.Windows.Forms.Label label2;
    }
}