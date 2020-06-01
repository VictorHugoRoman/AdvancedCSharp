using System;
using System.Collections.Generic;
using PatronesDeDiseño.PatronBridge.Interfaces;

namespace PatronesDeDiseño.PatronBridge.Clases
{
    //Es la version2 o implementacion 2 q el cliente puede ejecutar desde la abstraccion
    internal class CImplementacion2 : IBridge //en el diagrama UML seria ImplementacionX
    {
        #region Implementando IBridge
        public void ListarProductos(Dictionary<string, double> _productos)
        {
            foreach (KeyValuePair<string, double> p in _productos)
            {
                if (p.Key[0] == 'C') Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'M') Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'D') Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            Console.ReadLine();
        }

        public void MostrarTotales(Dictionary<string, double> _productos)
        {
            double total = 0, totalm = 0, totalc = 0, totald = 0;
            int cantidad = 0;
            foreach (KeyValuePair<string, double> p in _productos)
            {
                total += p.Value;
                if (p.Key[0] == 'C') totalc += p.Value;
                if (p.Key[0] == 'M') totalm += p.Value;
                if (p.Key[0] == 'D') totald += p.Value;
                cantidad++;
            }
            Console.WriteLine("El total de comida es ${0}", totalc);
            Console.WriteLine("El total de medicamentos es ${0}", totalm);
            Console.WriteLine("El total de deportes es ${0}", totald);
            Console.WriteLine("El total de {0} productos es ${1}", cantidad, total);
            Console.ReadLine();
        }
        #endregion
    }
}