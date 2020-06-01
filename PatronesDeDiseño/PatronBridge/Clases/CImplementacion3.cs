using System;
using System.Collections.Generic;
using PatronesDeDiseño.PatronBridge.Interfaces;

namespace PatronesDeDiseño.PatronBridge.Clases
{
    //Es la version3 o implementacion 3 q el cliente puede ejecutar desde la abstraccion
    class CImplementacion3 : IBridge //en el diagrama UML seria ImplementacionX
    {
        #region Implementando IBridge
        public void ListarProductos(Dictionary<string, double> _productos)
        {
            //LISTA PRODUCTOS POR TIPO C, M D
            foreach (KeyValuePair<string, double> p in _productos)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                if (p.Key[0] == 'C') Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            foreach (KeyValuePair<string, double> p in _productos)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (p.Key[0] == 'M') Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
            foreach (KeyValuePair<string, double> p in _productos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (p.Key[0] == 'D') Console.WriteLine("{0} - {1}", p.Key, p.Value);
            }
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

            Console.WriteLine("El total de comida es ${0}, {1}% del total", totalc, (totalc / total * 100));
            Console.WriteLine("El total de medicamentos es ${0}, {1}% del total", totalm, (totalm / total * 100));
            Console.WriteLine("El total de deportes es ${0}, {1}% del total", totald, (totald / total * 100));
            Console.WriteLine("El total de {0} productos es ${1}", cantidad, total);
            Console.ReadLine();
        }
        #endregion
    }
}