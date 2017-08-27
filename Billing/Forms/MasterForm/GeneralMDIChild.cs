using System;
using System.Windows.Forms;

namespace Billing.Forms.MasterForm
{
    public partial class GeneralMDIChild : Form
    {
        public GeneralMDIChild()
        {
            InitializeComponent();
        }

        private void GeneralMDIChild_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void GeneralMDIChild_Resize(object sender, EventArgs e)
        {
            this.imgTop.Top = 0;
            this.mainPanel.Top = this.imgTop.Top + this.imgTop.Height;
            this.imgTop.Width = this.mainPanel.Width;
            this.imgTop.Left = (this.Width - this.mainPanel.Width) / 2;
            this.mainPanel.Left = (this.Width - this.mainPanel.Width) / 2;
            this.lblCaption.Top = (this.imgTop.Height - this.lblCaption.Height) / 2;
            this.lblCaption.Left = (this.imgTop.Width - this.lblCaption.Width) / 2;
            this.imgClose.Top = (this.imgTop.Height - imgClose.Height) / 2;
            this.imgClose.Left = (this.imgTop.Width - this.imgClose.Width - 10);
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imgClose_MouseMove(object sender, MouseEventArgs e)
        {
            this.imgClose.BackgroundImage = ((System.Drawing.Image)(new System.Resources.ResourceManager(typeof(GeneralMDIChild)).GetObject("imgCloseRed.BackgroundImage")));
        }

        private void imgClose_MouseHover(object sender, EventArgs e)
        {
            this.imgClose.BackgroundImage = ((System.Drawing.Image)(new System.Resources.ResourceManager(typeof(GeneralMDIChild)).GetObject("imgCloseRed.BackgroundImage")));
        }

        private void imgClose_MouseLeave(object sender, EventArgs e)
        {
            this.imgClose.BackgroundImage = ((System.Drawing.Image)(new System.Resources.ResourceManager(typeof(GeneralMDIChild)).GetObject("imgClose.BackgroundImage")));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult dr = MessageBox.Show("Are U Sure to Close This Window?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }
    }
}
