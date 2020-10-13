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
    public partial class CompaniesForm : Form
    {
        Companies companies = new Companies();


        public CompaniesForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtMail.Text = "";
            txtAdres.Text = "";
            txtFax.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            companies.Name = txtName.Text.Trim();
            companies.Phone = txtPhone.Text.Trim();
            companies.Mail = txtMail.Text.Trim();
            companies.Fax = txtFax.Text.Trim();
            companies.Address = txtAdres.Text.Trim();
            companies.AccountID = 18;
            using (OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                if (companies.ID==0)
                    db.Companies.Add(companies);
                else
                    db.Entry(companies).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            MessageBox.Show("Succesfully");
            Clear();
            companies.ID = 0;
            PopulateDataGridView();
        }


        void PopulateDataGridView()
        {
            dgvCompanies.AutoGenerateColumns = false;
            using (OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                dgvCompanies.DataSource = db.Companies.ToList<Companies>();
            }
        }



        private void CompaniesForm_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }



        private void dgvCompanies_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCompanies.CurrentRow.Index != -1)
            {
                companies.ID = Convert.ToInt32(dgvCompanies.CurrentRow.Cells["ID"].Value);
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    companies = db.Companies.Where(x => x.ID == companies.ID).FirstOrDefault();
                    txtName.Text = companies.Name;
                    txtPhone.Text = companies.Phone;
                    txtMail.Text = companies.Mail;
                    txtAdres.Text = companies.Address;
                    txtFax.Text = companies.Fax;

                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    var entry = db.Entry(companies);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Companies.Attach(companies);
                    db.Companies.Remove(companies);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    companies.ID = 0;
                    MessageBox.Show("Deleted succesfully.");
                }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
