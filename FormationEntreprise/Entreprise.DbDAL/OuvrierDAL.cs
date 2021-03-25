using Entreprise.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Entreprise.DbDAL
{
    public class OuvrierDAL
    {
        private SqlCommand sqlCommand;
        private SqlDataReader myreader;

        private readonly string strConnexion = "Data Source=S319SQLT1\\DEVSQL319;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Initial Catalog = DB_Formation";

        private int count;

        public OuvrierDTO ReadLastOuvrier()
        {
            OuvrierDTO ouvrierDTO = null;

            SqlConnection _connection = new SqlConnection(strConnexion);
            _connection.Open();

            // Compter le nombre de records
            sqlCommand = new SqlCommand("Select count(*) from dbo.Ouvrier_Ludo", _connection);

            myreader = sqlCommand.ExecuteReader();

            myreader.Read();
            count = myreader.GetInt32(0);
            myreader.Close();




            if (count != 0)
            {
                sqlCommand = new SqlCommand("Select * from dbo.Ouvrier_Ludo", _connection);

                myreader = sqlCommand.ExecuteReader();

                for (int i = 0; i <= count-1; i++)
                {
                    myreader.Read();

                    if (i == count-1)
                    {
                        ouvrierDTO = new OuvrierDTO()
                        {
                            Id = Int32.Parse(myreader["Id"].ToString()),
                            Nom = myreader["Nom"].ToString(),
                            Prenom = myreader["Prenom"].ToString(),
                            Age = Int32.Parse(myreader["Age"].ToString()),
                            Email = myreader["Email"].ToString(),
                            NbrH = Int32.Parse(myreader["NbrH"].ToString()),
                            PrixH = Int32.Parse(myreader["PrixH"].ToString())
                        };
                    }
                }
            }
            else
            {
                ouvrierDTO = new OuvrierDTO() { };
            }

            _connection.Close();

            return ouvrierDTO;
        }

        public int SaveOuvrier(OuvrierDTO ouvrierDTO)
        {

            SqlConnection _connection = new SqlConnection(strConnexion);
            _connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Ouvrier_Ludo (Nom, Prenom, Age, Email, NbrH, PrixH) VALUES (@Nom, @Prenom, @Age, @Email, @NbrH, @PrixH);SELECT SCOPE_IDENTITY();", _connection);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Nom", ouvrierDTO.Nom);
            cmd.Parameters.AddWithValue("@Prenom", ouvrierDTO.Prenom);
            cmd.Parameters.AddWithValue("@Age", ouvrierDTO.Age);
            cmd.Parameters.AddWithValue("@Email", ouvrierDTO.Email);
            cmd.Parameters.AddWithValue("@NbrH", ouvrierDTO.NbrH);
            cmd.Parameters.AddWithValue("@PrixH", ouvrierDTO.PrixH);

            //int rowsAffected = cmd.ExecuteNonQuery(); Mis en commentaire car utilisation de l'auto-incrément dans la Db au niveau de l'ID

            return (int)(decimal)cmd.ExecuteScalar(); // Utilisation pour récupérer l'auto-incrément

            _connection.Close();





        }
    }
}
