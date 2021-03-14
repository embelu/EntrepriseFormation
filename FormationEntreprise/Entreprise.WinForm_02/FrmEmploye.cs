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
    public partial class FrmEmploye : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmEmploye()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
           
            if (!Int32.TryParse(TBoxId.Text, out int idInt)) { MessageBox.Show("ID non numérique !"); TBoxId.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxNom.Text)) { MessageBox.Show("Nom obligatoire !"); TBoxNom.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxPrenom.Text)) { MessageBox.Show("Prénom obligatoire !"); TBoxPrenom.Focus(); return; };

            if (!Int32.TryParse(TBoxAge.Text, out int ageInt)) { MessageBox.Show("Age non numérique !"); TBoxAge.Focus(); return; };

            if (!Int32.TryParse(TBoxSalaire.Text, out int salaireInt)) { MessageBox.Show("Salaire non numérique !"); TBoxSalaire.Focus(); return; };

            if (string.IsNullOrEmpty(TBoxEmail.Text)) { MessageBox.Show("Email obligatoire !"); TBoxEmail.Focus(); return; };

            try
            {
                _societe.AddTravailleur(idInt, TBoxNom.Text, TBoxPrenom.Text, ageInt, TBoxEmail.Text, salaireInt);
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


    }
}
