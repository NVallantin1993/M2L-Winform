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

        private void ListeAllAdherents_Load(object sender, EventArgs e)
        {
            List<Adherent> LesAdherents = AccessDB.getAllAdherent();
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
    }
}
