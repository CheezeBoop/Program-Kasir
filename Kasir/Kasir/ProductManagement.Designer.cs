namespace Kasir
{
    partial class ProductManagement
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
            label1 = new Label();
            label2 = new Label();
            tb_searchProduct = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            btn_add = new Button();
            btn_edit = new Button();
            btn_remove = new Button();
            btn_refresh = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_kode = new TextBox();
            tb_productName = new TextBox();
            tb_price = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tb_stock = new TextBox();
            label9 = new Label();
            cb_unit = new ComboBox();
            cb_category = new ComboBox();
            btn_reset = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(537, 39);
            label1.Name = "label1";
            label1.Size = new Size(330, 34);
            label1.TabIndex = 0;
            label1.Text = "Product Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 51);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "Search Product 🔍";
            // 
            // tb_searchProduct
            // 
            tb_searchProduct.Location = new Point(182, 46);
            tb_searchProduct.Name = "tb_searchProduct";
            tb_searchProduct.Size = new Size(178, 27);
            tb_searchProduct.TabIndex = 2;
            tb_searchProduct.TextChanged += tb_searchProduct_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(674, 221);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 4;
            label3.Text = "List of products :";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(740, 131);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 5;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(740, 166);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 29);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(740, 201);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(94, 29);
            btn_remove.TabIndex = 7;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new Point(366, 45);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(94, 29);
            btn_refresh.TabIndex = 8;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 376);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 9;
            label4.Text = "Kode (Unique) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 427);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 10;
            label5.Text = "Product Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(332, 376);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 11;
            label6.Text = "Price :";
            // 
            // tb_kode
            // 
            tb_kode.Location = new Point(168, 373);
            tb_kode.Name = "tb_kode";
            tb_kode.Size = new Size(149, 27);
            tb_kode.TabIndex = 12;
            tb_kode.TextChanged += tb_kode_TextChanged;
            // 
            // tb_productName
            // 
            tb_productName.Location = new Point(167, 424);
            tb_productName.Name = "tb_productName";
            tb_productName.Size = new Size(150, 27);
            tb_productName.TabIndex = 13;
            tb_productName.TextChanged += tb_productName_TextChanged;
            // 
            // tb_price
            // 
            tb_price.Location = new Point(386, 373);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(149, 27);
            tb_price.TabIndex = 14;
            tb_price.TextChanged += tb_price_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 376);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 15;
            label7.Text = "Category :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 427);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 17;
            label8.Text = "Stock :";
            // 
            // tb_stock
            // 
            tb_stock.Location = new Point(386, 424);
            tb_stock.Name = "tb_stock";
            tb_stock.Size = new Size(149, 27);
            tb_stock.TabIndex = 18;
            tb_stock.TextChanged += tb_stock_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(553, 427);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 19;
            label9.Text = "Unit :";
            // 
            // cb_unit
            // 
            cb_unit.FormattingEnabled = true;
            cb_unit.Location = new Point(635, 424);
            cb_unit.Name = "cb_unit";
            cb_unit.Size = new Size(149, 28);
            cb_unit.TabIndex = 20;
            cb_unit.SelectedIndexChanged += cb_unit_SelectedIndexChanged;
            // 
            // cb_category
            // 
            cb_category.FormattingEnabled = true;
            cb_category.Location = new Point(635, 373);
            cb_category.Name = "cb_category";
            cb_category.Size = new Size(149, 28);
            cb_category.TabIndex = 21;
            cb_category.SelectedIndexChanged += cb_category_SelectedIndexChanged;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(740, 236);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(94, 29);
            btn_reset.TabIndex = 22;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 487);
            Controls.Add(btn_reset);
            Controls.Add(cb_category);
            Controls.Add(cb_unit);
            Controls.Add(label9);
            Controls.Add(tb_stock);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(tb_price);
            Controls.Add(tb_productName);
            Controls.Add(tb_kode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_refresh);
            Controls.Add(btn_remove);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(tb_searchProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductManagement";
            Text = "ProductManagement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tb_searchProduct;
        private DataGridView dataGridView1;
        private Label label3;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_remove;
        private Button btn_refresh;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_kode;
        private TextBox tb_productName;
        private TextBox tb_price;
        private Label label7;
        private Label label8;
        private TextBox tb_stock;
        private Label label9;
        private ComboBox cb_unit;
        private ComboBox cb_category;
        private Button btn_reset;
    }
}