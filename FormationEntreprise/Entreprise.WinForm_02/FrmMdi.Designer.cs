
namespace Entreprise.WinForm_02
{
    partial class FrmMdi
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
            this.creationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrepriseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationToolStripMenuItem,
            this.listeToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // creationToolStripMenuItem
            // 
            this.creationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrepriseToolStripMenuItem,
            this.employeToolStripMenuItem,
            this.ouvrierToolStripMenuItem});
            this.creationToolStripMenuItem.Name = "creationToolStripMenuItem";
            this.creationToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.creationToolStripMenuItem.Text = "Création";
            // 
            // entrepriseToolStripMenuItem
            // 
            this.entrepriseToolStripMenuItem.Name = "entrepriseToolStripMenuItem";
            this.entrepriseToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.entrepriseToolStripMenuItem.Text = "Entreprise";
            this.entrepriseToolStripMenuItem.Click += new System.EventHandler(this.entrepriseToolStripMenuItem_Click);
            // 
            // employeToolStripMenuItem
            // 
            this.employeToolStripMenuItem.Name = "employeToolStripMenuItem";
            this.employeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.employeToolStripMenuItem.Text = "Employé";
            this.employeToolStripMenuItem.Click += new System.EventHandler(this.employeToolStripMenuItem_Click);
            // 
            // ouvrierToolStripMenuItem
            // 
            this.ouvrierToolStripMenuItem.Name = "ouvrierToolStripMenuItem";
            this.ouvrierToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.ouvrierToolStripMenuItem.Text = "Ouvrier";
            this.ouvrierToolStripMenuItem.Click += new System.EventHandler(this.ouvrierToolStripMenuItem_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            this.listeToolStripMenuItem.Click += new System.EventHandler(this.listeToolStripMenuItem_Click);
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.testingToolStripMenuItem.Text = "Testing";
            this.testingToolStripMenuItem.Click += new System.EventHandler(this.testingToolStripMenuItem_Click);
            // 
            // FrmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.menuStrip);
            this.Name = "FrmMdi";
            this.Text = "FrmMdi";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem creationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrepriseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
    }
}