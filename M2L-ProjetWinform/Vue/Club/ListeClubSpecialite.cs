using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2L_ProjetWinform
{
    public partial class ListeClubSpecialite : Form
    {
        List<Club> LesClubs = DBClub.GetAllClub();
        public ListeClubSpecialite()
        {
            InitializeComponent();
        }

        private void ListeClubSpecialite_Load(object sender, EventArgs e)
        {
            foreach(Club unCl in LesClubs)
            {
                bool trouve = false;
                int i = 0;
                while (!trouve && i < cbSpecialite.Items.Count)
                {
                    if (cbSpecialite.Items[i].ToString() == unCl.getType())
                        trouve = true;
                    i++;
                }
                if(!trouve)
                    cbSpecialite.Items.Add(unCl.getType());

            }
        }
    }
}
