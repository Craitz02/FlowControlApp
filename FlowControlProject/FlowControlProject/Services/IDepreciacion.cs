using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.Services
{
    public interface IDepreciacion
    {
        decimal[] CalcularDepreciacion(decimal valor,decimal valorsalv,int vidaUtil);
    }
}
