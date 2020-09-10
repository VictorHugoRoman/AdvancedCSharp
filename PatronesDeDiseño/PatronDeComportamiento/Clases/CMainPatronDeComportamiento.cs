using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronDeComportamiento.Clases;

namespace PatronesDeDiseño.PatronDeComportamiento.Clases
{
    class CMainPatronDeComportamiento
    {
        public static void _Main()
        {
            Caldera miCaldera = new Caldera();
            string opcion;
            do
            {
                Console.WriteLine("1.- Cortar Fuego, 2.- Poner Combustible, 3.- Forzar Fuego, 4.- Salir");
                opcion = Console.ReadLine();
                miCaldera.TrabajarCaldera();
                if (opcion == "1")
                    miCaldera.CortarFuegoCaldera();
                if (opcion == "2")
                    miCaldera.PonerCombustibleCaldera();   
                if (opcion == "3")
                    miCaldera.ForzarFuegoCaldera();

                Console.WriteLine(miCaldera);
            } while (opcion != "4");
        }
    }
}
