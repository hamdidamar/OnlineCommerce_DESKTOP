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
    public partial class SignUpForm : Form
    {
        public Companies comp = new Companies();
        ProductForm proForm = new ProductForm();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            comp.Name = txtName.Text.Trim();
            comp.Mail = txtMail.Text.Trim();
            comp.Phone = txtPhone.Text.Trim();
            comp.Fax = txtFax.Text.Trim();
            comp.Address = txtAdress.Text.Trim();
            using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
            {
                db.Companies.Add(comp);
                db.SaveChanges();
            }
            MessageBox.Show("Succsesfully");
            proForm.company_id = comp.ID;
            proForm.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
