using System;
using System.Windows.Forms;

namespace Billing.Forms
{
    public partial class MDIMainForm : Form
    {
        public MDIMainForm()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                formTabs.Visible = false; // If no any child form, hide tabControl
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = formTabs;
                    formTabs.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }
                else
                {
                    formTabs.SelectedTab = this.ActiveMdiChild.Tag as TabPage;
                }
                if (!formTabs.Visible)
                    formTabs.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void formTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((formTabs.SelectedTab != null) && (formTabs.SelectedTab.Tag != null))
                (formTabs.SelectedTab.Tag as Form).Select();
        }

        private void itemMaserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateChildForm(typeof(frmItemMaster));
        }

        private void ledgerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivateChildForm(typeof(frmLedgerMaster));
        }
        public void ActivateChildForm(Type frm)
        {
            Form instance = null;
            foreach (var v in this.MdiChildren)
            {
                if (v.GetType() == frm)
                {
                    instance = v as Form;
                    this.ActivateMdiChild((Form)instance);
                    break;
                }
            }
            if (instance == null)
            {
                instance = (Form)Activator.CreateInstance(frm);
                instance.MdiParent = this;
                instance.Show();
            }
        }
    }
}
