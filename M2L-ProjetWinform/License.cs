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

        public License (int leClub, int leAdherent, string laLicense)
        {
            idClub = leClub;
            idAdherent = leAdherent;
            license = laLicense;
        }

        public int getClub() { return idClub; }
        public int getAdherent() { return idAdherent; }
        public string getLicense() { return license; }

    }
}
