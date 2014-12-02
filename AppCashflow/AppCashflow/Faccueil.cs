using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace AppCashflow
{
    public partial class Faccueil : Form
    {
        private Cashflow unCF;
        public Faccueil()
        {
            InitializeComponent(); /* On initialise la page*/
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); /* On ferme l'application*/
        }

        private void saisieDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* On crée un objet saisie de la fenètre Fsaisie et on lui passe la propriété 
             * ShowDialog qui nous permet d'ouvrir la fenètre de dialogue de Fsaisie*/
            this.unCF = new Cashflow();
            Fsaisie saisie = new Fsaisie(this.unCF);
            saisie.ShowDialog(); 
        }

        private void Faccueil_Load(object sender, EventArgs e)
        {

        }

        private void cashflowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fresultat resultat = new Fresultat(this.unCF);
            resultat.ShowDialog();
        }
    }
}
