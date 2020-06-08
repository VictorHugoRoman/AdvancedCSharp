using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFlyweight.Interfaces
{
    //Esta interfaz sera implementada por cualquier clase q vaya a crear objetos de tipo IFlyWeight, estos objetos serán compartidos
    interface IFlyweight
    {
        void ColocaNombre(string _nombre);
        void CalculaCosto();
        void Mostrar();
        string ObtenNombre();
    }
}
