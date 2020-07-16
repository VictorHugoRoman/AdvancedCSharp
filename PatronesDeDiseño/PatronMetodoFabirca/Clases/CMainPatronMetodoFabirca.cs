using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronMetodoFabirca.Clases;
using PatronesDeDiseño.PatronMetodoFabirca.Interfaces;

namespace PatronesDeDiseño.PatronMetodoFabirca.Clases
{
    class CMainPatronMetodoFabirca
    {
        public static void _Main()
        {
            string dato;
            int dinero;
            IVehiculo vehiculo;

            Console.WriteLine("Cuanto dinero tiene para tu vehiculo?");
            dato = Console.ReadLine();
            dinero = Convert.ToInt32(dato);

            //obtenemos el vehiculo de la fabrica
            vehiculo = CCreador.MetodoFabrica(dinero);

            vehiculo.Encender();
            vehiculo.Acelerar();
            vehiculo.Frenar();
            vehiculo.Girar();
            Console.ReadLine();

        }
    }
}
