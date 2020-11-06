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
        public int company_id;
        int categoryId = -1;
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
            PopulateComboBox();
            PopulateDataGridView();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            OnlineCommerceEntities2 db = new OnlineCommerceEntities2();
            
            Categories category = db.Categories.Where(x => x.Name == cmb_Categories.Text).SingleOrDefault();
            productModel.CategoryID = category.ID;
            productModel.CompanyID = company_id;
            productModel.Name = txt_Name.Text.Trim();
            productModel.Cost = decimal.Parse(txt_Cost.Text.Trim());
            productModel.Price = decimal.Parse(txt_Price.Text.Trim());
            productModel.Stock = decimal.Parse(txt_Stock.Text.Trim());

            if (productModel.ID == 0)
                db.Products.Add(productModel);
            else
                db.Entry(productModel).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            Clear();

            PopulateDataGridView();
            productModel.ID = 0;
            MessageBox.Show("Succesfully");
        }

        void PopulateDataGridView()
        {
            dgvProduct.AutoGenerateColumns = false;
            using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
            {
                dgvProduct.DataSource = db.Products.Where(x => x.CompanyID == company_id).ToList<Products>();
                for (int i = 0; i < dgvProduct.RowCount; i++)
                {
                    DataGridViewRow a = new DataGridViewRow();
                    int tempCategoryID = Convert.ToInt32(dgvProduct.Rows[i].Cells[5].Value);
                    Categories category = db.Categories.Where(x => x.ID == tempCategoryID).SingleOrDefault();
                    dgvProduct.Rows[i].Cells[6].Value = category.Name;
                }
            }

           

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
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
                using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
                {
                    productModel = db.Products.Where(x => x.ID == productModel.ID).FirstOrDefault();
                    txt_Name.Text = productModel.Name;
                    txt_Cost.Text = productModel.Cost.ToString();
                    txt_Price.Text = productModel.Price.ToString();
                    txt_Stock.Text = productModel.Stock.ToString();
                    categoryId = Convert.ToInt32(productModel.CategoryID);

                    //cmb_Categories.Text = productModel.Categories.Name.ToString();
                    /*
                    label6.Text = categories.Name;*/

                }
                CategoryIdControl();
                btn_Save.Text = "Update";
                btn_Delete.Enabled = true;
            }
        }

        public void CategoryIdControl()
        {
            OnlineCommerceEntities2 db = new OnlineCommerceEntities2();
            if (categoryId != -1)
            {
                Categories categories = db.Categories.Where(x => x.ID == productModel.CategoryID).SingleOrDefault();
                cmb_Categories.Text = categories.Name;
            }
        }
        void PopulateComboBox()
        {
            using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
            {
                var tempList = (from x in db.Categories
                           select new
                                {
                                    x.ID,
                                    x.Name
                                }).ToList();
                cmb_Categories.DataSource = tempList;
                cmb_Categories.DisplayMember = "Name";
                cmb_Categories.ValueMember = "ID";
            }

        }
    }
}
