using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace M2L_ProjetWinform
{
    class DBEvenement
    {
        private static string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
        private static MySqlConnection connection = new MySqlConnection(chaineDeconnexion);

        public static List<Evenement> getAllEvent()
        {
            List<Evenement> LesEvents = new List<Evenement>();
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select * from evenement";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[7];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string DateDebut = valeurColonnes[0];
                string DateFin = valeurColonnes[1];
                int idClub = int.Parse(valeurColonnes[3]);
                string nom = valeurColonnes[4];
                int id = int.Parse(valeurColonnes[5]);
                string type = valeurColonnes[6];
                Evenement unEvent = new Evenement(nom, idClub, DateDebut, DateFin, type, id);
                LesEvents.Add(unEvent);
            }
            connection.Close();
            return LesEvents;
        }
        public static void AddEvenement(Evenement unEvent)
        {
            string nom = unEvent.getNom();
            string type = unEvent.getTypeEvent();
            int club = unEvent.getClub();
            string dateDebut = unEvent.getDebut();
            string dateFin = unEvent.getFin(); ;
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "Insert into `evenement` (`nom`,`type`,`idclub`,`DateDebut`,`DateFin`) VALUES('" + nom + "','" + type + "','" + club + "','" + dateDebut + "','" + dateFin + "')";
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
        }
        public static void DeleteEvent(int id)
        {
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "Delete from `evenement` where `id` =" + id;
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
        }

    }
}
