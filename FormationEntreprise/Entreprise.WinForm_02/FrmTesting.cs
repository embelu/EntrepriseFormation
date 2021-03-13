using Entreprise.Comparator;
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
            _societe.AddTravailleur(1, "Billen", "Nathalie", 30, 500);
            _societe.AddTravailleur(2, "Baens", "Ludovic", 30, 500);
            _societe.AddTravailleur(3, "Aerts", "Christian", 30, 500);
            _societe.AddTravailleur(4, "Masset", "Frédéric", 25, 1200);
            _societe.AddTravailleur(5, "Nadin", "Pascal", 35, 1300);
            _societe.AddTravailleur(6, "Fontana", "Pierre", 40, 1500);
            _societe.AddTravailleur(7, "Vanbelle", "Laurent", 15, 700);

            MessageBox.Show("Contenu de la liste :");
            foreach (var item in _societe.travailleurs)
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire());
            }



            MessageBox.Show("Tri via class TravailleurComparator (Age Desc) : ");
            TravailleurComparator.SortByAgeDesc myCompA = new TravailleurComparator.SortByAgeDesc();
            _societe.travailleurs.Sort(myCompA);

            foreach (var item in _societe.travailleurs)
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire());
            }



            MessageBox.Show("Tri via class TravailleurComparator (Age et Name Desc) : ");
            TravailleurComparator.SortByAgeAndNameDesc myCompB = new TravailleurComparator.SortByAgeAndNameDesc();
            _societe.travailleurs.Sort(myCompB);

            foreach (var item in _societe.travailleurs)
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire());
            }



            MessageBox.Show("Tri via Sort() (sur Prénom) : IComparable ");
            // Impose d'implémenter l'Interface IComparable pour déterminer la manière de comparer 2 objets Travailleur
            _societe.travailleurs.Sort();

            foreach (var item in _societe.travailleurs)
            {
                MessageBox.Show(item.Id + " " + item.Nom + " " + item.Prenom + " " + item.Age + " " + item.Salaire());
            }
        }
    }
}



