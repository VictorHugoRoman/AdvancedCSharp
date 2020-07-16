using PatronesDeDiseño.PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronAdaptador.Clases
{
    //Esta es la clase q deseamos adaptar, el cliente no la puede usar directamente
    //pues su interfaz es diferente
    class CCalculadoraArray
    {
        public CCalculadoraArray()
        {

        }
        public double suma(int[] pOperandos)
        {
            int n = 0;
            int r = 0;
            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];
            return r;
        }
    }
}
