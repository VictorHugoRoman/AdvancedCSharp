using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronEstrategia.Interfaces
{
    //Esta interfaz representa la estrategias o algoritmos a implementar para el patron
    interface IOperacion
    {
        double operacion(double a, double b);
    }
}
