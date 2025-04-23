namespace SW_Project
{
    partial class LoginPage
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
            this.usernameText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(270, 100);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(220, 30);
            this.usernameText.TabIndex = 0;
            this.usernameText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(270, 160);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(220, 30);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(290, 230);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 40);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1 (Username)
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // label2 (Password)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            // 
            // LoginPage (Form settings)
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.usernameText);
            this.Name = "LoginPage";
            this.Text = "Login Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
    }
}