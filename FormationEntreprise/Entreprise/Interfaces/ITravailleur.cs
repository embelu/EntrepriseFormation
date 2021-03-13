using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise.Interfaces
{
    public interface ITravailleur
    {
        int Id { get; set; }
        string Nom { get; set; }
        string Prenom { get; set; }
        int Age { get; set; }

        int Salaire();
    }
}
