namespace EFCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_name = new TextBox();
            txt_age = new TextBox();
            txt_email = new TextBox();
            txt_password = new TextBox();
            lbl_username = new Label();
            lbl_age = new Label();
            lbl_email = new Label();
            lbl_password = new Label();
            btn_register = new Button();
            btn_login = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(141, 26);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(277, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_age
            // 
            txt_age.Location = new Point(141, 75);
            txt_age.Name = "txt_age";
            txt_age.Size = new Size(277, 23);
            txt_age.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(141, 129);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(277, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(141, 181);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(277, 23);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(27, 29);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(60, 15);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "Username";
            // 
            // lbl_age
            // 
            lbl_age.AutoSize = true;
            lbl_age.Location = new Point(27, 83);
            lbl_age.Name = "lbl_age";
            lbl_age.Size = new Size(28, 15);
            lbl_age.TabIndex = 5;
            lbl_age.Text = "Age";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(27, 137);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email";
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(27, 184);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 7;
            lbl_password.Text = "Password";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(246, 230);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(83, 29);
            btn_register.TabIndex = 8;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(322, 309);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(83, 29);
            btn_login.TabIndex = 9;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Location = new Point(193, 316);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Already a membe:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 374);
            Controls.Add(label5);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(lbl_password);
            Controls.Add(lbl_email);
            Controls.Add(lbl_age);
            Controls.Add(lbl_username);
            Controls.Add(txt_password);
            Controls.Add(txt_email);
            Controls.Add(txt_age);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_age;
        private TextBox txt_email;
        private TextBox txt_password;
        private Label lbl_username;
        private Label lbl_age;
        private Label lbl_email;
        private Label lbl_password;
        private Button btn_register;
        private Button btn_login;
        private Label label5;
    }
}