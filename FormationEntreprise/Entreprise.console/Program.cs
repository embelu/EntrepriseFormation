using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreprise.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Societe societe = Societe.CreerSociete();

            societe.Nom = "Solidaris";
            societe.Matricule = 123456;

            Console.WriteLine(societe.Nom + " - " + societe.Matricule);



            societe.AddTravailleur(1, "Roland", "Thierry", 44,"rt@nr.be", 2000);

            societe.AddTravailleur(1, "Charles", "Antoine", 17,"ca@te.be", 150, 20);

            societe.ShowLstTravailleurs();

            Societe societeSingleton = Societe.CreerSociete();
            societeSingleton.ShowLstTravailleurs();

            Console.ReadKey();
        }
    }
}
