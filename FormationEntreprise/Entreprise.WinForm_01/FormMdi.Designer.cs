
namespace Entreprise.WinForm_01
{
    partial class FormMdi
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.modalYesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalNoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modalYesToolStripMenuItem,
            this.modalNoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // modalYesToolStripMenuItem
            // 
            this.modalYesToolStripMenuItem.Name = "modalYesToolStripMenuItem";
            this.modalYesToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modalYesToolStripMenuItem.Text = "ModalYes";
            this.modalYesToolStripMenuItem.Click += new System.EventHandler(this.modalYesToolStripMenuItem_Click);
            // 
            // modalNoToolStripMenuItem
            // 
            this.modalNoToolStripMenuItem.Name = "modalNoToolStripMenuItem";
            this.modalNoToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.modalNoToolStripMenuItem.Text = "ModalNo";
            this.modalNoToolStripMenuItem.Click += new System.EventHandler(this.modalNoToolStripMenuItem_Click);
            // 
            // FormMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMdi";
            this.Text = "FormMdi";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem modalYesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalNoToolStripMenuItem;
    }
}