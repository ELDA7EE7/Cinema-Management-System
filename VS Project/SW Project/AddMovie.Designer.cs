namespace SW_Project
{
    partial class AddMovie
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.title_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.genre_tb = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.rating_num = new System.Windows.Forms.NumericUpDown();
            this.duration_tb = new System.Windows.Forms.TextBox();
            this.cost_tb = new System.Windows.Forms.TextBox();
            this.director_tb = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rating_num)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_tb
            // 
            this.title_tb.BackColor = System.Drawing.Color.White;
            this.title_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.title_tb.Location = new System.Drawing.Point(180, 30);
            this.title_tb.Name = "title_tb";
            this.title_tb.Size = new System.Drawing.Size(250, 30);
            this.title_tb.TabIndex = 0;
            // 
            // description_tb
            // 
            this.description_tb.BackColor = System.Drawing.Color.White;
            this.description_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.description_tb.Location = new System.Drawing.Point(457, 70);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(322, 100);
            this.description_tb.TabIndex = 1;
            // 
            // genre_tb
            // 
            this.genre_tb.BackColor = System.Drawing.Color.White;
            this.genre_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genre_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genre_tb.Location = new System.Drawing.Point(180, 97);
            this.genre_tb.Name = "genre_tb";
            this.genre_tb.Size = new System.Drawing.Size(250, 30);
            this.genre_tb.TabIndex = 2;
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(180, 216);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(250, 30);
            this.dateTime.TabIndex = 3;
            // 
            // rating_num
            // 
            this.rating_num.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rating_num.Location = new System.Drawing.Point(529, 197);
            this.rating_num.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rating_num.Name = "rating_num";
            this.rating_num.Size = new System.Drawing.Size(250, 30);
            this.rating_num.TabIndex = 4;
            // 
            // duration_tb
            // 
            this.duration_tb.BackColor = System.Drawing.Color.White;
            this.duration_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.duration_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.duration_tb.Location = new System.Drawing.Point(180, 133);
            this.duration_tb.Name = "duration_tb";
            this.duration_tb.Size = new System.Drawing.Size(250, 30);
            this.duration_tb.TabIndex = 5;
            // 
            // cost_tb
            // 
            this.cost_tb.BackColor = System.Drawing.Color.White;
            this.cost_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cost_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cost_tb.Location = new System.Drawing.Point(180, 177);
            this.cost_tb.Name = "cost_tb";
            this.cost_tb.Size = new System.Drawing.Size(250, 30);
            this.cost_tb.TabIndex = 7;
            // 
            // director_tb
            // 
            this.director_tb.BackColor = System.Drawing.Color.White;
            this.director_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.director_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.director_tb.Location = new System.Drawing.Point(180, 66);
            this.director_tb.Name = "director_tb";
            this.director_tb.Size = new System.Drawing.Size(250, 30);
            this.director_tb.TabIndex = 8;
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.SteelBlue;
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(20, 20);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(80, 30);
            this.back_button.TabIndex = 9;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.Back_to_AdminMenu);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.SeaGreen;
            this.Add_Button.FlatAppearance.BorderSize = 0;
            this.Add_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Add_Button.ForeColor = System.Drawing.Color.White;
            this.Add_Button.Location = new System.Drawing.Point(286, 295);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(250, 40);
            this.Add_Button.TabIndex = 10;
            this.Add_Button.Text = "ADD MOVIE";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ticket Cost:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Duration:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(453, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Description:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(23, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Release Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(453, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Rating:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.back_button);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(791, 70);
            this.panelHeader.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(320, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add Movie";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.title_tb);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.director_tb);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.genre_tb);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.duration_tb);
            this.panelForm.Controls.Add(this.cost_tb);
            this.panelForm.Controls.Add(this.dateTime);
            this.panelForm.Controls.Add(this.rating_num);
            this.panelForm.Controls.Add(this.description_tb);
            this.panelForm.Controls.Add(this.Add_Button);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 70);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(791, 358);
            this.panelForm.TabIndex = 20;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(791, 428);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rating_num)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.TextBox genre_tb;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.NumericUpDown rating_num;
        private System.Windows.Forms.TextBox duration_tb;
        private System.Windows.Forms.TextBox cost_tb;
        private System.Windows.Forms.TextBox director_tb;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
    }
}