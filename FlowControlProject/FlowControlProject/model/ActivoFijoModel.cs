using FlowControlProject.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControlProject.model
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] activosFijo;
        public ActivoFijoModel() { }

        public void Add(ActivoFijo af)
        {
            if (activosFijo == null)
            {
                activosFijo = new ActivoFijo[1];
                activosFijo[0] = af;
                return;
            }
            ActivoFijo[] temp = new ActivoFijo[activosFijo.Length + 1];
            Array.Copy(activosFijo, temp, activosFijo.Length);
            temp[temp.Length - 1] = af;

            activosFijo = temp;
        }
        public void Remove(int index)
        {
            if (index < 0)
            {
                return;
            }
            if (activosFijo == null)
            {
                return;
            }
            if (index >= activosFijo.Length)
            {
                throw new IndexOutOfRangeException($"El index {index} esta fuera de rango");
            }
            if(index==0 && activosFijo.Length == 1)
            {
                activosFijo = null;
                return;
            }
            ActivoFijo[] tmp = new ActivoFijo[activosFijo.Length - 1];
            if (index == 0)
            {
                Array.Copy(activosFijo, index + 1, tmp, 0, tmp.Length);
                activosFijo = tmp;
                return;
            }
            if (index == activosFijo.Length-1)
            {
                Array.Copy(activosFijo, 0, tmp, 0, tmp.Length);
                activosFijo = tmp;
                return;
            }
            Array.Copy(activosFijo, 0, tmp, 0, index);
            Array.Copy(activosFijo, index + 1, tmp, index, (tmp.Length - index));
            activosFijo = tmp;
        }

        public ActivoFijo[] GetAll()
        {
            return activosFijo;
        }

        public int GetGreaterVidaUtil()
        {
            return (int) activosFijo.OrderBy(a => a.TipoActivo)
                                    .Reverse()
                                    .FirstOrDefault().TipoActivo;
        }
    }

    
}
