using System;

namespace Billing.Forms
{
    public partial class frmLedgerMaster : Billing.Forms.MasterForm.GeneralMDIChild
    {
        public frmLedgerMaster()
        {
            InitializeComponent();
            lblCaption.Text = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
