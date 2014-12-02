using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Cashflow
    {
        /* propriétés privées */
        private double nombreAnnees;
        private double chargesFixes;
        private double tauxActu;
        private double investissemeneProjet;
        private double investissementMateriel;
        private double valeurResiduelle;
        private double chiffreAffaire;
        private double chargesVariables;

        /* encapsulation de toutes les propriétes en accesseurs getters & setters */
        #region Accessseurs 
        public double NombreAnnees
        {
            get { return nombreAnnees; }
            set { nombreAnnees = value; }
        }

        public double TauxActu
        {
            get { return tauxActu; }
            set { tauxActu = value; }
        }

        public double InvestissemeneProjet
        {
            get { return investissemeneProjet; }
            set { investissemeneProjet = value; }
        }

        public double InvestissementMateriel
        {
            get { return investissementMateriel; }
            set { investissementMateriel = value; }
        }

        public double ValeurResiduelle
        {
            get { return valeurResiduelle; }
            set { valeurResiduelle = value; }
        }

        public double ChiffreAffaire
        {
            get { return chiffreAffaire; }
            set { chiffreAffaire = value; }
        }

        public double ChargesVariables
        {
            get { return chargesVariables; }
            set { chargesVariables = value; }
        }

        public double ChargesFixes
        {
            get { return chargesFixes; }
            set { chargesFixes = value; }
        }
        #endregion
        /* Constructeurs*/
        #region Constructeurs
        public Cashflow()
        {
        }
        public Cashflow(double na, double cf, double ta, double ip,
           double im, double vr, double ca, double cv)
        {
            this.nombreAnnees = na;
            this.chargesFixes = cf;
            this.tauxActu = ta;
            this.investissemeneProjet = ip;
            this.investissementMateriel = im;
            this.valeurResiduelle = vr;
            this.chargesVariables = cv;
            this.chiffreAffaire = ca;
        }
        #endregion
        /* Formules */



    }
}
