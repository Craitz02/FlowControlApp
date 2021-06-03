using FlowControlProject.model;
using FlowControlProject.poco;
using FlowControlProject.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowControlProject
{
    public partial class FrmDepreciacion : Form
    {
        public ActivoFijoModel ActivoFijoModel { get; set; }
        public FrmDepreciacion()
        {
            InitializeComponent();
        }

        private void FrmDepreciacion_Load(object sender, EventArgs e)
        {
            cmbMetodos.Items.AddRange(Enum.GetValues(typeof(MetodoDepreciacion)).Cast<object>().ToArray());
            cmbMetodos.SelectedIndex = 0;
        }

        private void loadDepreciaciones()
        {
            int columns = ActivoFijoModel.GetGreaterVidaUtil();
            for(int i = 0; i <= columns; i++)
            {
                if (i == 0)
                {
                    dgvDepreciacion.Columns.Add($"Column{i}", "Nombre");
                    continue;
                }
                dgvDepreciacion.Columns.Add($"Column{i}", $"{i}");

            }
            int index = cmbMetodos.SelectedIndex;
            IDepreciacion depreciacion = new DepreciacionFactory().CreateInstance((MetodoDepreciacion)Enum.GetValues(typeof(MetodoDepreciacion)).GetValue(index));
            foreach(ActivoFijo af in ActivoFijoModel.GetAll())
            {
                decimal[] dep = depreciacion.CalcularDepreciacion(af.ValorActivo, af.ValorSalvamento, (int)af.TipoActivo);
                List<Decimal> listDep = Enumerable.ToList(dep);
                foreach(decimal d in dep)
                {
                    //List<object> rows = new List<object>();
                    //rows.Add(af.Nombre);
                    //rows.AddRange(dep.);
                    dgvDepreciacion.Rows.Add(dep);
                }
                
            }

        }

    }
}
