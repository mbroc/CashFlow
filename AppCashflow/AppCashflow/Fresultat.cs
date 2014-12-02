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
    public partial class Fresultat : Form
    {
        private Cashflow unCashF;
        public Fresultat(Cashflow unCF)
        {
            this.unCashF = unCF;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
