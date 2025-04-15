namespace Kasir
{
    partial class CustomerManagement
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
            btn_reset = new Button();
            label8 = new Label();
            tb_customerId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btn_refresh = new Button();
            btn_remove = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            tb_searchCustomer = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tb_customerName = new TextBox();
            tb_phone = new TextBox();
            label7 = new Label();
            tb_email = new TextBox();
            label9 = new Label();
            tb_address = new TextBox();
            label10 = new Label();
            pb_facePhoto = new PictureBox();
            btn_addPhoto = new Button();
            cb_vip = new CheckBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_facePhoto).BeginInit();
            SuspendLayout();
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(342, 425);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 44;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(663, 204);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 39;
            label8.Text = "Phone :";
            // 
            // tb_customerId
            // 
            tb_customerId.Location = new Point(663, 121);
            tb_customerId.Name = "tb_customerId";
            tb_customerId.Size = new Size(193, 27);
            tb_customerId.TabIndex = 35;
            tb_customerId.TextChanged += tb_customerId_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(663, 151);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 33;
            label5.Text = "Customer Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(663, 98);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 32;
            label4.Text = "CustomerID (Unique) :";
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(358, 44);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(94, 29);
            btn_refresh.TabIndex = 31;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(242, 425);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(94, 29);
            btn_remove.TabIndex = 30;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(142, 425);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 29;
            btn_edit.Text = "edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(42, 425);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 28;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 124);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 27;
            label3.Text = "List of customers :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 259);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tb_searchCustomer
            // 
            tb_searchCustomer.Location = new Point(185, 45);
            tb_searchCustomer.Name = "tb_searchCustomer";
            tb_searchCustomer.Size = new Size(167, 27);
            tb_searchCustomer.TabIndex = 25;
            tb_searchCustomer.TextChanged += tb_searchCustomer_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 50);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 24;
            label2.Text = "Search Customer 🔍";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 39);
            label1.Name = "label1";
            label1.Size = new Size(356, 34);
            label1.TabIndex = 23;
            label1.Text = "Customer Management";
            // 
            // tb_customerName
            // 
            tb_customerName.Location = new Point(663, 174);
            tb_customerName.Name = "tb_customerName";
            tb_customerName.Size = new Size(193, 27);
            tb_customerName.TabIndex = 45;
            tb_customerName.TextChanged += tb_customerName_TextChanged;
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(663, 227);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(193, 27);
            tb_phone.TabIndex = 46;
            tb_phone.TextChanged += tb_phone_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 257);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 47;
            label7.Text = "Email :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(663, 280);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(193, 27);
            tb_email.TabIndex = 48;
            tb_email.TextChanged += tb_email_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(663, 310);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 49;
            label9.Text = "Address :";
            // 
            // tb_address
            // 
            tb_address.Location = new Point(663, 333);
            tb_address.Name = "tb_address";
            tb_address.Size = new Size(193, 27);
            tb_address.TabIndex = 50;
            tb_address.TextChanged += tb_address_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(663, 363);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 51;
            label10.Text = "Face Photo :";
            // 
            // pb_facePhoto
            // 
            pb_facePhoto.Location = new Point(663, 386);
            pb_facePhoto.Name = "pb_facePhoto";
            pb_facePhoto.Size = new Size(72, 68);
            pb_facePhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pb_facePhoto.TabIndex = 52;
            pb_facePhoto.TabStop = false;
            pb_facePhoto.Click += pb_facePhoto_Click;
            // 
            // btn_addPhoto
            // 
            btn_addPhoto.Location = new Point(762, 403);
            btn_addPhoto.Name = "btn_addPhoto";
            btn_addPhoto.Size = new Size(94, 29);
            btn_addPhoto.TabIndex = 53;
            btn_addPhoto.Text = "Add Photo";
            btn_addPhoto.UseVisualStyleBackColor = true;
            btn_addPhoto.Click += btn_addPhoto_Click;
            // 
            // cb_vip
            // 
            cb_vip.AutoSize = true;
            cb_vip.Location = new Point(511, 124);
            cb_vip.Name = "cb_vip";
            cb_vip.Size = new Size(133, 24);
            cb_vip.TabIndex = 54;
            cb_vip.Text = "Check if correct";
            cb_vip.UseVisualStyleBackColor = true;
            cb_vip.CheckedChanged += cb_vip_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(511, 98);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 55;
            label6.Text = "VIP? :";
            // 
            // CustomerManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 488);
            Controls.Add(label6);
            Controls.Add(cb_vip);
            Controls.Add(btn_addPhoto);
            Controls.Add(pb_facePhoto);
            Controls.Add(label10);
            Controls.Add(tb_address);
            Controls.Add(label9);
            Controls.Add(tb_email);
            Controls.Add(label7);
            Controls.Add(tb_phone);
            Controls.Add(tb_customerName);
            Controls.Add(btn_reset);
            Controls.Add(label8);
            Controls.Add(tb_customerId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_refresh);
            Controls.Add(btn_remove);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tb_searchCustomer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerManagement";
            Text = "CustomerManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_facePhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_reset;
        private Label label8;
        private TextBox tb_customerId;
        private Label label5;
        private Label label4;
        private Button btn_refresh;
        private Button btn_remove;
        private Button btn_edit;
        private Button btn_add;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox tb_searchCustomer;
        private Label label2;
        private Label label1;
        private TextBox tb_customerName;
        private TextBox tb_phone;
        private Label label7;
        private TextBox tb_email;
        private Label label9;
        private TextBox tb_address;
        private Label label10;
        private PictureBox pb_facePhoto;
        private Button btn_addPhoto;
        private CheckBox cb_vip;
        private Label label6;
    }
}