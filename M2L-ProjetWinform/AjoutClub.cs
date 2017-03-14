﻿using System;
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
    public partial class AjoutClub : Form
    {
        public AjoutClub()
        {
            InitializeComponent();
        }

        private void Add_Club_Click(object sender, EventArgs e)
        {
            List<Club> LesClubs = AccessDB.GetAllClub();
            if (!LesClubs.Exists(x => (x.getNom() == tbNom.Text)))
            {
                Club unClub = new Club(tbNom.Text, tbSite.Text, tbRue.Text + " " + tbVille.Text + " " + tbPostal.Text, tbTelephone.Text, tbMail.Text, tbSpecilite.Text);
                AccessDB.AjouterClub(unClub);
                MessageBox.Show("Le club " + tbNom.Text + " a bien été ajouter");
            }
            else
                MessageBox.Show("Le club " + tbNom.Text + " existe deja");

        }
    }
}
