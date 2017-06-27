using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    public class Club
    {
        private string nom;
        private string site;
        private string adresse;
        private string telephone;
        private string email;
        private string type;
        private int id;
        private int nbAdherent;
        // Constructeur

        public Club(string leNom, string leSite, string leAdresse, string leTelephone, string leEmail, string leType, int leId)
        {
            nom = leNom;
            site = leSite;
            adresse = leAdresse;
            telephone = leTelephone;
            email = leEmail;
            type = leType;
            id = leId;
        }
        public Club(string leNom, string leSite, string leAdresse, string leTelephone, string leEmail, string leType)
        {
            nom = leNom;
            site = leSite;
            adresse = leAdresse;
            telephone = leTelephone;
            email = leEmail;
            type = leType;
            id = 0;
        }
        public Club(string leNom, string leAdresse, string leTelephone, string leType, int leNbAdherent, int leId)
        {
            nom = leNom;
            site = "";
            adresse = leAdresse;
            telephone = leTelephone;
            email = "";
            type = leType;
            id = leId;
            nbAdherent = leNbAdherent;
        }

        //get

        public string getNom() { return nom; }
        public string getSite() { return site; }
        public string getAdresse() { return adresse; }
        public string getTelephone() { return telephone; }
        public string getEmail() { return email; }
        public string getType() { return type; }
        public int getId() { return id; }
        public int getNombreAdhe() { return nbAdherent; }
        //set

        public void setNom(string nouveau) { nom = nouveau; }
        public void setSite(string nouveau) { site = nouveau; }
        public void setAdresse(string nouveau) { adresse = nouveau; }
        public void setTelephone(string nouveau) { telephone = nouveau; }
        public void setEmail(string nouveau) { email = nouveau; }
        public void setAdhe(int nouveau) { nbAdherent = nouveau; }
    }
}
