namespace Kasir
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            tb_email = new TextBox();
            label3 = new Label();
            tb_password = new TextBox();
            btn_login = new Button();
            label4 = new Label();
            cb_roleUsers = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 71);
            label1.Name = "label1";
            label1.Size = new Size(129, 39);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 163);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(215, 159);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(219, 27);
            tb_email.TabIndex = 2;
            tb_email.TextChanged += tb_username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(126, 206);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(215, 202);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(219, 27);
            tb_password.TabIndex = 4;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(340, 246);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(126, 251);
            label4.Name = "label4";
            label4.Size = new Size(47, 18);
            label4.TabIndex = 6;
            label4.Text = "Role :";
            // 
            // cb_roleUsers
            // 
            cb_roleUsers.FormattingEnabled = true;
            cb_roleUsers.Location = new Point(215, 247);
            cb_roleUsers.Name = "cb_roleUsers";
            cb_roleUsers.Size = new Size(105, 28);
            cb_roleUsers.TabIndex = 7;
            cb_roleUsers.SelectedIndexChanged += cb_roleUsers_SelectedIndexChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 358);
            Controls.Add(cb_roleUsers);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Controls.Add(label3);
            Controls.Add(tb_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_email;
        private Label label3;
        private TextBox tb_password;
        private Button btn_login;
        private Label label4;
        private ComboBox cb_roleUsers;
    }
}
