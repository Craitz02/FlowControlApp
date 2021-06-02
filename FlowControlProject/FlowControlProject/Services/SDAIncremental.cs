﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.Services
{
    public class SDAIncremental : IDepreciacion
    {
        public decimal[] CalcularDepreciacion(decimal valor, decimal valorsalv, int vidaUtil)
        {
            int factor = vidaUtil * (vidaUtil + 1) / 2;
            decimal[] dep = new decimal[vidaUtil];
            
            for(int i = 0,k =1; i < vidaUtil; i++)
            {
                dep[i] = (valor - valorsalv) * k++ / factor;
            }
            return dep;
        }
    }
}
