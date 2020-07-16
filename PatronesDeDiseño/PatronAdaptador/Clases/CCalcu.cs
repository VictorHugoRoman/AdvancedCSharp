using PatronesDeDiseño.PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronAdaptador.Clases
{
    class CCalcu : ITarget
    {
        public CCalcu()
        {

        }
        #region Implementando ITarget
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
        #endregion
    }
}
