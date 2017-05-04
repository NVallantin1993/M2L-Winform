using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace M2L_ProjetWinform
{
    class DBStat
    {
        private static string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
        private static MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
        public static List<Adherent> getMaxLicense()
        {
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            List<Adherent> resultat = new List<Adherent>();
            maCommande.CommandText = "SELECT a.nom, a.prenom, a.sexe, a.rueAdresse, a.cp, a.ville, a.cotisation, Year(a.naissance) as naissance,count(*)";
            maCommande.CommandText += "FROM license l inner join adherent a on l.idAdherent = a.idAdherent GROUP BY a.idAdherent";
            maCommande.CommandText += "HAVING count(*) >= ALL (SELECT count(*) FROM license l inner join adherent a on l.idAdherent  = a.idAdherent";
            maCommande.CommandText += "GROUP BY a.idAdherent)";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[9];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string nom = valeurColonnes[0];
                string prenom = valeurColonnes[1];
                char sexe = char.Parse(valeurColonnes[2]);
                string rueAdresse = valeurColonnes[3];
                string cp = valeurColonnes[4];
                string ville = valeurColonnes[5];
                int coti = int.Parse(valeurColonnes[6]);
                string naissance = valeurColonnes[7];
                int nblicense = int.Parse(valeurColonnes[8]);
                Adherent unAdhe = new Adherent(sexe, nom, prenom, naissance, rueAdresse, cp,nblicense, ville);
                resultat.Add(unAdhe);
            }
            connection.Close();
            return resultat;
        }
    }
}
