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
    public partial class AccountForm : Form
    {
        Accounts accounts = new Accounts();
        SignUpForm signUpfrm = new SignUpForm();
        ProductForm proform = new ProductForm();
        CompaniesForm compform = new CompaniesForm();
        public AccountForm()
        {
            InitializeComponent();
        }


        private void rdbCompany_CheckedChanged(object sender, EventArgs e)
        {
            btnSignup.Visible = true;
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            btnSignup.Visible = false;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            rdbAdmin.Checked = true;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            OnlineCommerceEntities2 db = new OnlineCommerceEntities2();

            if (rdbAdmin.Checked)
            {
                Accounts ac = db.Accounts.Where(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text && x.AccountTypeID == 3).SingleOrDefault();

                if (ac == null)
                {
                    MessageBox.Show("No admin found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    compform.ShowDialog();
                }
            }
            else
            {
                Accounts ac = db.Accounts.Where(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text && x.AccountTypeID == 1).SingleOrDefault();

                if (ac == null)
                {
                    MessageBox.Show("No customer found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Companies company = db.Companies.Where(x => x.AccountID == ac.ID).SingleOrDefault();

                    proform.company_id = company.ID;
                    proform.ShowDialog();
                }
            }
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            accounts.Username = txtUsername.Text.Trim();
            accounts.Password = txtPassword.Text.Trim();
            accounts.AccountTypeID = 1;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the boxes");
            }
            else
            {
                using (OnlineCommerceEntities2 db = new OnlineCommerceEntities2())
                {
                    db.Accounts.Add(accounts);
                    db.SaveChanges();
                }
                signUpfrm.comp.AccountID = accounts.ID;
                signUpfrm.Show();
            }
        }
    }
}
