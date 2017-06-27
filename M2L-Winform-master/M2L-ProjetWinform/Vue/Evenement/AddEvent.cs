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
    public partial class AddEvent : Form
    {
        List<Club> LesClubs = DBClub.GetAllClub();
        public AddEvent()
        {
            InitializeComponent();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {
            foreach(Club unClub in LesClubs)
            {
                cb_club.Items.Add(unClub.getNom());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            List<Evenement> lesEvents = DBEvenement.getAllEvent();
            if (!lesEvents.Exists(x => (x.getNom() == tb_nom.Text)))
            {
                Evenement unEvent = new Evenement(tb_nom.Text, cb_club.SelectedIndex, mc_dateDebut.SelectionStart.ToShortDateString(), mc_dateFin.SelectionStart.ToShortDateString(), tb_type.Text);
                DBEvenement.AddEvenement(unEvent);
                MessageBox.Show("L'événement " + tb_nom.Text + " a bien été ajouter");
            }
            else
                MessageBox.Show("L'évenement " + tb_nom.Text + " existe deja");

        }
    }
}
