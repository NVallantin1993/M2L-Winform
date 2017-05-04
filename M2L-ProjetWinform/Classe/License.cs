using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2L_ProjetWinform
{
    class License
    {
        private int idClub;
        private int idAdherent;
        private string license;
        private int cotisation;

        public License (int leClub, int leAdherent, string laLicense, int laCoti)
        {
            idClub = leClub;
            idAdherent = leAdherent;
            license = laLicense;
            cotisation = laCoti;
        }

        public int getClub() { return idClub; }
        public int getAdherent() { return idAdherent; }
        public string getLicense() { return license; }
        public int getCotisation() { return cotisation; }

    }
}
