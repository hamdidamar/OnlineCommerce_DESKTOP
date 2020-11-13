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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.ShowDialog();
        }

        private void btn_Company_Click(object sender, EventArgs e)
        {
            CompaniesForm compForm = new CompaniesForm();
            compForm.ShowDialog();
        }
    }
}
