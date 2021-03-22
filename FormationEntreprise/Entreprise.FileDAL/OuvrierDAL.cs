using Entreprise.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entreprise.FileDAL
{
    public class OuvrierDAL
    {
        private string _path = @"D:\SMA\Formation\EntrepriseFormation\FormationEntreprise\OuvriersFile.txt";

        public OuvrierDTO ReadLastOuvrier()
        {
            string[] lines = File.ReadAllLines(_path);

            if (lines.Length == 0)
            {

                return new OuvrierDTO() { };
            } 
       

            string[] fields = lines[lines.Length-1].Split(';');

            return new OuvrierDTO()
            {
                Id = Convert.ToInt32(fields[0]),
                Nom = fields[1],
                Prenom = fields[2],
                Age = Convert.ToInt32(fields[3]),
                Email = fields[4],
                NbrH = Convert.ToInt32(fields[5]),
                PrixH = Convert.ToInt32(fields[6])
            };

        }

        public void SaveOuvrier(OuvrierDTO ouvrierDTO)
        {
            string writeRecord;

            writeRecord = ouvrierDTO.Id + ";" + ouvrierDTO.Nom + ";" + ouvrierDTO.Prenom + ";" + ouvrierDTO.Age + ";" + ouvrierDTO.Email + ";" + ouvrierDTO.NbrH + ";" + ouvrierDTO.PrixH;

            if (!File.Exists(_path))
            {

                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(_path))
                {
                    sw.WriteLine(writeRecord);
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine(writeRecord);
            }


            // Open the file to read from.
            using (StreamReader sr = File.OpenText(_path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    //Console.WriteLine(s);
                }
            }

        }
    }
}
