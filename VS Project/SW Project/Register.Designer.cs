namespace SW_Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.username_tb = new System.Windows.Forms.TextBox();
            this.phone_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Go_to_Login_Label = new System.Windows.Forms.LinkLabel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // username_tb
            this.username_tb.BackColor = System.Drawing.Color.White;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.username_tb.Location = new System.Drawing.Point(180, 30);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(250, 25);
            this.username_tb.TabIndex = 0;

            // phone_tb
            this.phone_tb.BackColor = System.Drawing.Color.White;
            this.phone_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.phone_tb.Location = new System.Drawing.Point(180, 70);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.Size = new System.Drawing.Size(250, 25);
            this.phone_tb.TabIndex = 1;

            // age_tb
            this.age_tb.BackColor = System.Drawing.Color.White;
            this.age_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.age_tb.Location = new System.Drawing.Point(180, 110);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(250, 25);
            this.age_tb.TabIndex = 2;

            // password_tb
            this.password_tb.BackColor = System.Drawing.Color.White;
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.password_tb.Location = new System.Drawing.Point(180, 190);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(250, 25);
            this.password_tb.TabIndex = 3;
            this.password_tb.UseSystemPasswordChar = true;

            // email_tb
            this.email_tb.BackColor = System.Drawing.Color.White;
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.email_tb.Location = new System.Drawing.Point(180, 150);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(250, 25);
            this.email_tb.TabIndex = 4;

            // button1
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(180, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "REGISTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username:";

            // label2
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phone Number:";

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Age:";

            // label4
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";

            // label5
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password:";

            // Go_to_Login_Label
            this.Go_to_Login_Label.AutoSize = true;
            this.Go_to_Login_Label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Go_to_Login_Label.LinkColor = System.Drawing.Color.SteelBlue;
            this.Go_to_Login_Label.Location = new System.Drawing.Point(180, 280);
            this.Go_to_Login_Label.Name = "Go_to_Login_Label";
            this.Go_to_Login_Label.Size = new System.Drawing.Size(195, 15);
            this.Go_to_Login_Label.TabIndex = 11;
            this.Go_to_Login_Label.TabStop = true;
            this.Go_to_Login_Label.Text = "Already have an account? Login here";
            this.Go_to_Login_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Go_to_Login_Label_LinkClicked);

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 70);
            this.panelHeader.TabIndex = 12;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Register";

            // panelForm
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.username_tb);
            this.panelForm.Controls.Add(this.Go_to_Login_Label);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.phone_tb);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.age_tb);
            this.panelForm.Controls.Add(this.email_tb);
            this.panelForm.Controls.Add(this.password_tb);
            this.panelForm.Controls.Add(this.button1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 70);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(20);
            this.panelForm.Size = new System.Drawing.Size(500, 330);
            this.panelForm.TabIndex = 13;

            // Register
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.TextBox phone_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel Go_to_Login_Label;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
    }
}