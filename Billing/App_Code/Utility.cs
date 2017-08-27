using System.Windows.Forms;

namespace Billing.App_Code
{
    class Utility
    {
        public void SetTabOrder(Control[] controls, Form frm)
        {
            StopTab(frm.Controls);
            int ind;
            ind = 0;
            foreach (Control cn in controls)
            {
                cn.TabStop = true;
                cn.TabIndex = ind;
                ind = ind + 1;
            }
        }
        public void StopTab(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (Control cn in controls)
            {
                cn.TabStop = false;
                if (cn.HasChildren)
                    StopTab(cn.Controls);
            }
        }
        public void DesignMe(Form frm)
        {

        }
    }
}
