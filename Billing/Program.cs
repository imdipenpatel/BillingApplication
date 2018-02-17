using System;
using System.Windows.Forms;

namespace Billing
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Billing.Forms.frmLogin fLogin = new Billing.Forms.frmLogin();
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Billing.Forms.MDIMainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
