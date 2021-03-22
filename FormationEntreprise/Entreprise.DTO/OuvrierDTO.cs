using System;

namespace Entreprise.DTO
{
    public class OuvrierDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int NbrH { get; set; }
        public int PrixH { get; set; }
    }
}
