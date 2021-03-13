
namespace Entreprise.WinForm_02
{
    partial class FrmEmploye
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
            this.TBoxSalaire = new System.Windows.Forms.TextBox();
            this.TBoxAge = new System.Windows.Forms.TextBox();
            this.TBoxPrenom = new System.Windows.Forms.TextBox();
            this.TBoxNom = new System.Windows.Forms.TextBox();
            this.TBoxId = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBoxSalaire
            // 
            this.TBoxSalaire.Location = new System.Drawing.Point(260, 228);
            this.TBoxSalaire.Name = "TBoxSalaire";
            this.TBoxSalaire.Size = new System.Drawing.Size(119, 22);
            this.TBoxSalaire.TabIndex = 23;
            // 
            // TBoxAge
            // 
            this.TBoxAge.Location = new System.Drawing.Point(260, 180);
            this.TBoxAge.Name = "TBoxAge";
            this.TBoxAge.Size = new System.Drawing.Size(66, 22);
            this.TBoxAge.TabIndex = 22;
            // 
            // TBoxPrenom
            // 
            this.TBoxPrenom.Location = new System.Drawing.Point(260, 132);
            this.TBoxPrenom.Name = "TBoxPrenom";
            this.TBoxPrenom.Size = new System.Drawing.Size(341, 22);
            this.TBoxPrenom.TabIndex = 21;
            // 
            // TBoxNom
            // 
            this.TBoxNom.Location = new System.Drawing.Point(260, 80);
            this.TBoxNom.Name = "TBoxNom";
            this.TBoxNom.Size = new System.Drawing.Size(341, 22);
            this.TBoxNom.TabIndex = 20;
            // 
            // TBoxId
            // 
            this.TBoxId.Location = new System.Drawing.Point(260, 35);
            this.TBoxId.Name = "TBoxId";
            this.TBoxId.Size = new System.Drawing.Size(66, 22);
            this.TBoxId.TabIndex = 19;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(460, 360);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(200, 66);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(100, 360);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(200, 66);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Salaire :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id : ";
            // 
            // TBoxEmail
            // 
            this.TBoxEmail.Location = new System.Drawing.Point(260, 278);
            this.TBoxEmail.Name = "TBoxEmail";
            this.TBoxEmail.Size = new System.Drawing.Size(219, 22);
            this.TBoxEmail.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Email :";
            // 
            // FrmEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBoxEmail);
            this.Controls.Add(this.TBoxSalaire);
            this.Controls.Add(this.TBoxAge);
            this.Controls.Add(this.TBoxPrenom);
            this.Controls.Add(this.TBoxNom);
            this.Controls.Add(this.TBoxId);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmploye";
            this.Text = "FrmEmploye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBoxSalaire;
        private System.Windows.Forms.TextBox TBoxAge;
        private System.Windows.Forms.TextBox TBoxPrenom;
        private System.Windows.Forms.TextBox TBoxNom;
        private System.Windows.Forms.TextBox TBoxId;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxEmail;
        private System.Windows.Forms.Label label7;
    }
}