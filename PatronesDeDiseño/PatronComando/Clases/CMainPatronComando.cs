using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronComando.Clases;

namespace PatronesDeDiseño.PatronComando.Clases
{
    class CMainPatronComando
    {
        public static void _Main()
        {
            CAutomovil miAuto = new CAutomovil();
            CControlRemoto control = new CControlRemoto(miAuto);
            string opcion;

            do
            {
                Console.WriteLine("1-Encender,  2-Apagar,  3-Prender Alarma,  4-Apagar Alarma,  5-Salir");
                opcion = Console.ReadLine();

                //seleccionamos el comando por medio del indice
                if (opcion == "1")
                    control.Boton(0);
                if (opcion == "2")
                    control.Boton(1);
                if (opcion == "3")
                    control.Boton(2);
                if (opcion == "4")
                    control.Boton(3);
            } while (opcion != "5");
        }
    }
}
