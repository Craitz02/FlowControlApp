using FlowControlProject.model;
using FlowControlProject.poco;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class FrmActivoFijo : Form
    {
        public ActivoFijoModel ActivoFijoModel { get; set; }
        //List<ActivoFijo> activos;
        public FrmActivoFijo()
        {
            InitializeComponent();
            loadTipoActivo();
            //activos = new List<ActivoFijo>();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ReadActivoFijo();
        }

        private void ReadActivoFijo()
        {
            try
            {
                string codigo = txtCodigo.Text;
                string nombre = txtNombre.Text;
                ValidateActivoFijo(codigo, nombre, out decimal valor, out decimal valorsalv);
                int index = cmbTipo.SelectedIndex;
                TipoActivo tipo = (TipoActivo)Enum.GetValues(typeof(TipoActivo)).GetValue(index);
                //TipoActivo tipo = index == 0 ? TipoActivo.Edificio :
                //                  index == 1 ? TipoActivo.Vehiculo :
                //                  index == 2 ? TipoActivo.Mobiliario :
                //                  index == 3 ? TipoActivo.Maquinaria :
                //                  TipoActivo.Equipo_Computo;

                
                ActivoFijo af = new ActivoFijo()
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    TipoActivo = tipo,
                    ValorActivo = valor,
                    ValorSalvamento = valorsalv,

                };

                ActivoFijoModel.Add(af);
                dgvActivos.DataSource = ActivoFijoModel.GetAll();
                MessageBox.Show("Activo agregado satisfactoriamente!!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mnesaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }

        private void ValidateActivoFijo(string codigo,string nombre, out decimal valor,out decimal valorSalv)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new ArgumentException("El codigo es requerido!");
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre es requerido!");
            }
            if (!decimal.TryParse(txtValor.Text, out decimal v))
            {
                throw new ArgumentException($"El valor \"{txtValor.Text}\" es invalido!");
            }
            valor = v;
            if (!decimal.TryParse(txtValorSalv.Text, out decimal vs))
            {
                throw new ArgumentException($"El valor \"{txtValorSalv.Text}\" es invalido!");
            }
            valorSalv = vs;
        }
        public void loadTipoActivo()
        {
            cmbTipo.Items.AddRange(Enum.GetValues(typeof(TipoActivo))
                                       .Cast<object>()
                                       .ToArray());

            cmbTipo.SelectedIndex = 0;
        }

        

        

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbTipo.SelectedIndex = 0;
            txtValor.Text = "";
            txtValorSalv.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvActivos.Rows.Count == 0)
            {
                return;
            }
            int index = dgvActivos.CurrentCell.RowIndex;
            ActivoFijoModel.Remove(index);
            dgvActivos.DataSource = ActivoFijoModel.GetAll();
        }
    }
}
