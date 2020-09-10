
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMemento.Clases
{
    //Registra los diferentes estados salvados,
    //Guarda los mementos
    class CCareTaker
    {
        //para este ejemplo unicamente guardamos y obtenemos la referencia a CMemento
        //aqui por ejemplo podemos llevar un registro a una bitacora d lo q c este haciendo
        //no solo de CMemento sino una lista para trabajar con varios mementos

        private CMemento memento;//variable de referencia de tipo Cmemento
        public CMemento Memento { get=>memento; set => memento = value; }
    }
}
