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
    public partial class ListeAdherentClub : Form
    {
        List<Club> LesClubs = DBClub.GetAllClub();
        public ListeAdherentClub()
        {
            InitializeComponent();
        }

        private void ListeAdherentClub_Load(object sender, EventArgs e)
        {
            // Verification Double entrée
            foreach(Club unClub in LesClubs)
            {
                cb_club.Items.Add(unClub.getNom());
            }
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            lvAdherent.Items.Clear();
            bool trouve = false;
            int i = 0;
            while (!trouve & i < LesClubs.Count)
            {
                if (LesClubs.ElementAt(i).getNom() == cb_club.SelectedItem.ToString())
                    trouve = true;
                i++;
            }
            label1.Text = i.ToString();
            List<Adherent> LesAdhe = DBAdherent.getAdherentClub(LesClubs.ElementAt(i - 1).getId());
            foreach(Adherent unAdhe in LesAdhe)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unAdhe.getNom();
                laLigne.SubItems.Add(unAdhe.getPrenom());
                laLigne.SubItems.Add(unAdhe.getSexe().ToString());
                laLigne.SubItems.Add(unAdhe.getRue() + " " + unAdhe.getCp() + " " + unAdhe.getVille());
                laLigne.SubItems.Add((DateTime.Now.Year - int.Parse(unAdhe.getNaissance())).ToString()); ;
                lvAdherent.Items.Add(laLigne);
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
