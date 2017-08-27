namespace Billing.Forms.MasterForm
{
    partial class GeneralMDIChild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralMDIChild));
            this.imgTop = new System.Windows.Forms.Panel();
            this.imgCloseRed = new System.Windows.Forms.PictureBox();
            this.imgClose = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.imgTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTop
            // 
            this.imgTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imgTop.Controls.Add(this.imgCloseRed);
            this.imgTop.Controls.Add(this.imgClose);
            this.imgTop.Controls.Add(this.lblCaption);
            this.imgTop.Location = new System.Drawing.Point(0, 0);
            this.imgTop.Name = "imgTop";
            this.imgTop.Size = new System.Drawing.Size(652, 28);
            this.imgTop.TabIndex = 61;
            // 
            // imgCloseRed
            // 
            this.imgCloseRed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgCloseRed.BackgroundImage")));
            this.imgCloseRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCloseRed.Location = new System.Drawing.Point(470, 8);
            this.imgCloseRed.Name = "imgCloseRed";
            this.imgCloseRed.Size = new System.Drawing.Size(42, 18);
            this.imgCloseRed.TabIndex = 69;
            this.imgCloseRed.TabStop = false;
            this.imgCloseRed.Visible = false;
            // 
            // imgClose
            // 
            this.imgClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgClose.BackgroundImage")));
            this.imgClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgClose.Location = new System.Drawing.Point(603, 8);
            this.imgClose.Name = "imgClose";
            this.imgClose.Size = new System.Drawing.Size(42, 18);
            this.imgClose.TabIndex = 1;
            this.imgClose.TabStop = false;
            this.imgClose.Click += new System.EventHandler(this.imgClose_Click);
            this.imgClose.MouseLeave += new System.EventHandler(this.imgClose_MouseLeave);
            this.imgClose.MouseHover += new System.EventHandler(this.imgClose_MouseHover);
            this.imgClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgClose_MouseMove);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaption.Location = new System.Drawing.Point(251, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(41, 17);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Title";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Location = new System.Drawing.Point(23, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(492, 175);
            this.mainPanel.TabIndex = 60;
            // 
            // GeneralMDIChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 334);
            this.ControlBox = false;
            this.Controls.Add(this.imgTop);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "GeneralMDIChild";
            this.ShowInTaskbar = false;
            this.Text = "GeneralMDIChild";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneralMDIChild_KeyDown);
            this.Resize += new System.EventHandler(this.GeneralMDIChild_Resize);
            this.imgTop.ResumeLayout(false);
            this.imgTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCloseRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imgTop;
        private System.Windows.Forms.PictureBox imgCloseRed;
        private System.Windows.Forms.PictureBox imgClose;
        protected System.Windows.Forms.Label lblCaption;
        protected System.Windows.Forms.Panel mainPanel;
    }
}