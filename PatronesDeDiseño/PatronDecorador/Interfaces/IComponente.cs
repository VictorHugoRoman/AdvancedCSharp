using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDecorador.Interfaces
{
    //Interfaz para la decoracion
    interface IComponente
    {
        double Costo();
        string Funciona();
    }
}
