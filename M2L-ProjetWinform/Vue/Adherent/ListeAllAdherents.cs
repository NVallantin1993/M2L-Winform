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
    public partial class ListeAllAdherents : Form
    {
        public ListeAllAdherents()
        {

            InitializeComponent();
        }
        string ordre = "ASC";
        private void ListeAllAdherents_Load(object sender, EventArgs e)
        {
            btn_Delete.Enabled = false;
            bt_edit.Enabled = false;
            List<Adherent> LesAdherents = DBAdherent.getAllAdherent("naissance",ordre);
            foreach (Adherent unAdh in LesAdherents)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unAdh.getNom();
                laLigne.SubItems.Add(unAdh.getPrenom());
                laLigne.SubItems.Add(unAdh.getSexe().ToString());
                laLigne.SubItems.Add(unAdh.getNaissance());
                laLigne.SubItems.Add(unAdh.getRue());
                laLigne.SubItems.Add(unAdh.getCp());
                laLigne.SubItems.Add(unAdh.getVille());
                lvListAdhe.Items.Add(laLigne);
            }
            lvListAdhe.Sorting = SortOrder.None;
        }
        
        private void lvListAdhe_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Delete.Enabled = true;
            bt_edit.Enabled = true;
        }

        private void lvAdher_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string colonne;
            lvListAdhe.Items.Clear();
            switch(e.Column)
            {
                case 0:
                    colonne = "nom";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 1:
                    colonne = "prenom";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 2:
                    colonne = "sexe";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 3:
                    colonne = "naissance";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 4:
                    colonne = "rueAdresse";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 5:
                    colonne = "cp";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 6:
                    colonne = "ville";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                case 7:
                    colonne = "cotisation";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
                default:
                    colonne = "naissance";
                    if (ordre == "ASC")
                        ordre = "DESC";
                    else
                        ordre = "ASC";
                    break;
            }
            List<Adherent> LesAdherents = DBAdherent.getAllAdherent(colonne, ordre);
            foreach (Adherent unAdh in LesAdherents)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unAdh.getNom();
                laLigne.SubItems.Add(unAdh.getPrenom());
                laLigne.SubItems.Add(unAdh.getSexe().ToString());
                laLigne.SubItems.Add(unAdh.getNaissance());
                laLigne.SubItems.Add(unAdh.getRue());
                laLigne.SubItems.Add(unAdh.getCp());
                laLigne.SubItems.Add(unAdh.getVille());
                lvListAdhe.Items.Add(laLigne);
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            List<Adherent> AllAdhe = DBAdherent.getAllAdherent();
            int i = -1;
            bool trouve = false;
            while (i < AllAdhe.Count && !trouve)
            {
                i++;
                if (AllAdhe.ElementAt(i).getNom() == lvListAdhe.SelectedItems[0].SubItems[0].Text && AllAdhe.ElementAt(i).getPrenom() == lvListAdhe.SelectedItems[0].SubItems[1].Text)
                {
                    trouve = true;
                }
            }
            EditAdherent maFenetre = new EditAdherent(AllAdhe.ElementAt(i));
            maFenetre.MdiParent = this.MdiParent; 
            maFenetre.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            List<Adherent> AllAdhe = DBAdherent.getAllAdherent();
            int i = -1;
            bool trouve = false;
            while (i < AllAdhe.Count && !trouve)
            {
                i++;
                if (AllAdhe.ElementAt(i).getNom() == lvListAdhe.SelectedItems[0].SubItems[0].Text && AllAdhe.ElementAt(i).getPrenom() == lvListAdhe.SelectedItems[0].SubItems[1].Text)
                {
                    trouve = true;
                }
            }
            if (MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur " + AllAdhe.ElementAt(i).getNom() + "  " + AllAdhe.ElementAt(i).getPrenom() + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DBAdherent.DeleteAdhe(AllAdhe.ElementAt(i).getId());
                lvListAdhe.Items.Clear();
                AllAdhe = DBAdherent.getAllAdherent();
                List<Adherent> LesAdherents = DBAdherent.getAllAdherent("naissance", ordre);
                foreach (Adherent unAdh in LesAdherents)
                {
                    ListViewItem laLigne = new ListViewItem();
                    laLigne.Text = unAdh.getNom();
                    laLigne.SubItems.Add(unAdh.getPrenom());
                    laLigne.SubItems.Add(unAdh.getSexe().ToString());
                    laLigne.SubItems.Add(unAdh.getNaissance());
                    laLigne.SubItems.Add(unAdh.getRue());
                    laLigne.SubItems.Add(unAdh.getCp());
                    laLigne.SubItems.Add(unAdh.getVille());
                    lvListAdhe.Items.Add(laLigne);
                }
                MessageBox.Show("L'utilisateur a bien été supprimer ");
            }
            else
            {
                MessageBox.Show("L'utilisateur " + AllAdhe.ElementAt(i).getNom() + "  " + AllAdhe.ElementAt(i).getPrenom() + " n'a pas été supprimer");
            }
        }
    }
}
