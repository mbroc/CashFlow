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
    public partial class Fsaisie : Form
    {
        private Cashflow unCashF;
        public Fsaisie(Cashflow unCF)
        {
            this.unCashF = unCF; 
            InitializeComponent();
        }

        private void Fsaisie_Load(object sender, EventArgs e)
        {
            /* On cache le groupbox et le bouton de retour au chargement de la page*/
            groupBox1.Hide();
            btn_retour.Hide();
        }
        private void btn_annuler_saisie_Click(object sender, EventArgs e)
        {
            if (txt_valeur_resi.ReadOnly==true)
            {
                /* si on ne peut plus les modifier, on ne peut pas non plus les annuler */

            }
            else
            { 
                /* Remise de tout les textbox à blanc, on efface tout leur contenu si le contenu n'est pas validé */
                this.txt_inv_mat.Text = "";
                this.txt_inv_proj.Text = "";
                this.txt_nombre_a.Text = "";
                this.txt_taux_actu.Text = "";
                this.txt_valeur_resi.Text = "";
            }

            
        }
        /* On filtre l'entrée, on ne peut écrire des lettres, seulement des chiffres */
        #region Filtre Numérique


        private void txt_inv_proj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txt_inv_mat_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
               (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txt_nombre_a_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
               (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void txt_taux_actu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
   (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_valeur_resi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
   (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txt_ca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
   (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
   (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txt_cf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
   (e.KeyChar == (char)44))
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion


        private void btn_valider_saisie_Click(object sender, EventArgs e)
        {
            /* On montre le groupbox et le boutton retour seulement quand on a validé la saisie */
            groupBox1.Show();
            btn_retour.Show();
            /* On rend impossible la modification des textbox après première validation*/
            txt_inv_proj.ReadOnly = true;
            txt_inv_mat.ReadOnly = true;
            txt_nombre_a.ReadOnly = true;
            txt_taux_actu.ReadOnly = true;
            txt_valeur_resi.ReadOnly = true;
            /* On crée un nouvel objet de la classe cashflow et un tampon*/
            Cashflow unCash = new Cashflow();
            String tampon;
            #region Passage des premières données dans la couche Métier
            /* Passage des  premières données dans la couche Métier */
            if (txt_inv_mat.Text != "")
            {
                tampon = txt_inv_mat.Text; /* Récupère le texte et le place dans le tampon*/
                Double im = Double.Parse(tampon); /* Convertit le tampon de string en double*/
                unCash.InvestissementMateriel = im; /* Fait correspondre avec les propriétés de Cashflow */
            }
            if (txt_inv_proj.Text != "")
            {
                tampon = txt_inv_proj.Text;
                Double ip = Double.Parse(tampon); /* ATTENTION ip ne doit pas forcement correspondre au constructeur,
                                                   * c'est une variable de nom aléatoire, 
                                                   * on fait ça pour s'y retrouver afin d'avoir plus de cohérences dans le code*/
                unCash.InvestissemeneProjet = ip;
            }
            if (txt_nombre_a.Text != "")
            {
                tampon = txt_nombre_a.Text;
                Double na = Double.Parse(tampon);
                unCash.NombreAnnees = na;
            }
            if (txt_taux_actu.Text != "")
            {
                tampon = txt_taux_actu.Text;
                Double ta = Double.Parse(tampon);
                unCash.TauxActu = ta;
            }
            if (txt_valeur_resi.Text != "")
            {
                tampon = txt_valeur_resi.Text;
                Double vr = Double.Parse(tampon);
                unCash.ValeurResiduelle = vr;
            }
            #endregion
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            /* On cache le bouton retour*/
            btn_retour.Hide();
            /* On rend de nouveau possible la modification des textbox après un retour*/
            txt_inv_proj.ReadOnly = false;
            txt_inv_mat.ReadOnly = false;
            txt_nombre_a.ReadOnly = false;
            txt_taux_actu.ReadOnly = false;
            txt_valeur_resi.ReadOnly = false;
        }

        private void btn_fermer_saisie_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
