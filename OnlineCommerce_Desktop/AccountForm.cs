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
        AdminForm admfrm = new AdminForm();
        public AccountForm()
        {
            InitializeComponent();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            accounts.Username = txtUsername.Text.Trim();
            accounts.Password = txtPassword.Text.Trim();
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill in the boxes");
            }
            else
            {
                using (OnlineCommerceEntities db = new OnlineCommerceEntities())
                {
                    db.Accounts.Add(accounts);
                    db.SaveChanges();
                }
                admfrm.lblid.Text = accounts.ID.ToString();
                admfrm.Show();
            }
            

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {

        }
    }
}
