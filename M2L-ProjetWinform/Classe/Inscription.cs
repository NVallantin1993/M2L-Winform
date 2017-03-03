using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    class Inscription
    {
        private int idEvent;
        private int idAdherent;

        //Cosntructeur
        public Inscription(int leEvent, int leAdherent)
        {
            idEvent = leEvent;
            idAdherent = leAdherent;
        }

        //get
        public int getEvent() { return idEvent; }
        public int getAdherent() { return idAdherent; }


    }
}
