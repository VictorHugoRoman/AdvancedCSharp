using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronTemplate.Clases;
using PatronesDeDiseño.PatronTemplate.Interfaces;

namespace PatronesDeDiseño.PatronTemplate.Clases
{
    class CMainPatronTemplate
    {
        public static void _Main()
        {
            int cantidad = 0;
            IPrimitiva tipoClaseN = null;
            double total = 0;

            Console.WriteLine("1-Barato,  2.-Normal");
            string tipo = Console.ReadLine();

            if (tipo == "1")
                tipoClaseN = new CBarato();
            if (tipo == "2")
                tipoClaseN = new CNormal();

            Console.WriteLine("Cuantos a producir?");
            cantidad = Convert.ToInt32(Console.ReadLine());

            //instanciamos el algortimo
            Algoritmo produccion = new Algoritmo();

            total = produccion.MetodoTemplate(tipoClaseN, cantidad);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El total es {0}", total);

            Console.ReadLine();
        }
    }
}
