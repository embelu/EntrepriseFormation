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
            Societe societe = new Societe();

            societe.Nom = "Solidaris";
            societe.Matricule = 123456;

            Console.WriteLine(societe.Nom + " - " + societe.Matricule);



            societe.AddTravailleur(1, "Roland", "Thierry", 44, 2000);

            societe.AddTravailleur(1, "Charles", "Antoine", 17, 150, 20);

            societe.ShowLstTravailleurs();

            Console.ReadKey();
        }
    }
}
