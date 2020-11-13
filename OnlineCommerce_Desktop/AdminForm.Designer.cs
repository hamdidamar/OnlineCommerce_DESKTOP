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
            this.SuspendLayout();
            // 
            // btn_Category
            // 
            this.btn_Category.Location = new System.Drawing.Point(128, 149);
            this.btn_Category.Name = "btn_Category";
            this.btn_Category.Size = new System.Drawing.Size(156, 85);
            this.btn_Category.TabIndex = 0;
            this.btn_Category.Text = "Kategori Düzenle";
            this.btn_Category.UseSelectable = true;
            this.btn_Category.Click += new System.EventHandler(this.btn_Category_Click);
            // 
            // btn_Company
            // 
            this.btn_Company.Location = new System.Drawing.Point(383, 149);
            this.btn_Company.Name = "btn_Company";
            this.btn_Company.Size = new System.Drawing.Size(156, 85);
            this.btn_Company.TabIndex = 1;
            this.btn_Company.Text = "Firma Düzenle";
            this.btn_Company.UseSelectable = true;
            this.btn_Company.Click += new System.EventHandler(this.btn_Company_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 425);
            this.Controls.Add(this.btn_Company);
            this.Controls.Add(this.btn_Category);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Category;
        private MetroFramework.Controls.MetroButton btn_Company;
    }
}