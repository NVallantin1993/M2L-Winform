using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    class Adherent
    {
        private char sexe;
        private string nom;
        private string prenom;
        private string naissance;
        private string rueAdresse;
        private string cp;
        private string ville;
        private float cotisation;
        private int id;
        //CONSTRUCTEUR
        public Adherent(char leSexe, string leNom, string lePrenom, string laNaissance, string laRue, string leCp, string laVille, float laCoti, int leId)
        {
            sexe = leSexe;
            nom = leNom;
            prenom = lePrenom;
            naissance = laNaissance;
            rueAdresse = laRue;
            cp = leCp;
            ville = laVille;
            cotisation = laCoti;
            id = leId;
        }

        public Adherent(char leSexe, string leNom, string lePrenom, string laNaissance, string laRue, string leCp, string laVille, float laCoti)
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

        public char getSexe() { return sexe; }
        public string getNom() { return nom; }
        public string getPrenom() { return prenom; }
        public string getNaissance() { return naissance; }
        public string getRue() { return rueAdresse; }
        public string getCp() { return cp; }
        public string getVille() { return ville; }
        public float getCotisation() { return cotisation; }
        public int getId() { return id; }

        //setteur

        public void setNom(string nouveau) { nom = nouveau; }
        public void setPrenom(string nouveau) { prenom = nouveau; }
        public void setAdresse(string nouveauRue, string nouveauCP, string nouveauVille) { rueAdresse = nouveauRue; cp = nouveauCP; ville = nouveauVille; }
        public void setCotisation(float nouveau) { cotisation = nouveau; }


    }
}
