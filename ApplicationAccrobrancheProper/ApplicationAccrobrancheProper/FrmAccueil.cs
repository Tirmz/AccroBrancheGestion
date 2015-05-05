using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationAccrobrancheProper
{
    public partial class FrmAccueil : Form
    {
        private Modele bd;
        public FrmAccueil()
        {
            InitializeComponent();
            bd = new Modele();
        }

        private void bt_GoGestionCaisse_Click(object sender, EventArgs e)
        {
            FrmGestionStock gestionstock = new FrmGestionStock(bd);
            gestionstock.ShowDialog();
        }

        private void bt_GoGestionEpis_Click(object sender, EventArgs e)
        {
            FrmGestionEpis gestionepi = new FrmGestionEpis();
            gestionepi.ShowDialog();
        }
    }
}
