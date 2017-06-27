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
    public partial class EditAdherent : Form
    {
        Adherent leAdhe;
        public EditAdherent(Adherent unAdhe)
        {
            leAdhe = unAdhe;
            InitializeComponent();
        }

        private void EditAdherent_Load(object sender, EventArgs e)
        {
            tb_nom.Text = leAdhe.getNom();
            tb_prenom.Text = leAdhe.getPrenom();
            tb_prenom.Enabled = false;
            tb_cp.Text = leAdhe.getCp();
            tb_rue.Text = leAdhe.getRue();
            tb_ville.Text = leAdhe.getVille();
            tb_coti.Text = leAdhe.getCoti().ToString();
            switch (leAdhe.getSexe().ToString())
            {
                case "F":
                    rb_female.PerformClick();
                    break;
                case "M":
                    rb_male.PerformClick();
                    break;
            }
            rb_male.Enabled = false;
            rb_female.Enabled = false;
            tb_naissance.Text = leAdhe.getNaissance();
            tb_naissance.Enabled = false;
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_naissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Adherent_Click(object sender, EventArgs e)
        {
            List<Adherent> LesAdhe = DBAdherent.getAllAdherent();
            int i = -1;
            bool trouve = false;
            while (i < LesAdhe.Count && !trouve)
            {
                i++;
                if (LesAdhe.ElementAt(i).getId() == leAdhe.getId())
                {
                    DBAdherent.DeleteAdhe(leAdhe.getId());
                    Adherent nouveauAdhe = new Adherent(leAdhe.getSexe(), tb_nom.Text, leAdhe.getPrenom(), leAdhe.getNaissance(), tb_rue.Text, tb_cp.Text, tb_ville.Text,leAdhe.getId(),int.Parse(tb_coti.Text));
                    DBAdherent.AjouterAdherent(nouveauAdhe);
                    trouve = true;
                    MessageBox.Show("Modification enregistrer");
                    this.Close();
                }
            }
        }
    }
}
