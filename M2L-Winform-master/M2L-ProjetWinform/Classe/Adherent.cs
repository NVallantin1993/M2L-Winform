using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    public class Adherent
    {
        private char sexe;
        private string nom;
        private string prenom;
        private string naissance;
        private string rueAdresse;
        private string cp;
        private string ville;
        private int id;
        private int cotisation;
        //CONSTRUCTEUR
        public Adherent(char leSexe, string leNom, string lePrenom, string laNaissance, string laRue, string leCp, string laVille, int leId,int laCoti)
        {
            sexe = leSexe;
            nom = leNom;
            prenom = lePrenom;
            naissance = laNaissance;
            rueAdresse = laRue;
            cp = leCp;
            ville = laVille;
            id = leId;
            cotisation = laCoti;
        }
        public Adherent(char leSexe, string leNom, string lePrenom, string laNaissance, string laRue, string leCp, string laVille,int laCoti)
        {
            sexe = leSexe;
            nom = leNom;
            prenom = lePrenom;
            naissance = laNaissance;
            rueAdresse = laRue;
            cp = leCp;
            ville = laVille;
            cotisation = laCoti;
        }
        // GETTEUR
        public int getCoti() { return cotisation; }
        public char getSexe() { return sexe; }
        public string getNom() { return nom; }
        public string getPrenom() { return prenom; }
        public string getNaissance() { return naissance; }
        public string getRue() { return rueAdresse; }
        public string getCp() { return cp; }
        public string getVille() { return ville; }
        public int getId() { return id; }
        //setteur

        public void setNom(string nouveau) { nom = nouveau; }
        public void setPrenom(string nouveau) { prenom = nouveau; }
        public void setAdresse(string nouveauRue, string nouveauCP, string nouveauVille) { rueAdresse = nouveauRue; cp = nouveauCP; ville = nouveauVille; }


    }
}
