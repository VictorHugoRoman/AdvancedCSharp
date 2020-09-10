using PatronesDeDiseño.PatronTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronTemplate.Clases
{
    //clase q representa un estilo
    class CNormal : IPrimitiva
    {
        #region Implementando IPrimitiva
        //retorna el costo q nos costó decorar
        public double Decorar(int pCantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hacer {0} veces", pCantidad);
            Console.WriteLine("Pintar Logotipo");
            Console.WriteLine("Poner  Brillos");
            Console.WriteLine("Adicionar Cromos");

            return 7.50 * pCantidad;
        } 
        //retorna el costo q nos costó Empacar
        public double Empacar(int pCantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hacer {0} veces", pCantidad);
            Console.WriteLine("Preparar caja");
            Console.WriteLine("Poner instructivo");
            Console.WriteLine("Poner garantia");
            Console.WriteLine("Meter en caja con empaque");
            Console.WriteLine("Sellar caja");
            return 12.50  * pCantidad;
        }
        #endregion
    }
}
