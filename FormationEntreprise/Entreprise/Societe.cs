using Entreprise.DTO;
using Entreprise.FileDAL;
using Entreprise.Mappers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Entreprise
{
    public class Societe : IEnumerable
    {
        public string Nom { get; set; }
        public int Matricule { get; set; }

        public List<Travailleur> travailleurs = new List<Travailleur>();

        #region Singleton
        private static Societe _societeSingleton;

        public static Societe CreerSociete()
        {
            if (_societeSingleton is null)
            {
                _societeSingleton = new Societe();
            }

            return _societeSingleton;
        }
        #endregion

        public void AddTravailleur(int id, string nom, string prenom, int age, string email, int fixe)
        {
            Employe employe = new Employe(id, nom, prenom, age, email, fixe);
            travailleurs.Add(employe);
        }

        public void AddTravailleur(int id, string nom, string prenom, int age, string email, int nbrHeure, int prixHeure)
        {
            Ouvrier ouvrier = new Ouvrier(id, nom, prenom, age, email, nbrHeure, prixHeure);
            travailleurs.Add(ouvrier);

            OuvrierMapper ouvrierMapper = new OuvrierMapper();
            OuvrierDAL ouvrierDAL = new OuvrierDAL();
            ouvrierDAL.SaveOuvrier(ouvrierMapper.MapToDTO(ouvrier));

        }

        public Ouvrier ReadLastOuvrier()
        {
            OuvrierDAL ouvrierDAL = new OuvrierDAL();
            OuvrierDTO ouvrierDTO = ouvrierDAL.ReadLastOuvrier();

            OuvrierMapper ouvrierMapper = new OuvrierMapper();
            return ouvrierMapper.MapFromDTO(ouvrierDTO);

    
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

        public IEnumerator GetEnumerator()
        {
            return new SocieteEnumerator(ref travailleurs);
        }

        class SocieteEnumerator : IEnumerator
        {
            private List<Travailleur> TravList;
            private int Position;
            public object Current
            {
                get { return TravList[Position++]; }
            }

            public SocieteEnumerator(ref List<Travailleur> myList)
            {
                TravList = myList;
            }

            public bool MoveNext()
            {
                if (Position >= TravList.Count) return false;
                return true;
            }

            public void Reset()
            {
                Position = -1;
            }
        }
    }
}
