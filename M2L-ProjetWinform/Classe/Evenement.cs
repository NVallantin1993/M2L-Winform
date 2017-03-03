using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    class Evenement
    {
        private string nomEvent;
        private int idClub;
        private string adresseEvent;
        private DateTime dateDebut;
        private DateTime dateFin;
        private string typeEvent;

        public Evenement(string leNom, int leClub, string leAdresse, DateTime leDebut, DateTime laFin, string leType)
        {
            nomEvent = leNom;
            leClub = idClub;
            adresseEvent = leAdresse;
            dateDebut = leDebut;
            dateFin = laFin;
            typeEvent = leType;
        } 

        //get

        public string getNom() { return nomEvent; }
        public string getAdresse() { return adresseEvent; }
        public int getClub() { return idClub; }
        public DateTime getDebut() { return dateDebut; }
        public DateTime getFin() { return dateFin; }
        public bool getAutorisation()
        {
            if (typeEvent == "interne")
                return false;
            else
                return true;
        }

        //set
        public void setNom(string nouveau) { nomEvent = nouveau; }
        public void setAdresse(string nouveau) { adresseEvent = nouveau; }
        public void SetDebut(DateTime nouveau) { dateDebut = nouveau; }
        public void setFin(DateTime nouveau) { dateFin = nouveau; }
        public void setAutorisation(string nouveau) { typeEvent = nouveau; }
    }
}
