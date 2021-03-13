
namespace Entreprise.WinForm_02
{
    partial class FrmTesting
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
            this.BtnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(311, 194);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(179, 63);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "LANCER LE TEST";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // FrmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnTest);
            this.Name = "FrmTesting";
            this.Text = "FrmTesting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTest;
    }
}