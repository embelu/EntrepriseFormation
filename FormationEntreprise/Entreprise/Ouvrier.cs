using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise
{
    public class Ouvrier : Travailleur
    {
        private int NbrH { get; set; }
        private int PrixH { get; set; }

        internal Ouvrier(int id, string nom, string prenom, int age, int nbrH, int prixH) : base(id, nom, prenom, age)
        {
            this.NbrH = nbrH;
            this.PrixH = prixH;
        }


        public override int Salaire()
        {
            return PrixH * NbrH;
        }

        public string ShowDetails()
        {
            return this.Id + " - " + this.Nom + " - " + this.Prenom + " - " + this.Age + " - " + this.Salaire();
        }
    }
}
