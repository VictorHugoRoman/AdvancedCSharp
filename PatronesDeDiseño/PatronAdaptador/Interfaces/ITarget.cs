using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronAdaptador.Interfaces
{
    //es la interfaz q conoce el cliente
    interface ITarget
    {
        int Sumar(int pA, int pB);
    }
}
