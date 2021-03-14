using Entreprise.Exceptions;
using Entreprise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Entreprise
{
    public abstract class Travailleur : ITravailleur, IComparable, IEquatable<Travailleur>
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }



        internal Travailleur(int id, string nom, string prenom, int age, string email)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Age = age;
            this.Email = email;

            Match myMatch = Regex.Match(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!myMatch.Success)
            {
                throw new TravailleurExceptionValidationEmail("Email incorrect : " + email);
            }
        }


        // Méthode abstract qui devra être implémentée dans les classes qui héritent de Travailleur
        public abstract int Salaire();

        public int CompareTo(object obj)
        {
            Travailleur travailleurTemp = obj as Travailleur;

            return string.Compare(this.Prenom, travailleurTemp.Prenom);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            // Travailleur travailleur = (Travailleur) obj;
            Travailleur travailleur = obj as Travailleur;

            if (travailleur == null) return false;

            if (this.Nom == travailleur.Nom && this.Prenom == travailleur.Prenom)
            {
                return true;
            }
            else
            {
                return false;
            };
        }


        // La méthode ci-dessous remplace la méthode Equals ci dessus
        public bool Equals(Travailleur travailleur)
        {
            if (this.Nom == travailleur.Nom && this.Prenom == travailleur.Prenom)
            {
                return true;
            }
            else
            {
                return false;
            };
        }

        public static bool operator !=(Travailleur t1, Travailleur t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator ==(Travailleur t1, Travailleur t2)
        {
            return t1.Equals(t2);
        }


    }
}
