using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCommerce_Desktop
{
    public partial class CategoryForm : Form
    {
        Categories categoryModel = new Categories();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }
        void Clear()
        {
            txt_Name.Text = " ";
            btn_Save.Text = "Save";
            btn_Delete.Enabled = false;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            categoryModel.Name = txt_Name.Text.Trim();
            using (OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                if (categoryModel.ID == 0)
                    db.Categories.Add(categoryModel);
                else
                    db.Entry(categoryModel).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            categoryModel.ID = 0;
            MessageBox.Show("Succesfully");

        }

        void PopulateDataGridView()
        {
            dgvCategory.AutoGenerateColumns = false;
            using(OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                dgvCategory.DataSource = db.Categories.ToList<Categories>();
            }
        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCategory.CurrentRow.Index != -1)
            {
                categoryModel.ID = Convert.ToInt32(dgvCategory.CurrentRow.Cells["ID"].Value);
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    categoryModel = db.Categories.Where(x => x.ID == categoryModel.ID).FirstOrDefault();
                    txt_Name.Text = categoryModel.Name;
                }
                btn_Save.Text = "Update";
                btn_Delete.Enabled = true;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Warning",MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    var entry = db.Entry(categoryModel);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Categories.Attach(categoryModel);
                    db.Categories.Remove(categoryModel);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    categoryModel.ID = 0;
                    MessageBox.Show("Deleted succesfully.");
                }
            
        }
    }
}
