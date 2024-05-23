using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTeatro
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnQuenaken_Click(object sender, EventArgs e)
        {
            frmQuenaken frmQuenaken = new frmQuenaken();
            frmQuenaken.Show();
        }

        private void btnOnas_Click(object sender, EventArgs e)
        {
            frmOnas frmOnas = new frmOnas();
            frmOnas.Show();
        }

        private void btnTobas_Click(object sender, EventArgs e)
        {
            frmTobas frmTobas = new frmTobas(); 
            frmTobas.Show();
        }
    }
}
