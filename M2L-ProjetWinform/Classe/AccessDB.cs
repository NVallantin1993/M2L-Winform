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

        public static List<Adherent> getAllAdherent(string colonneTri, string ordre)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            List<Adherent> LesAdherents = new List<Adherent>();

            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select idAdherent,nom, prenom, sexe, YEAR(naissance) ,MONTH(naissance), DAY(naissance), rueAdresse, cp, ville, cotisation, naissance from adherent order by " + colonneTri + " " + ordre;
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[12];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                int id = int.Parse(valeurColonnes[0]);
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                char sexe = char.Parse(valeurColonnes[3]);
                string naissance = valeurColonnes[6] + "/" + valeurColonnes[5] + "/" + valeurColonnes[4];
                string rueAdresse = valeurColonnes[7];
                string cp = valeurColonnes[8];
                string ville = valeurColonnes[9];
                int cotisation = int.Parse(valeurColonnes[10]);
                Adherent unAdherent = new Adherent(sexe, nom, prenom, naissance, rueAdresse, cp, ville, cotisation, id);
                LesAdherents.Add(unAdherent);
            }
            connection.Close();
            return (LesAdherents);
        }
        // Réecuperation de la liste de tout les adherents Avec tri recherche
        public static List<Adherent> getAllAdherent(string recherche)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            List<Adherent> LesAdherents = new List<Adherent>();

            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select idAdherent,nom, prenom, sexe, YEAR(naissance) ,MONTH(naissance), DAY(naissance), rueAdresse, cp, ville, cotisation, naissance from adherent where nom LIKE \"%" + recherche + "%\"";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[12];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                int id = int.Parse(valeurColonnes[0]);
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                char sexe = char.Parse(valeurColonnes[3]);
                string naissance = valeurColonnes[6] + "/" + valeurColonnes[5] + "/" + valeurColonnes[4];
                string rueAdresse = valeurColonnes[7];
                string cp = valeurColonnes[8];
                string ville = valeurColonnes[9];
                int cotisation = int.Parse(valeurColonnes[10]);
                Adherent unAdherent = new Adherent(sexe, nom, prenom, naissance, rueAdresse, cp, ville, cotisation, id);
                LesAdherents.Add(unAdherent);
            }
            connection.Close();
            return (LesAdherents);
        }
        // récuperation de la liste de tous les adherents sans aucun tri 
        public static List<Adherent> getAllAdherent()
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            List<Adherent> LesAdherents = new List<Adherent>();

            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select idAdherent,nom, prenom, sexe, YEAR(naissance) ,MONTH(naissance), DAY(naissance), rueAdresse, cp, ville, cotisation, naissance from adherent";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[12];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                int id = int.Parse(valeurColonnes[0]);
                string nom = valeurColonnes[1];
                string prenom = valeurColonnes[2];
                char sexe = char.Parse(valeurColonnes[3]);
                string naissance = valeurColonnes[6] + "/" + valeurColonnes[5] + "/" + valeurColonnes[4];
                string rueAdresse = valeurColonnes[7];
                string cp = valeurColonnes[8];
                string ville = valeurColonnes[9];
                int cotisation = int.Parse(valeurColonnes[10]);
                Adherent unAdherent = new Adherent(sexe, nom, prenom, naissance, rueAdresse, cp, ville, cotisation, id);
                LesAdherents.Add(unAdherent);
            }
            connection.Close();
            return (LesAdherents);
        }
        // Ajout d'un adhérent
        public static void AjouterAdherent(Adherent unAdhe)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            string nom = unAdhe.getNom();
            string prenom = unAdhe.getPrenom();
            char sexe = unAdhe.getSexe();
            string rue = unAdhe.getRue();
            string cp = unAdhe.getCp();
            string ville = unAdhe.getVille();
            string naissance = unAdhe.getNaissance();
            float coti = unAdhe.getCotisation();
            //connection base
            MySqlCommand maCommande = connection.CreateCommand();
            maCommande.CommandText = "INSERT INTO `adherent` (`nom`,`prenom`,`sexe`,`naissance`,`rueAdresse`,`cp`,`ville`,`cotisation`) VALUES ('" + nom + "','" + prenom + "','" + sexe + "','" + naissance + "','" + rue + "','" + cp + "','" + ville + "','" + coti + "')";
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
        }
        // Recuperation de la liste des club
        public static List<Club> GetAllClub()
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
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
        public static List<Adherent> getAdherentClub(int idClub)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            List<Adherent> lesAdhe = new List<Adherent>();
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "select ad.nom,prenom,sexe,rueAdresse,cp,ville,cotisation,Year(naissance) as naissance from adherent ad inner join license li on ad.idadherent = li.idAdherent inner join club cl on li.idClub = cl.idClub where cl.idClub =" + idClub + " Order by naissance";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[8];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string nom = valeurColonnes[0];
                string prenom = valeurColonnes[1];
                char sexe = char.Parse(valeurColonnes[2]);
                string rueAdresse = valeurColonnes[3];
                string cp = valeurColonnes[4];
                string ville = valeurColonnes[5];
                int coti = int.Parse(valeurColonnes[6]);
                string naissance = valeurColonnes[7];
                Adherent unAdhe = new Adherent(sexe, nom, prenom, naissance, rueAdresse, cp, ville, coti);
                lesAdhe.Add(unAdhe);
            }
            connection.Close();
            return lesAdhe;
        }
        // Recupere le nombre d'adherent a un club donnée
        public static void setClubAdherent(Club unClub)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
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
        public static void DeleteAdhe(int idAdhe)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "Delete from adherent where idAdherent = " + idAdhe;
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
            maCommande.CommandText = "Delete from license where idAdherent = " + idAdhe;
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
            maCommande.CommandText = "Delete from inscription where idAdherent = " + idAdhe;
            connection.Open();
            maCommande.ExecuteReader();
            connection.Close();
        }
        // Ajout d'un Club
        public static void AjouterClub(Club unClub)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
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
        // Récuperation du nombre d'adherent suivant le type passé  en parametre parametre 
        public static int GetAdherent(string type)
        {
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
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
        }
        // fonction Statistics 

        // Récuperation de l'adherent avec le plus le license , et son nombre de license
        public static List<Adherent> getMaxLicense()
        {
            List<Adherent> resultat = new List<Adherent>();
            string chaineDeconnexion = "SERVER=localhost;" + "DATABASE=bdwinform;" + "UID=root;" + "PASSWORD=;";
            MySqlConnection connection = new MySqlConnection(chaineDeconnexion);
            MySqlCommand maCommande = connection.CreateCommand();
            MySqlDataReader maLigne;
            maCommande.CommandText = "SELECT a.nom,a.prenom, count(*) FROM license l inner join adherent a on l.idAdherent = a.idAdherent GROUP BY a.idAdherent HAVING count(*) >= ALL (SELECT count(*) FROM license l inner join adherent a on l.idAdherent = a.idAdherent GROUP BY a.idAdherent)";
            connection.Open();
            maLigne = maCommande.ExecuteReader();
            while (maLigne.Read())
            {
                string[] valeurColonnes = new string[3];
                for (int i = 0; i < maLigne.FieldCount; i++) valeurColonnes[i] = maLigne.GetValue(i).ToString();
                string nom = valeurColonnes[0];
                string prenom = valeurColonnes[1];
                int nbLicense = int.Parse(valeurColonnes[2]);
                Adherent unAdhe = new Adherent(nom, prenom, nbLicense);
                resultat.Add(unAdhe);
          }
            connection.Close();
            return resultat;
        }

    }
}

