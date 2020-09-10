using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronCadenaResponsabilidad.Interfaces
{
    //este interfaz tiene q llevar los metodo(s) q tiene q procesar como tal el handler
    //q tiene q procesar al cual le tocó la peticion 
    interface IHandler
    {
        double CalculaPrecioFinal(int pCantidad, double pPrecio);
    }
}
