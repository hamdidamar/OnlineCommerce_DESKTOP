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
    public partial class AdminForm : Form
    {
        Admins admins = new Admins();
        CompaniesForm companiesForm = new CompaniesForm();

        public AdminForm()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            admins.Mail = txtMail.Text.Trim();
            admins.Name = txtName.Text.Trim();
            admins.Surname = txtSurname.Text.Trim();
            admins.Phone = txtPhone.Text.Trim();
            admins.AccountID = 2;
            using (OnlineCommerceEntities db = new OnlineCommerceEntities())
            {
                db.Admins.Add(admins);
                db.SaveChanges();
            }
            companiesForm.lblid.Text = lblid.Text.ToString();
            MessageBox.Show("Succsesfully");
            companiesForm.Show();
        }
    }
}
