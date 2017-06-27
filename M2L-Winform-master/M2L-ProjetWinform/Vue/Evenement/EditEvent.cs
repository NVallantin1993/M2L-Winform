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
    public partial class EditEvent : Form
    {
        List<Club> lesClubs = DBClub.GetAllClub();
        Evenement modifier;
        public EditEvent(Evenement unEvent)
        {
            tb_nom.Text = unEvent.getNom();
            tb_type.Text = unEvent.getTypeEvent();
            modifier = unEvent;
            InitializeComponent();
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            DBEvenement.DeleteEvent(modifier.getId());
            Evenement nouveau = new Evenement(tb_nom.Text, modifier.getClub(), modifier.getDebut(), modifier.getFin(), modifier.getTypeEvent(), modifier.getId());
            DBEvenement.AddEvenement(nouveau);
            this.Close();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
