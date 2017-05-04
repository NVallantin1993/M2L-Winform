using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace M2L_ProjetWinform
{
    class DBClub
    {
        private static string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
        private static MySqlConnection connection = new MySqlConnection(chaineDeconnexion);

        public static List<Club> GetAllClub()
        {
            List<Club> LesClubs = new List<Club>();
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from club";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[7];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string nom = valeurColonnes[0];
                string site = valeurColonnes[1];
                string adress = valeurColonnes[2];
                string telephone = valeurColonnes[3];
                string email = valeurColonnes[4];
                string type = valeurColonnes[5];
                int id = int.Parse(valeurColonnes[6]);
                Club unClub = new Club(nom, site, adress, telephone, email, type, id);
                LesClubs.Add(unClub);
            }
            connection.Close();
            return LesClubs;
        }
        // récupere la liste des adherent d'un club
        // Recupere le nombre d'adherent a un club donnée
        public static void setClubAdherent(Club unClub)
        {
            int idclub = unClub.getId();
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select count(*) from license where idclub = " + idclub;
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[1];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                unClub.setAdhe(int.Parse(valeurColonnes[0]));
            }
            connection.Close();
        }
        //Suppresion d'un adherent
        // Ajout d'un Club
        public static void AjouterClub(Club unClub)
        {
            string nom = unClub.getNom();
            string site = unClub.getSite();
            string telephone = unClub.getTelephone();
            string adresse = unClub.getAdresse();
            string email = unClub.getEmail();
            string type = unClub.getType();
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "Insert into `club` (`nom`,`site`,`adresse`,`telephone`,`email`,`type`) VALUES('" + nom + "','" + site + "','" + adresse + "','" + telephone + "','" + email + "','" + type + "')";
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
        }
    }
}
