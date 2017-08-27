using Billing.Security;
using System;
using System.Windows.Forms;

namespace Billing.Forms
{
    public partial class frmItemMaster : Billing.Forms.MasterForm.GeneralMDIChild
    {
        public frmItemMaster()
        {
            InitializeComponent();
            lblCaption.Text = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string HashPassword = txtHashPassword.Text;
            string SaltPassword = txtSaltPassword.Text;

            if (PasswordHasher.VerifyHashPassword(HashPassword, SaltPassword, txtPassword.Text))
                MessageBox.Show("Varified");
        }

        private void btnHashing_Click(object sender, EventArgs e)
        {
            PasswordHasher obj = new PasswordHasher(txtPassword.Text);
            txtHashPassword.Text = obj.HashPassword;
            txtSaltPassword.Text = obj.SaltPassword;
        }
    }
}
