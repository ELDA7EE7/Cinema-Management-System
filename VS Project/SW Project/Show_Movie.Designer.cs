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
            ((System.ComponentModel.ISupportInitialize)(this.tickets_num_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 305);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Tickets:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(92, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 34);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "label2";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(92, 110);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(91, 34);
            this.lblDirector.TabIndex = 6;
            this.lblDirector.Text = "label2";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(92, 163);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(91, 34);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "label2";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(92, 211);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(91, 34);
            this.lblRating.TabIndex = 8;
            this.lblRating.Text = "label2";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(319, 110);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(91, 34);
            this.lblDuration.TabIndex = 9;
            this.lblDuration.Text = "label2";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(319, 163);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 34);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "label2";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(319, 211);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(91, 34);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "label2";
            // 
            // tickets_num_up_down
            // 
            this.tickets_num_up_down.Location = new System.Drawing.Point(117, 262);
            this.tickets_num_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tickets_num_up_down.Name = "tickets_num_up_down";
            this.tickets_num_up_down.Size = new System.Drawing.Size(120, 20);
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
            this.seatsAvailable.Font = new System.Drawing.Font("Impact", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatsAvailable.Location = new System.Drawing.Point(16, 341);
            this.seatsAvailable.Name = "seatsAvailable";
            this.seatsAvailable.Size = new System.Drawing.Size(227, 34);
            this.seatsAvailable.TabIndex = 13;
            this.seatsAvailable.Text = "Available Tickets:";
            // 
            // Show_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seatsAvailable);
            this.Controls.Add(this.tickets_num_up_down);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Show_Movie";
            this.Text = "Show_Movie";
            this.Load += new System.EventHandler(this.Show_Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tickets_num_up_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}