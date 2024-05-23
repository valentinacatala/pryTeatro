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
    public partial class frmOnas : Form
    {
        public frmOnas()
        {
            InitializeComponent();

            // Configurar los asientos azules (20 asientos: 4 filas de 5)
            ConfigurarAsientos(tblAsientosAzul, 4, 5, Color.Blue, Color.LightBlue);

            // Configurar los asientos verdes (40 asientos: 8 filas de 5)
            ConfigurarAsientos(tblAsientosVerde, 8, 5, Color.Green, Color.LightGreen);
        }

        private void frmOnas_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarAsientos(TableLayoutPanel tableLayoutPanel, int filas, int columnas, Color asientoColor, Color panelColor)
        {
            tableLayoutPanel.BackColor = panelColor;
            tableLayoutPanel.ColumnCount = columnas;
            tableLayoutPanel.RowCount = filas;

            // Limpiar estilos previos
            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnas));
            }
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / filas));
            }

            // Agregar los asientos (Paneles)
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel.ColumnCount; j++)
                {
                    Panel asientoPanel = new Panel
                    {
                        BackColor = asientoColor,
                        Size = new Size(40, 40),
                        Margin = new Padding(5),
                        Tag = $"Fila {i + 1}, Columna {j + 1}"
                    };
                    asientoPanel.Click += AsientoPanel_Click;
                    tableLayoutPanel.Controls.Add(asientoPanel, j, i);
                }
            }
        }

        private void AsientoPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            MessageBox.Show("Has seleccionado el asiento: " + clickedPanel.Tag.ToString());
            // Cambiar el color del asiento para mostrar que está seleccionado
            clickedPanel.BackColor = Color.White;
        }
    }
}
