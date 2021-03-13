using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise
{
    public class Societe
    {
        public string Nom { get; set; }
        public int Matricule { get; set; }

        public List<Travailleur> travailleurs = new List<Travailleur>();


        public void AddTravailleur(int id, string nom, string prenom, int age, int fixe)
        {
            Employe employe = new Employe(id, nom, prenom, age, fixe);
            travailleurs.Add(employe);
        }

        public void AddTravailleur(int id, string nom, string prenom, int age, int nbrHeure, int prixHeure)
        {
            Ouvrier ouvrier = new Ouvrier(id, nom, prenom, age, nbrHeure, prixHeure);
            travailleurs.Add(ouvrier);
        }

        public void ShowLstTravailleurs()
        {
            foreach (Travailleur item in travailleurs)
            {
                if (item is Employe)
                {
                    Employe employe = (Employe)item;
                    Console.WriteLine(employe.ShowDetails());
                }

                if (item is Ouvrier)
                {
                    Ouvrier ouvrier = (Ouvrier)item;
                    Console.WriteLine(ouvrier.ShowDetails());
                }
            }
        }
    }
}
