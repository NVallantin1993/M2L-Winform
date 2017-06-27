using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    public class Evenement
    {
        private string nomEvent;
        private int idClub;
        private string dateDebut;
        private string dateFin;
        private string typeEvent;
        private int id;

        public Evenement(string leNom, int leClub, string leDebut, string laFin, string leType,int leId)
        {
            nomEvent = leNom;
            idClub = leClub;
            dateDebut = leDebut;
            dateFin = laFin;
            typeEvent = leType;
            id = leId;
        }

        public Evenement(string leNom, int leClub,string leDebut, string laFin, string leType)
        {
            nomEvent = leNom;
            idClub = leClub;
            dateDebut = leDebut;
            dateFin = laFin;
            typeEvent = leType;
            id = int.Parse(null);
        }

        //get

        public string getNom() { return nomEvent; }
        public int getClub() { return idClub; }
        public string getDebut() { return dateDebut; }
        public string getFin() { return dateFin; }
        public string getTypeEvent() { return typeEvent; }
        public int getId() { return id; }
        //set
        public void setNom(string nouveau) { nomEvent = nouveau; }
        public void SetDebut(string nouveau) { dateDebut = nouveau; }
        public void setFin(string nouveau) { dateFin = nouveau; }
        public void setAutorisation(string nouveau) { typeEvent = nouveau; }
    }
}
