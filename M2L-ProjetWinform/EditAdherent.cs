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
        Adherent test;
        //int test;
        public EditAdherent(Adherent unAdhe)
        {
            test = unAdhe;
            InitializeComponent();
        }

        private void EditAdherent_Load(object sender, EventArgs e)
        {
              tb_nom.Text = test.getNom();
              tb_prenom.Text = test.getPrenom();
              tb_prenom.Enabled = false;
              tb_cp.Text = test.getCp();
              tb_rue.Text = test.getRue();
              tb_ville.Text = test.getVille();
              switch (test.getSexe().ToString())
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
            tb_naissance.Text = test.getNaissance();
            tb_naissance.Enabled = false;
           // InitializeComponent();

            //tb_nom.Text = test.ToString();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_naissance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
