using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMVC.Clases
{
    interface IVistaAuto
    {        
        void DespliegaAuto(CMAuto pAuto);
        int SolicitaEntrada();

        //podemos emplear diferentes vista, siempre y cuando esten implementando a esta interfaz,
        //podemos hacer uso del patron estrategia para ello
    }
}
