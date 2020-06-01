using System;
using System.Collections.Generic;
using PatronesDeDiseño.PatronBridge.Interfaces;

namespace PatronesDeDiseño.PatronBridge.Clases
{
    //Es la version1 o implementacion 1 q el cliente puede ejecutar desde la abstraccion
    class CImplementacion1 : IBridge //en el diagrama UML seria ImplementacionX
    {
        #region Implementando IBridge
        public void ListarProductos(Dictionary<string, double> _productos)
        {
            foreach (KeyValuePair<string, double> p in _productos)
            {
                Console.WriteLine(p.Key);
            }
            Console.ReadLine();
        }

        public void MostrarTotales(Dictionary<string, double> _productos)
        {
            double total=0;
            int cantidad=0;
            foreach (KeyValuePair<string, double> p in _productos)
            {
                total += p.Value;
                cantidad++;
            }
            Console.WriteLine("El Total de {0} producto es ${1}", cantidad, total);
            Console.ReadLine();
        }
        #endregion
    }
}