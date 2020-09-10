using PatronesDeDiseño.PatronCadenaResponsabilidad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronCadenaResponsabilidad.Clases
{
    //esta clase podria verse como si fuera el handler de default ya q el propietario no tiene continuacion
    //en la cadena de responsabilidad ya q es la ultima instancia q decide q s lo q c hará
    class CPropietario : IHandler
    {
        public CPropietario()
        {

        }
        #region Implementando IHandler
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el Propietario");

            //damos un 15% de descuento
            double total = pCantidad * pPrecio * 0.85;

            return total;
        }
        #endregion
    }
}
