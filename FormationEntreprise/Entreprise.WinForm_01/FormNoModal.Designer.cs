
namespace Entreprise.WinForm_01
{
    partial class FormNoModal
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
            this.LblMatricule = new System.Windows.Forms.Label();
            this.BtnEnvoyer = new System.Windows.Forms.Button();
            this.TboxMatricule = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblMatricule
            // 
            this.LblMatricule.AutoSize = true;
            this.LblMatricule.Location = new System.Drawing.Point(44, 147);
            this.LblMatricule.Name = "LblMatricule";
            this.LblMatricule.Size = new System.Drawing.Size(46, 17);
            this.LblMatricule.TabIndex = 5;
            this.LblMatricule.Text = "label1";
            // 
            // BtnEnvoyer
            // 
            this.BtnEnvoyer.Location = new System.Drawing.Point(44, 72);
            this.BtnEnvoyer.Name = "BtnEnvoyer";
            this.BtnEnvoyer.Size = new System.Drawing.Size(163, 42);
            this.BtnEnvoyer.TabIndex = 4;
            this.BtnEnvoyer.Text = "ENVOYER";
            this.BtnEnvoyer.UseVisualStyleBackColor = true;
            this.BtnEnvoyer.Click += new System.EventHandler(this.BtnEnvoyer_Click);
            // 
            // TboxMatricule
            // 
            this.TboxMatricule.Location = new System.Drawing.Point(44, 26);
            this.TboxMatricule.Name = "TboxMatricule";
            this.TboxMatricule.Size = new System.Drawing.Size(163, 22);
            this.TboxMatricule.TabIndex = 3;
            this.TboxMatricule.TextChanged += new System.EventHandler(this.TboxMatricule_TextChanged);
            // 
            // FormNoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblMatricule);
            this.Controls.Add(this.BtnEnvoyer);
            this.Controls.Add(this.TboxMatricule);
            this.Name = "FormNoModal";
            this.Text = "FormEntreprise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMatricule;
        private System.Windows.Forms.Button BtnEnvoyer;
        private System.Windows.Forms.TextBox TboxMatricule;
    }
}