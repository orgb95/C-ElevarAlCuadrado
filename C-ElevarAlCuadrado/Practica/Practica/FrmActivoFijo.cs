using Practica.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class FrmActivoFijo : Form
    {
        List<ActivoFijo> activoFijos;
        public FrmActivoFijo()
        {
            InitializeComponent();
            activoFijos = new List<ActivoFijo>();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private ActivoFijo ReadActivoFijo() {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            int index = cmbTipo.SelectedIndex;
            TipoActivo tipo = index == 0 ? TipoActivo.Edificio :
                              index == 1 ? TipoActivo.Mobiliario :
                              index == 2 ? TipoActivo.Equipo_Computo :
                              index == 3 ? TipoActivo.Vehiculo :
                              TipoActivo.Maquinaria;

            decimal.TryParse(txtValor.Text, out decimal valor);
            decimal.TryParse(txtValor.Text, out decimal valorR);

            return null;
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                txtCodigo.BackColor = Color.Pink;
                e.Cancel = true;
            }
            else
            {
                txtCodigo.BackColor = Color.White;
            }

        }
    }
}
