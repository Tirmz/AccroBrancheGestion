using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;

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
            gestionstock.Show();
        }

        private string getNameComputer()
        {
            string userHost = Dns.GetHostName();
            return userHost;
        }
        
        private string getIpAdresse()
        {
            string userIp = Dns.GetHostEntry(getNameComputer()).AddressList[1].ToString();
            return userIp;
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
            setDisplay();
        }

        private void setDisplay()
        {
            lb_nameComputer.Text = "Bienvenue " + getNameComputer();
        }
        private void clearEmptySells()
        {
            MySqlConnection connexion = new MySqlConnection();
            connexion.ConnectionString = "server=mysql.montpellier.epsi.fr;user id=tristan.prophete;password=epsi146VOS;persistsecurityinfo=True;port=5206;database=accrocbranchetp";
            MySqlCommand cmd = new MySqlCommand();
            connexion.Open();

            cmd.Connection = connexion;
            cmd.CommandText = "DeleteVenteEmpty";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();

            connexion.Close();
        }
    }
}
