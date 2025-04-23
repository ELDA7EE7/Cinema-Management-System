namespace SW_Project
{
    partial class AddMovie
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
            this.title_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.genre_tb = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.rating = new System.Windows.Forms.NumericUpDown();
            this.duration_tb = new System.Windows.Forms.TextBox();
            this.cost_tb = new System.Windows.Forms.TextBox();
            this.director_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rating)).BeginInit();
            this.SuspendLayout();
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(153, 73);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(217, 20);
            this.title_tb.TabIndex = 0;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(495, 67);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(217, 134);
            this.description_tb.TabIndex = 1;
            // 
            // genre_tb
            // 
            this.genre_tb.Location = new System.Drawing.Point(153, 149);
            this.genre_tb.Name = "genre_tb";
            this.genre_tb.Size = new System.Drawing.Size(217, 20);
            this.genre_tb.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(153, 277);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(217, 20);
            this.dateTime.TabIndex = 3;
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(592, 226);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(120, 20);
            this.rating.TabIndex = 4;
            // 
            // duration_tb
            // 
            this.duration_tb.Location = new System.Drawing.Point(153, 225);
            this.duration_tb.Name = "duration_tb";
            this.duration_tb.Size = new System.Drawing.Size(217, 20);
            this.duration_tb.TabIndex = 5;
            // 
            // cost_tb
            // 
            this.cost_tb.Location = new System.Drawing.Point(153, 190);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Size = new System.Drawing.Size(217, 20);
            this.cost_tb.TabIndex = 7;
            // 
            // director_tb
            // 
            this.director_tb.Location = new System.Drawing.Point(153, 112);
            this.director_tb.Name = "director_tb";
            this.director_tb.Size = new System.Drawing.Size(217, 20);
            this.director_tb.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(713, 415);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 10;
            this.Add_Button.Text = "ADD";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ticket Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Release Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(491, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rating";
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.director_tb);
            this.Controls.Add(this.cost_tb);
            this.Controls.Add(this.duration_tb);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.genre_tb);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.title_tb);
            this.Name = "AddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.TextBox genre_tb;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.NumericUpDown rating;
        private System.Windows.Forms.TextBox duration_tb;
        private System.Windows.Forms.TextBox cost_tb;
        private System.Windows.Forms.TextBox director_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}