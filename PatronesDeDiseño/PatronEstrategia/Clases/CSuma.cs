using PatronesDeDiseño.PatronEstrategia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronEstrategia.Clases
{
    //Esta clase representa la estrategia del patron
    //Podemos implementar otros metodos no esta casado con la implementacion de la interfz IOperacion
    class CSuma: IOperacion
    {
        public double operacion(double a, double b)
        {
            return a + b;
        }
    }
}
