namespace Kasir
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            Panel panel1;
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            btn_customerManagement = new Button();
            btn_logout = new Button();
            btn_newTransaction = new Button();
            btn_ProductManagement = new Button();
            btn_transactionHistory = new Button();
            panel2 = new Panel();
            lb_versiApp = new Label();
            lb_labelTime = new Label();
            label4 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            lb_email = new Label();
            lb_role = new Label();
            pb_profile = new PictureBox();
            label7 = new Label();
            dgv_kasirLoginHistory = new DataGridView();
            dgv_staffLoginHistory = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            spt_loginHistory = new Splitter();
            splitter1 = new Splitter();
            tmr_realTime = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_kasirLoginHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_staffLoginHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_customerManagement);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_newTransaction);
            panel1.Controls.Add(btn_ProductManagement);
            panel1.Controls.Add(btn_transactionHistory);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 71);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Size = new Size(200, 44);
            label2.TabIndex = 12;
            label2.Text = "Cashier";
            // 
            // btn_customerManagement
            // 
            btn_customerManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_customerManagement.Location = new Point(448, 11);
            btn_customerManagement.Name = "btn_customerManagement";
            btn_customerManagement.Size = new Size(174, 46);
            btn_customerManagement.TabIndex = 10;
            btn_customerManagement.Text = "customer management";
            btn_customerManagement.UseVisualStyleBackColor = true;
            btn_customerManagement.Click += btn_customerManagement_Click;
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.Location = new Point(982, 11);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(174, 46);
            btn_logout.TabIndex = 11;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_newTransaction
            // 
            btn_newTransaction.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_newTransaction.Location = new Point(626, 11);
            btn_newTransaction.Name = "btn_newTransaction";
            btn_newTransaction.Size = new Size(174, 46);
            btn_newTransaction.TabIndex = 7;
            btn_newTransaction.Text = "New Transaction";
            btn_newTransaction.UseVisualStyleBackColor = true;
            btn_newTransaction.Click += btn_newTransaction_Click;
            // 
            // btn_ProductManagement
            // 
            btn_ProductManagement.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ProductManagement.Location = new Point(270, 11);
            btn_ProductManagement.Name = "btn_ProductManagement";
            btn_ProductManagement.Size = new Size(174, 46);
            btn_ProductManagement.TabIndex = 9;
            btn_ProductManagement.Text = "product management";
            btn_ProductManagement.UseVisualStyleBackColor = true;
            btn_ProductManagement.Click += btn_ProductManagement_Click;
            // 
            // btn_transactionHistory
            // 
            btn_transactionHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_transactionHistory.Location = new Point(804, 11);
            btn_transactionHistory.Name = "btn_transactionHistory";
            btn_transactionHistory.Size = new Size(174, 46);
            btn_transactionHistory.TabIndex = 8;
            btn_transactionHistory.Text = "transaction history";
            btn_transactionHistory.UseVisualStyleBackColor = true;
            btn_transactionHistory.Click += btn_transactionHistory_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lb_versiApp);
            panel2.Controls.Add(lb_labelTime);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgv_kasirLoginHistory);
            panel2.Controls.Add(dgv_staffLoginHistory);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(spt_loginHistory);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 502);
            panel2.TabIndex = 7;
            // 
            // lb_versiApp
            // 
            lb_versiApp.AutoSize = true;
            lb_versiApp.Location = new Point(51, 459);
            lb_versiApp.Name = "lb_versiApp";
            lb_versiApp.Size = new Size(91, 20);
            lb_versiApp.TabIndex = 26;
            lb_versiApp.Text = "Version 1.0.0";
            // 
            // lb_labelTime
            // 
            lb_labelTime.AutoSize = true;
            lb_labelTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_labelTime.Location = new Point(51, 430);
            lb_labelTime.Name = "lb_labelTime";
            lb_labelTime.Size = new Size(185, 20);
            lb_labelTime.TabIndex = 26;
            lb_labelTime.Text = "00:00:00 - DD/MM/YYYY";
            lb_labelTime.Click += lb_labelTime_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 459);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 26;
            label4.Text = "⚙";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 430);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 26;
            label1.Text = "📅";
            // 
            // panel3
            // 
            panel3.Controls.Add(lb_email);
            panel3.Controls.Add(lb_role);
            panel3.Controls.Add(pb_profile);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 128);
            panel3.TabIndex = 19;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Location = new Point(77, 56);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(95, 20);
            lb_email.TabIndex = 25;
            lb_email.Text = "Email of user";
            lb_email.Click += lb_email_Click;
            // 
            // lb_role
            // 
            lb_role.AutoSize = true;
            lb_role.Location = new Point(77, 86);
            lb_role.Name = "lb_role";
            lb_role.Size = new Size(88, 20);
            lb_role.TabIndex = 24;
            lb_role.Text = "Role of user";
            lb_role.Click += lb_role_Click;
            // 
            // pb_profile
            // 
            pb_profile.Location = new Point(23, 56);
            pb_profile.Name = "pb_profile";
            pb_profile.Size = new Size(48, 50);
            pb_profile.TabIndex = 21;
            pb_profile.TabStop = false;
            pb_profile.Click += pb_profile_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(91, 19);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 3;
            label7.Text = "Profile User";
            // 
            // dgv_kasirLoginHistory
            // 
            dgv_kasirLoginHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_kasirLoginHistory.Location = new Point(23, 297);
            dgv_kasirLoginHistory.Name = "dgv_kasirLoginHistory";
            dgv_kasirLoginHistory.RowHeadersWidth = 51;
            dgv_kasirLoginHistory.Size = new Size(216, 88);
            dgv_kasirLoginHistory.TabIndex = 18;
            dgv_kasirLoginHistory.CellContentClick += dgv_kasirLoginHistory_CellContentClick;
            // 
            // dgv_staffLoginHistory
            // 
            dgv_staffLoginHistory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_staffLoginHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_staffLoginHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_staffLoginHistory.Location = new Point(23, 161);
            dgv_staffLoginHistory.Name = "dgv_staffLoginHistory";
            dgv_staffLoginHistory.RowHeadersWidth = 51;
            dgv_staffLoginHistory.Size = new Size(216, 88);
            dgv_staffLoginHistory.TabIndex = 17;
            dgv_staffLoginHistory.CellContentClick += dgv_staffLoginHistory_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 274);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 13;
            label5.Text = "Kasir login history :";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 138);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 16;
            label3.Text = "Staff login history :";
            label3.Click += label3_Click;
            // 
            // spt_loginHistory
            // 
            spt_loginHistory.BorderStyle = BorderStyle.FixedSingle;
            spt_loginHistory.Dock = DockStyle.Bottom;
            spt_loginHistory.Location = new Point(0, 128);
            spt_loginHistory.Name = "spt_loginHistory";
            spt_loginHistory.Size = new Size(263, 273);
            spt_loginHistory.TabIndex = 10;
            spt_loginHistory.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.BorderStyle = BorderStyle.FixedSingle;
            splitter1.Dock = DockStyle.Bottom;
            splitter1.Location = new Point(0, 401);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(263, 101);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // tmr_realTime
            // 
            tmr_realTime.Interval = 1000;
            tmr_realTime.Tick += tmr_realTime_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 573);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "fi";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_kasirLoginHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_staffLoginHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_productManagement;
        private Button btn_newTransaction;
        private Button btn_transactionHistory;
        private Button btn_ProductManagement;
        private Button btn_customerManagement;
        private Button btn_logout;
        private Panel panel2;
        private Label label2;
        private PictureBox pb_profile;
        private DataGridView dgv_kasirLoginHistory;
        private Label label5;
        private DataGridView dgv_staffLoginHistory;
        private Label label3;
        private Splitter spt_loginHistory;
        private Panel panel3;
        private Label label7;
        private PictureBox pictureBox1;
        private Label lb_versiApp;
        private Label lb_role;
        private Label lb_email;
        private Splitter splitter1;
        private Label label4;
        private Label label1;
        private Label lb_labelTime;
        private System.Windows.Forms.Timer tmr_realTime;
    }
}