using FlowControlProject.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.Services
{
    public class DepreciacionFactory
    {
        public IDepreciacion CreateInstance(MetodoDepreciacion metodo)
        {
            switch (metodo)
            {
                case MetodoDepreciacion.LineaRecta: return new LineaRecta();
                case MetodoDepreciacion.SDADecremental: return new SDAIncremental();
                case MetodoDepreciacion.SDAIncremental: return new SDADecremental();
                default: return null;
            }
        }
    }
}
