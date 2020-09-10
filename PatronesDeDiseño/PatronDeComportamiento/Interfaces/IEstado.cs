using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDeComportamiento.Interfaces
{
    //Esta interfaz dbrá ser implementada en todos los estados q vaya a tener el programa
    //en este caso la maquina
    interface IEstado
    {
        void Trabajar();
        void CortarFuego();
        void PonerCombustible();
        void ForzarFuego();
    }
}
