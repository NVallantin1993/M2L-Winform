using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace M2L_ProjetWinform
{
    public partial class Frm_acceuil : Form
    {
        public Frm_acceuil()
        {
            InitializeComponent();
        }

        private void Frm_acceuil_Load(object sender, EventArgs e)
        {
            //Chargement des Données depuis la base de Donnée bdwinform 


            //récupération Adherent
            //récuperation Club



            }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAllAdherents maFenetre = new ListeAllAdherents();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdherent maFenetre = new AddAdherent();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAllAdherents maFenetre = new ListeAllAdherents();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void parClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAdherentClub maFenetre = new ListeAdherentClub();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void listeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListeClub maFenetre = new ListeClub();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void parSpecialitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClubSpecialite maFenetre = new ListeClubSpecialite();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjoutClub maFenetre = new AjoutClub();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }

        private void donnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nombreDadherentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fermezToutesLesFenetresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics maFenetre = new Statistics();
            maFenetre.MdiParent = this;
            maFenetre.Show();
        }
    }
}
