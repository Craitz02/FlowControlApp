using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.Services
{
    public class LineaRecta : IDepreciacion
    {
        public decimal[] CalcularDepreciacion(decimal valor, decimal valorsalv, int vidaUtil)
        {
            decimal[] dep = new decimal[vidaUtil];
            decimal d = (valor - valorsalv) / vidaUtil;
            for(int i=0; i< dep.Length; i++)
            {
                dep[i] = d;
            }

            return dep;
        }
    }
}
