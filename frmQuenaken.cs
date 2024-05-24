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
    public partial class frmQuenaken : Form
    {
        public frmQuenaken()
        {
            InitializeComponent();

            // Configurar los asientos azules
            ConfigurarAsientos(tblAsientosAzul, Color.Blue, Color.LightBlue);
            // Configurar los asientos verdes
            ConfigurarAsientos(tblAsientosVerde, Color.Green, Color.LightGreen);
        }

        private string funcionSeleccionada;
        private DateTime fechaSeleccionada;
        private List<string> asientosSeleccionados = new List<string>();
        private void frmQuenaken_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();

            frmDatos.FuncionSeleccionada = comboBox1.SelectedItem?.ToString();
            frmDatos.FechaSeleccionada = dateTimePicker1.Value;
            frmDatos.AsientosSeleccionados = asientosSeleccionados;

            frmDatos.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigurarAsientos(TableLayoutPanel tableLayoutPanel, Color asientoColor, Color panelColor)
        {
            tableLayoutPanel.BackColor = panelColor;

            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.RowCount = 4;

            tableLayoutPanel.ColumnStyles.Clear();
            tableLayoutPanel.RowStyles.Clear();

            for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            }
            for (int i = 0; i < tableLayoutPanel.RowCount; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
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
            //Seleccionar el asiento y pintarlo de otro color
            Panel clickedPanel = sender as Panel;
            if (clickedPanel.BackColor != Color.White && clickedPanel.Enabled)
            {
                clickedPanel.BackColor = Color.White;
                asientosSeleccionados.Add(clickedPanel.Tag.ToString());
            }
            else if (clickedPanel.BackColor == Color.White)
            {
                clickedPanel.BackColor = Color.Blue;
                asientosSeleccionados.Remove(clickedPanel.Tag.ToString());
            }
        }
    }
}
