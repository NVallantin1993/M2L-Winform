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
    public partial class AddAdherent : Form
    {
        public AddAdherent()
        {
            InitializeComponent();
        }

        private void Add_Adherent_Click_1(object sender, EventArgs e)
        {
            List<Adherent> LesAdherents = new List<Adherent>();

            char sexe;
            if (rb_female.Checked)
                sexe = char.Parse("F");
            else
                sexe = char.Parse("M");
            if (!LesAdherents.Exists(x => (x.getNom() == tb_nom.Text)))
            {
                Adherent unAdhe = new Adherent(sexe, tb_nom.Text, tb_prenom.Text, mc_naissance.SelectionStart.ToShortDateString(), tb_rue.Text, tb_cp.Text, tb_ville.Text,int.Parse(tb_coti.Text));
                DBAdherent.AjouterAdherent(unAdhe);
                MessageBox.Show("L'adherent " + tb_nom.Text + " " + tb_prenom.Text + " a bien été ajouter");
            }
            else
                MessageBox.Show("L'adherent " + tb_nom.Text + " " + tb_prenom.Text + " existe deja");
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAdherent_Load(object sender, EventArgs e)
        {
        }
    }
}
