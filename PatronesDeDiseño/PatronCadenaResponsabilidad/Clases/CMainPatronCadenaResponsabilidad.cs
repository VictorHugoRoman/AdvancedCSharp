using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronCadenaResponsabilidad.Clases;

namespace PatronesDeDiseño.PatronCadenaResponsabilidad.Clases
{
    class CMainPatronCadenaResponsabilidad
    {
        public static void _Main()
        {
            //creamos la cadena
            //instanciamos en este orden (ultimo al primero) para construir la cadena de responsabilidad 
            CPropietario elPropietario = new CPropietario(); // Propietario q no necesita a nadie
            CJefePiso elJefe = new CJefePiso(elPropietario); //JefePiso q necesita al Porpietario
            CVendedor elVendedor = new CVendedor(elJefe); //Vendedor q necesita al Jefe de Piso

            int cantidad = 150;
            double precio = 1000;
            double total = 0;

            //Empecamos la invocacion de la cadena de responsabilidad
            //empecemos por l d menor responsabilidad q s l vendedor
            total = elVendedor.CalculaPrecioFinal(cantidad, precio);//

            Console.WriteLine("total {0}, con descuento {1}", cantidad*precio, total);

            Console.ReadLine();
        }
    }
}
