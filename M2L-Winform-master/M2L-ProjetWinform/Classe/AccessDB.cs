using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace M2L_ProjetWinform
{
    class AccessDB
    {

        // Recuperation de la liste de tout les Adherents Avec tri
        private static string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
        private static MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
        // Ajout d'un adhérent
        // Recuperation de la liste des club

        // Récuperation du nombre d'adherent suivant le type passé  en parametre parametre 
       /* public static int GetAdherent(string type)
        {
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "Select count(*) from license l inner join club c on c.idClub = l.idClub where type = " + type;
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            maLigne.Read();
            string[] valeurColonnes = new string[1];
            for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
            int nb = int.Parse(valeurColonnes[0]);
            connection.Close();
            return nb;
        }*/
        // fonction Statistics 

        // Récuperation de l'adherent avec le plus le license , et son nombre de license
    }
}

