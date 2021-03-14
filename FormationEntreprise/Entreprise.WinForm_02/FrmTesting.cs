using Entreprise.Comparator;
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
    public partial class FrmTesting : Form
    {
        Societe _societe = Societe.CreerSociete();

        public FrmTesting()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*** Ajout de 7 éléments dans la list Travailleur ***");


            try
            {
                _societe.AddTravailleur(1, "Billen", "Nathalie", 30, "Nathalie@gmail.com", 500);
                _societe.AddTravailleur(2, "Baens", "Ludovic", 30, "Ludovic@gmail.com,", 500);
                _societe.AddTravailleur(3, "Aerts", "Christian", 30, "Christian@gmail.com", 500);
                _societe.AddTravailleur(4, "Masset", "Frédéric", 25, "Frédéric@gmail.com", 1200);
                _societe.AddTravailleur(5, "Nadin", "Pascal", 35, "Pascal@gmail.com", 1300);
                _societe.AddTravailleur(6, "Fontana", "Pierre", 40, "Pierre@gmail.com", 1500);
                _societe.AddTravailleur(7, "Vanbelle", "Laurent", 15, "Laurent@gmail.com", 77700);
            }
            catch (EmployeExceptionSalaireTropEleve exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }


           


            MessageBox.Show("Contenu de la liste :");
            foreach (Travailleur item in Societe.CreerSociete())
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire() + " " + item.Email);
            }


            MessageBox.Show("Tri via class TravailleurComparator (Age Desc) : ");
            TravailleurComparator.SortByAgeDesc myCompA = new TravailleurComparator.SortByAgeDesc();
            _societe.travailleurs.Sort(myCompA);

            foreach (Travailleur item in Societe.CreerSociete())
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire() + " " + item.Email);
            }



            MessageBox.Show("Tri via class TravailleurComparator (Age et Name Desc) : ");
            TravailleurComparator.SortByAgeAndNameDesc myCompB = new TravailleurComparator.SortByAgeAndNameDesc();
            _societe.travailleurs.Sort(myCompB);

            foreach (Travailleur item in Societe.CreerSociete())
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire() + " " + item.Email);
            }



            MessageBox.Show("Tri via Sort() (sur Prénom) : IComparable ");
            // Impose d'implémenter l'Interface IComparable pour déterminer la manière de comparer 2 objets Travailleur
            _societe.travailleurs.Sort();

            foreach (Travailleur item in Societe.CreerSociete())
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire() + " " + item.Email);
            }



            MessageBox.Show("Comparaison d'objet via Override Equals ");
            // Impose d'overrider la méthode Equals pour expliquer sur quelles zones comparer.
            if (_societe.travailleurs[0].Equals(_societe.travailleurs[1]))
            {
                MessageBox.Show("Message ==");
            }
            else
            {
                MessageBox.Show("Message !=");
            }


            MessageBox.Show("Comparaison d'objet via Surcharge des Opérateurs == et != ");
            // Impose d'overrider la méthode Equals pour expliquer sur quelles zones comparer.
            if (_societe.travailleurs[0] == (_societe.travailleurs[1]))
            {
                MessageBox.Show("Message ==");
            }
            else
            {
                MessageBox.Show("Message !=");
            }
        }
    }
}



