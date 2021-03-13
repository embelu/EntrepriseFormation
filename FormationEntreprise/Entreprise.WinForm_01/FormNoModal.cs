using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_01
{
    public partial class FormNoModal : Form
    {
        Societe societe = Societe.CreerSociete();

        public FormNoModal()
        {
            InitializeComponent();
           
        }

        private void TboxMatricule_TextChanged(object sender, EventArgs e)
        {
            LblMatricule.Text = TboxMatricule.Text;
        }

        private void BtnEnvoyer_Click(object sender, EventArgs e)
        {
            societe.Matricule = Int32.Parse(TboxMatricule.Text);
        }
    }
}
