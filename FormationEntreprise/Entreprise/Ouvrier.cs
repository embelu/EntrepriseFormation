using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise
{
    public class Ouvrier : Travailleur
    {
        public int NbrH { get; set; }
        public int PrixH { get; set; }

        internal Ouvrier() : base()
        {
        }

        internal Ouvrier(int id, string nom, string prenom, int age, string email, int nbrH, int prixH) : base(id, nom, prenom, age, email)
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
            return this.Id + " - " + this.Nom + " - " + this.Prenom + " - " + this.Age + " - " + this.Email + " - " + this.Salaire();
        }
    }
}
