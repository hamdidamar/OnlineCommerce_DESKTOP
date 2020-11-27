namespace OnlineCommerce_Desktop
{
    partial class ProductForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Categories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_imageLocation = new MetroFramework.Controls.MetroTextBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.btn_Resim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(71, 451);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 36);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(167, 451);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 36);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(259, 451);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 36);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name :";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(119, 50);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(160, 22);
            this.txt_Name.TabIndex = 4;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Location = new System.Drawing.Point(119, 87);
            this.txt_Cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(160, 22);
            this.txt_Cost.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost :";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(119, 127);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(160, 22);
            this.txt_Price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price :";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(119, 167);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(160, 22);
            this.txt_Stock.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stock :";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeight = 29;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductsName,
            this.Cost,
            this.Price,
            this.Stock,
            this.IDCategory,
            this.Category});
            this.dgvProduct.Location = new System.Drawing.Point(403, 50);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(715, 322);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // ProductsName
            // 
            this.ProductsName.DataPropertyName = "Name";
            this.ProductsName.HeaderText = "Name";
            this.ProductsName.MinimumWidth = 6;
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.ReadOnly = true;
            this.ProductsName.Width = 125;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 125;
            // 
            // IDCategory
            // 
            this.IDCategory.DataPropertyName = "CategoryID";
            this.IDCategory.HeaderText = "Category ID";
            this.IDCategory.MinimumWidth = 6;
            this.IDCategory.Name = "IDCategory";
            this.IDCategory.ReadOnly = true;
            this.IDCategory.Visible = false;
            this.IDCategory.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // cmb_Categories
            // 
            this.cmb_Categories.FormattingEnabled = true;
            this.cmb_Categories.Location = new System.Drawing.Point(119, 213);
            this.cmb_Categories.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Categories.Name = "cmb_Categories";
            this.cmb_Categories.Size = new System.Drawing.Size(160, 24);
            this.cmb_Categories.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category :";
            // 
            // txt_imageLocation
            // 
            // 
            // 
            // 
            this.txt_imageLocation.CustomButton.Image = null;
            this.txt_imageLocation.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txt_imageLocation.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_imageLocation.CustomButton.Name = "";
            this.txt_imageLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_imageLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_imageLocation.CustomButton.TabIndex = 1;
            this.txt_imageLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_imageLocation.CustomButton.UseSelectable = true;
            this.txt_imageLocation.CustomButton.Visible = false;
            this.txt_imageLocation.Lines = new string[0];
            this.txt_imageLocation.Location = new System.Drawing.Point(119, 254);
            this.txt_imageLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_imageLocation.MaxLength = 32767;
            this.txt_imageLocation.Name = "txt_imageLocation";
            this.txt_imageLocation.PasswordChar = '\0';
            this.txt_imageLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_imageLocation.SelectedText = "";
            this.txt_imageLocation.SelectionLength = 0;
            this.txt_imageLocation.SelectionStart = 0;
            this.txt_imageLocation.ShortcutsEnabled = true;
            this.txt_imageLocation.Size = new System.Drawing.Size(160, 23);
            this.txt_imageLocation.TabIndex = 45;
            this.txt_imageLocation.UseSelectable = true;
            this.txt_imageLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_imageLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(102, 298);
            this.image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(177, 118);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 44;
            this.image.TabStop = false;
            // 
            // btn_Resim
            // 
            this.btn_Resim.Location = new System.Drawing.Point(295, 249);
            this.btn_Resim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Resim.Name = "btn_Resim";
            this.btn_Resim.Size = new System.Drawing.Size(39, 28);
            this.btn_Resim.TabIndex = 43;
            this.btn_Resim.Text = "---";
            this.btn_Resim.UseVisualStyleBackColor = true;
            this.btn_Resim.Click += new System.EventHandler(this.btn_Resim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "İmage Location :";
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::OnlineCommerce_Desktop.Properties.Resources.icons8_close_window_26px_1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(1139, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(45, 32);
            this.metroButton1.TabIndex = 47;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1187, 520);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_imageLocation);
            this.Controls.Add(this.image);
            this.Controls.Add(this.btn_Resim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Categories);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Cost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cmb_Categories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private MetroFramework.Controls.MetroTextBox txt_imageLocation;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button btn_Resim;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

