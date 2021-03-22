using Entreprise.Exceptions;
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
    public partial class FrmOuvrier : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmOuvrier()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(TBoxId.Text, out int idInt)) { MessageBox.Show("ID non numérique !"); TBoxId.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxNom.Text)) { MessageBox.Show("Nom obligatoire !"); TBoxNom.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxPrenom.Text)) { MessageBox.Show("Prénom obligatoire !"); TBoxPrenom.Focus(); return; };

            if (!Int32.TryParse(TBoxAge.Text, out int ageInt)) { MessageBox.Show("Age non numérique !"); TBoxAge.Focus(); return; };

            if (!Int32.TryParse(TBoxNbrH.Text, out int nbrHInt)) { MessageBox.Show("Nbr d'heures non numérique !"); TBoxNbrH.Focus(); return; };

            if (!Int32.TryParse(TBoxTauxH.Text, out int tauxHInt)) { MessageBox.Show("Taux horaire non numérique !"); TBoxTauxH.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxEmail.Text)) { MessageBox.Show("Email obligatoire !"); TBoxEmail.Focus(); return; };

            try
            {
                _societe.AddTravailleur(idInt, TBoxNom.Text, TBoxPrenom.Text, ageInt, TBoxEmail.Text, nbrHInt, tauxHInt);
            }
            catch (TravailleurExceptionValidationEmail exc)
            {
                MessageBox.Show(exc.Message);
                TBoxEmail.Focus();
                return;
            }
            catch (Exception)
            {
                throw;
            }

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLastRecord_Click(object sender, EventArgs e)
        {
            Ouvrier ouvrier =  _societe.ReadLastOuvrier();

            if (ouvrier.Id == 0)
            {
                MessageBox.Show("Pas d'ouvrier présent dans la base de données !");
                return;
            }

            TBoxId.Text = ouvrier.Id.ToString();
            TBoxNom.Text = ouvrier.Nom;
            TBoxPrenom.Text = ouvrier.Prenom;
            TBoxAge.Text = ouvrier.Age.ToString();
            TBoxEmail.Text = ouvrier.Email;
            TBoxNbrH.Text = ouvrier.NbrH.ToString();
            TBoxTauxH.Text = ouvrier.PrixH.ToString();      
        }
    }
}
