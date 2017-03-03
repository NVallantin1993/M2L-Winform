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
            List<Adherent> LesAdherents = AccessDB.getAllAdherent("naissance",ordre);
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
                laLigne.SubItems.Add(unAdh.getCotisation().ToString());
                lvListAdhe.Items.Add(laLigne);
            }
            lvListAdhe.Sorting = SortOrder.None;
        }
        
        private void lvListAdhe_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            List<Adherent> LesAdherents = AccessDB.getAllAdherent(colonne, ordre);
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
                laLigne.SubItems.Add(unAdh.getCotisation().ToString());
                lvListAdhe.Items.Add(laLigne);
            }

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
