using FlowControlProject.poco;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class PnlActivoFijo : Form
    {
        List<ActivoFijo> activos;
        public PnlActivoFijo()
        {
            InitializeComponent();
            activos = new List<ActivoFijo>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private ActivoFijo ReadActivoFijo()
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            int index = cmbTipo.SelectedIndex;
            TipoActivo tipo = index == 0 ? TipoActivo.Edificio :
                              index == 1 ? TipoActivo.Vehiculo :
                              index == 2 ? TipoActivo.Mobiliario :
                              index == 3 ? TipoActivo.Maquinaria :
                              TipoActivo.Equipo_Computo;

            decimal.TryParse(txtValor.Text, out decimal valor);
            decimal.TryParse(txtValorSalv.Text, out decimal valorsalv);


            return null;
        }

        private void txtCodigo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
