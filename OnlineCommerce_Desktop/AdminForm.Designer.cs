namespace OnlineCommerce_Desktop
{
    partial class AdminForm
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
            this.btn_Category = new MetroFramework.Controls.MetroButton();
            this.btn_Company = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(326, 95);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(183, 108);
            this.btn_Category.TabIndex = 0;
            this.btn_Category.Text = "Kategori Düzenle";
            this.btn_Category.UseSelectable = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Company
            // 
            this.btn_Company.Location = new System.Drawing.Point(94, 95);
            this.btn_Company.Name = "btn_Company";
            this.btn_Company.Size = new System.Drawing.Size(183, 108);
            this.btn_Company.TabIndex = 1;
            this.btn_Company.Text = "Firma Düzenle";
            this.btn_Company.UseSelectable = true;
            this.btn_Company.Click += new System.EventHandler(this.btn_Company_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::OnlineCommerce_Desktop.Properties.Resources.icons8_close_window_26px_1;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton1.Location = new System.Drawing.Point(569, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 34);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(625, 350);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_Company);
            this.Controls.Add(this.btn_Category);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Category;
        private MetroFramework.Controls.MetroButton btn_Company;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}