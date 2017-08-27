namespace Billing.Forms
{
    partial class frmItemMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnHashing = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSaltPassword = new System.Windows.Forms.TextBox();
            this.txtHashPassword = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.Location = new System.Drawing.Point(279, 5);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.txtHashPassword);
            this.mainPanel.Controls.Add(this.txtSaltPassword);
            this.mainPanel.Controls.Add(this.txtPassword);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.btnHashing);
            this.mainPanel.Location = new System.Drawing.Point(87, 28);
            this.mainPanel.Size = new System.Drawing.Size(600, 175);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Varify me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHashing
            // 
            this.btnHashing.Location = new System.Drawing.Point(17, 108);
            this.btnHashing.Name = "btnHashing";
            this.btnHashing.Size = new System.Drawing.Size(87, 23);
            this.btnHashing.TabIndex = 1;
            this.btnHashing.Text = "Hashing";
            this.btnHashing.UseVisualStyleBackColor = true;
            this.btnHashing.Click += new System.EventHandler(this.btnHashing_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 2;
            // 
            // txtSaltPassword
            // 
            this.txtSaltPassword.Location = new System.Drawing.Point(402, 87);
            this.txtSaltPassword.Name = "txtSaltPassword";
            this.txtSaltPassword.Size = new System.Drawing.Size(100, 21);
            this.txtSaltPassword.TabIndex = 3;
            // 
            // txtHashPassword
            // 
            this.txtHashPassword.Location = new System.Drawing.Point(402, 125);
            this.txtHashPassword.Name = "txtHashPassword";
            this.txtHashPassword.Size = new System.Drawing.Size(100, 21);
            this.txtHashPassword.TabIndex = 4;
            // 
            // frmItemMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 462);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmItemMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHashing;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHashPassword;
        private System.Windows.Forms.TextBox txtSaltPassword;
    }
}