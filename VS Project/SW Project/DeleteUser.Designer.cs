namespace SW_Project
{
    partial class DeleteUser
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
            this.age_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IsAdmin_cb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(292, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(441, 297);
            this.age_tb.Name = "age_tb";
            this.age_tb.ReadOnly = true;
            this.age_tb.Size = new System.Drawing.Size(162, 20);
            this.age_tb.TabIndex = 20;
            // 
            // phone_tb
            // 
            this.phone_tb.Location = new System.Drawing.Point(441, 254);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.ReadOnly = true;
            this.phone_tb.Size = new System.Drawing.Size(162, 20);
            this.phone_tb.TabIndex = 19;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(441, 174);
            this.email_tb.Name = "email_tb";
            this.email_tb.ReadOnly = true;
            this.email_tb.Size = new System.Drawing.Size(162, 20);
            this.email_tb.TabIndex = 17;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(441, 133);
            this.username_tb.Name = "username_tb";
            this.username_tb.ReadOnly = true;
            this.username_tb.Size = new System.Drawing.Size(162, 20);
            this.username_tb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsAdmin_cb
            // 
            this.IsAdmin_cb.AutoSize = true;
            this.IsAdmin_cb.Location = new System.Drawing.Point(441, 350);
            this.IsAdmin_cb.Name = "IsAdmin_cb";
            this.IsAdmin_cb.Size = new System.Drawing.Size(66, 17);
            this.IsAdmin_cb.TabIndex = 22;
            this.IsAdmin_cb.Text = "Is Admin";
            this.IsAdmin_cb.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsAdmin_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.phone_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "DeleteUser";
            this.Text = "Delete User";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox IsAdmin_cb;
    }
}