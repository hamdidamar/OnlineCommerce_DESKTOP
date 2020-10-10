using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCommerce_Desktop
{
    public partial class ProductForm : Form
    {
        Products productModel = new Products();
        public ProductForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txt_Cost.Text = txt_Name.Text = txt_Price.Text = txt_Stock.Text = " " ;
            btn_Save.Text = "Save";
            btn_Delete.Enabled = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            productModel.ID = 0;
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            productModel.Name = txt_Name.Text.Trim();
            productModel.Cost = decimal.Parse(txt_Cost.Text.Trim());
            productModel.Price = decimal.Parse(txt_Price.Text.Trim());
            productModel.Stock = decimal.Parse(txt_Stock.Text.Trim());
            using (OnlineCommerceEntities db = new OnlineCommerceEntities()) 
            {
                if (productModel.ID == 0)
                    db.Products.Add(productModel);
                else
                    db.Entry(productModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();

            PopulateDataGridView();
            productModel.ID = 0;
            MessageBox.Show("Succesfully");
        }

        void PopulateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;
            using (OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                dgvProduct.DataSource = db.Products.ToList<Products>();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    var entry = db.Entry(productModel);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Products.Attach(productModel);
                    db.Products.Remove(productModel);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    productModel.ID = 0;
                    MessageBox.Show("Deleted succesfully.");
                }
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow.Index != -1)
            {
                productModel.ID = Convert.ToInt32(dgvProduct.CurrentRow.Cells["ID"].Value);
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    productModel = db.Products.Where(x => x.ID == productModel.ID).FirstOrDefault();
                    txt_Name.Text = productModel.Name;
                    txt_Cost.Text = productModel.Cost.ToString();
                    txt_Price.Text = productModel.Price.ToString();
                    txt_Stock.Text = productModel.Stock.ToString();

                }
                btn_Save.Text = "Update";
                btn_Delete.Enabled = true;
            }
        }
    }
}
