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
    public partial class EditClub : Form
    {
        Club leClub;
        public EditClub(Club unClub)
        {
            leClub = unClub;
            InitializeComponent();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditClub_Load(object sender, EventArgs e)
        {
            tbNom.Text = leClub.getNom();
            tbSite.Text = leClub.getSite();
            tbSpecilite.Text = leClub.getType();
            tbSpecilite.Enabled = false;
            tbTelephone.Text = leClub.getTelephone();
            tbMail.Text = leClub.getEmail();
        }

        private void gb_contact_Enter(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            List<Club> LesClubs = DBClub.GetAllClub();
            int i = -1;
            bool trouve = false;
            while (i < LesClubs.Count && !trouve)
            {
                i++;
                if (LesClubs.ElementAt(i).getId() == leClub.getId())
                {
                    DBClub.SupprimerClub(leClub.getId());
                    Club nouveauClub = new Club(tbNom.Text, tbSite.Text, leClub.getAdresse(), tbTelephone.Text, tbMail.Text, tbSpecilite.Text,leClub.getId());
                    DBClub.AjouterClub(nouveauClub);
                    trouve = true;
                    MessageBox.Show("Modification enregistrer");
                    this.Close();
                }
            }
        }
    }
}
