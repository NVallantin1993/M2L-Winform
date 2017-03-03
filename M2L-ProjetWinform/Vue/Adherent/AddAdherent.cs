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
            char sexe;
            if (rb_female.Checked)
                sexe = char.Parse("F");
            else
                sexe = char.Parse("M");
            Adherent unAdhe = new Adherent(sexe, tb_nom.Text, tb_prenom.Text, mc_naissance.SelectionStart.ToShortDateString(), tb_rue.Text, tb_cp.Text, tb_ville.Text, float.Parse(tb_coti.Text));
            AccessDB.AjouterAdherent(unAdhe);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
