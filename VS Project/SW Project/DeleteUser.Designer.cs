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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 36);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // age_tb
            // 
            this.age_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age_tb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.age_tb.Location = new System.Drawing.Point(281, 225);
            this.age_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age_tb.Name = "age_tb";
            this.age_tb.ReadOnly = true;
            this.age_tb.Size = new System.Drawing.Size(281, 35);
            this.age_tb.TabIndex = 20;
            // 
            // phone_tb
            // 
            this.phone_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone_tb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.phone_tb.Location = new System.Drawing.Point(281, 175);
            this.phone_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phone_tb.Name = "phone_tb";
            this.phone_tb.ReadOnly = true;
            this.phone_tb.Size = new System.Drawing.Size(281, 35);
            this.phone_tb.TabIndex = 19;
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.email_tb.Location = new System.Drawing.Point(281, 125);
            this.email_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_tb.Name = "email_tb";
            this.email_tb.ReadOnly = true;
            this.email_tb.Size = new System.Drawing.Size(281, 35);
            this.email_tb.TabIndex = 17;
            // 
            // username_tb
            // 
            this.username_tb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_tb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.username_tb.Location = new System.Drawing.Point(281, 75);
            this.username_tb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_tb.Name = "username_tb";
            this.username_tb.ReadOnly = true;
            this.username_tb.Size = new System.Drawing.Size(281, 35);
            this.username_tb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(34, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 30);
            this.label5.TabIndex = 15;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(281, 312);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IsAdmin_cb
            // 
            this.IsAdmin_cb.AutoSize = true;
            this.IsAdmin_cb.Enabled = false;
            this.IsAdmin_cb.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.IsAdmin_cb.Location = new System.Drawing.Point(281, 275);
            this.IsAdmin_cb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IsAdmin_cb.Name = "IsAdmin_cb";
            this.IsAdmin_cb.Size = new System.Drawing.Size(121, 34);
            this.IsAdmin_cb.TabIndex = 22;
            this.IsAdmin_cb.Text = "Is Admin";
            this.IsAdmin_cb.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(619, 88);
            this.panelHeader.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(22, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(195, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Delete User";
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.comboBox1);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.IsAdmin_cb);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.button1);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.username_tb);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.email_tb);
            this.panelForm.Controls.Add(this.age_tb);
            this.panelForm.Controls.Add(this.phone_tb);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 88);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(22, 25, 22, 25);
            this.panelForm.Size = new System.Drawing.Size(619, 412);
            this.panelForm.TabIndex = 24;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(619, 500);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.DeleteUser_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelForm;
    }
}