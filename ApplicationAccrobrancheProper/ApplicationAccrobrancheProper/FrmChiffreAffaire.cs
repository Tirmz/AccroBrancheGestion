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
    public partial class FrmChiffreAffaire : Form
    {
        private Modele bd;
        public FrmChiffreAffaire(Modele p_bd)
        {
            InitializeComponent();
            bd = p_bd;
            bs.DataSource = bd.Vente.ToList();
        }

        private string CalculCATotal()
        {
            float total = 0;
            foreach (DataGridViewRow row in dg_ventes.Rows)
            {
                total += Convert.ToInt32(row.Cells[2].Value);
            }
            return "Chiffre d'affaire Total : " + total.ToString() + " € (HT)";
        }

        private void FrmChiffreAffaire_Load(object sender, EventArgs e)
        {
            label1.Text = CalculCATotal();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(0, 0), this.Size));
            this.InvokePaint(dg_ventes, myPaintArgs);
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
