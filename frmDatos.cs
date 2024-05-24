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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }
        
        public string FuncionSeleccionada { get; set; }
        public DateTime FechaSeleccionada { get; set; }
        public List<string> AsientosSeleccionados { get; set; }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            
            SetInfo(FuncionSeleccionada, FechaSeleccionada);
            SetAsientos(AsientosSeleccionados);
        }

        public void SetInfo(string funcion, DateTime fecha)
        {
            lblFuncion.Text = funcion;
            lblFecha.Text = fecha.ToShortDateString();
        }

        public void SetAsientos(List<string> asientos)
        {
            lstAsientos.Items.Clear();
            foreach (string asiento in asientos)
            {
                lstAsientos.Items.Add(asiento);
            }
        }
    }
}
