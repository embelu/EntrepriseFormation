using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entreprise.WinForm_02
{
    public partial class FrmEmploye : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmEmploye()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _societe.AddTravailleur(Int32.Parse(TBoxId.Text), TBoxNom.Text, TBoxPrenom.Text, Int32.Parse(TBoxAge.Text),TBoxEmail.Text, Int32.Parse(TBoxSalaire.Text));
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
