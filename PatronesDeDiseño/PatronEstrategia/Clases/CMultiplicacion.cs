using PatronesDeDiseño.PatronEstrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronEstrategia.Clases
{
    class CMultiplicacion: IOperacion
    {
        public double operacion(double a, double b)
        {
            return a * b;
        }
    }
}
