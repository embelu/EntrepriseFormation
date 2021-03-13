﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise
{
    public class Employe : Travailleur
    {
        private int Fixe { get; set; }

        internal Employe(int id, string nom, string prenom, int age, string email, int fixe) : base(id, nom, prenom, age, email)
        {
            this.Fixe = fixe;
        }

        public override int Salaire()
        {
            return Fixe;
        }

        public string ShowDetails()
        {
            return this.Id + " - " + this.Nom + " - " + this.Prenom + " - " + this.Age + " - " + this.Email + " - " + this.Salaire();
        }
    }

}
