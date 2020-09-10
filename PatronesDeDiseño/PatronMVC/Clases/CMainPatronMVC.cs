using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronMVC.Clases;

namespace PatronesDeDiseño.PatronMVC.Clases
{
    class CMainPatronMVC
    {
        public static void _Main()
        {
            //Creamos el modelo
            CMAuto miAuto = new CMAuto("March", 2019, 250000);

            //Creamos la vista
            IVistaAuto miVista = new CVistaAuto();//como CVistaAuto implementa IVistaAuto guardamos la referencia como este tipo de interfaz

            //Creamos el controlador
            CControladorAuto miControlador = new CControladorAuto(miAuto, miVista);

            while (miControlador.Opcion != 3)
            {
                miControlador.DespliegaVista();
                miControlador.Solicita();
            }

            Console.ReadLine();
        }
    }
}
