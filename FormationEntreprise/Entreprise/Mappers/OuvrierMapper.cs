using Entreprise.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entreprise.Mappers
{
    public class OuvrierMapper
    {
        public OuvrierDTO MapToDTO (Ouvrier ouvrier)
        {
            OuvrierDTO ouvrierDTO = new OuvrierDTO();

            ouvrierDTO.Id = ouvrier.Id;
            ouvrierDTO.Nom = ouvrier.Nom;
            ouvrierDTO.Prenom = ouvrier.Prenom;
            ouvrierDTO.Age = ouvrier.Age;
            ouvrierDTO.Email = ouvrier.Email;
            ouvrierDTO.NbrH = ouvrier.NbrH;
            ouvrierDTO.PrixH = ouvrier.PrixH;

            return ouvrierDTO;
        }

        public Ouvrier MapFromDTO(OuvrierDTO ouvrierDTO)
        {
            Ouvrier ouvrier = new Ouvrier();

            ouvrier.Id = ouvrierDTO.Id;
            ouvrier.Nom = ouvrierDTO.Nom;
            ouvrier.Prenom = ouvrierDTO.Prenom;
            ouvrier.Age = ouvrierDTO.Age;
            ouvrier.Email = ouvrierDTO.Email;
            ouvrier.NbrH = ouvrierDTO.NbrH;
            ouvrier.PrixH = ouvrierDTO.PrixH;

            return ouvrier;

        }
    }
}
    