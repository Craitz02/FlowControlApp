using FlowControlProject.model;
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
    public partial class FrmMdi : Form
    {   private ActivoFijoModel activoFijoModel;
        public FrmMdi()
        {
            InitializeComponent();
        }

        private void activoFijoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActivoFijo frmA = new FrmActivoFijo();
            frmA.ActivoFijoModel = activoFijoModel;
            frmA.MdiParent = this;
            frmA.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void depreciaciontoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDepreciacion frmD = new FrmDepreciacion();
            frmD.ActivoFijoModel = activoFijoModel;
            frmD.MdiParent = this;
            frmD.Show();
        }
    }
}
