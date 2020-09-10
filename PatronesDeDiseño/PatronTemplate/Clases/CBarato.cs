using PatronesDeDiseño.PatronTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronTemplate.Clases
{
    //clase q representa un estilo
    class CBarato : IPrimitiva
    {
        #region Implementando IPrimitiva
        //retorna el costo q nos costó decorar
        public double Decorar(int pCantidad)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int n = 0; n < pCantidad; n++)
            {
                Console.WriteLine("Pegar Etiqueta");
            }
            return 1.5 * pCantidad;
        }
        //retorna el costo q nos costó Empacar
        public double Empacar(int pCantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int n = 0; n < pCantidad; n++)
            {
                Console.WriteLine("Meter en bolsa");
            }
            return 0.25 * pCantidad;
        }
        #endregion
    }
}
