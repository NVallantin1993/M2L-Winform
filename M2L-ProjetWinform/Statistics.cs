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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bdwinformDataSet.adherent'. Vous pouvez la déplacer ou la supprimer selon les besoins.
 
            /*foreach(Adherent unAdhe in MaxLicense)
            {
                ListViewItem laLigne = new ListViewItem();
                laLigne.Text = unAdhe.getNom();
                laLigne.SubItems.Add(unAdhe.getPrenom());
                laLigne.SubItems.Add(unAdhe.getNbLicense().ToString());
                lvMaxLicense.Items.Add(laLigne);
            }*/
        }
    }
}
