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
    public partial class ListeEvent : Form
    {
        List<Evenement> LesEvents;
        public ListeEvent()
        {
            InitializeComponent();
        }

        private void ListeEvent_Load(object sender, EventArgs e)
        {
            LesEvents = DBEvenement.getAllEvent();
            foreach(Evenement unEvent in LesEvents)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unEvent.getNom();
                laLigne.SubItems.Add(unEvent.getDebut());
                laLigne.SubItems.Add(unEvent.getFin());
                laLigne.SubItems.Add(unEvent.getTypeEvent());
                lvListEvent.Items.Add(laLigne);
            }

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            LesEvents = DBEvenement.getAllEvent();
            int i = -1;
            bool trouve = false;
            while(i < LesEvents.Count && !trouve)
            {
                i++;
                if (LesEvents.ElementAt(i).getNom() == lvListEvent.SelectedItems[0].SubItems[0].Text)
                {
                    trouve = true;
                }
            }
            EditEvent maFenetre = new EditEvent(LesEvents.ElementAt(i));
            maFenetre.MdiParent = this.MdiParent;
            maFenetre.Show();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            LesEvents = DBEvenement.getAllEvent();
            int i = -1;
            bool trouve = false;
            while (i < LesEvents.Count && !trouve)
            {
                i++;
                if (LesEvents.ElementAt(i).getNom() == lvListEvent.SelectedItems[0].SubItems[0].Text)
                {
                    trouve = true;
                }
            }
            DBEvenement.DeleteEvent(LesEvents.ElementAt(i).getId());
            lvListEvent.Items.Clear();
            LesEvents = DBEvenement.getAllEvent();
            foreach (Evenement unEvent in LesEvents)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unEvent.getNom();
                laLigne.SubItems.Add(unEvent.getDebut());
                laLigne.SubItems.Add(unEvent.getFin());
                laLigne.SubItems.Add(unEvent.getTypeEvent());
                lvListEvent.Items.Add(laLigne);
            }
        }

        private void bt_detail_Click(object sender, EventArgs e)
        {

        }
    }
}
