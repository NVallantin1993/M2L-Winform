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
    public partial class ListeClub : Form
    {
        public ListeClub()
        {
            InitializeComponent();
        }

        private void ListeClub_Load(object sender, EventArgs e)
        {
            List<Club> LesClubs = DBClub.GetAllClub();

            foreach(Club unCl in LesClubs)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unCl.getNom();
                laLigne.SubItems.Add(unCl.getAdresse());
                laLigne.SubItems.Add(unCl.getSite());
                laLigne.SubItems.Add(unCl.getTelephone());
                laLigne.SubItems.Add(unCl.getEmail());
                laLigne.SubItems.Add(unCl.getType());
                DBClub.setClubAdherent(unCl);
                laLigne.SubItems.Add(unCl.getNombreAdhe().ToString());
                lvClub.Items.Add(laLigne);
            }
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
