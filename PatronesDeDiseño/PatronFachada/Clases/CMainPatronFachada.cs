using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronFachada.Clases;

//Necesario para usar los subsitemas
using Subsistemas;

namespace PatronesDeDiseño.PatronFachada.Clases
{
    class CMainPatronFachada
    {
        public  static void _Main()
        {
            //Creamos la instancia de la fachada
            CFachada fachada = new CFachada();

            //Hacemos uso de los subsitemas a traves de la interfaz sencilla de la fachada
            //es de alto nivel porque aqui solo lo mandamos ejecutar, es decir, aqui en el cliente no tiene la complejidad
            fachada.Compra();//este metodo tiene toda la complejidad del proceso, aqui en cliente solo lo mandamos mayor
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------");


            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");

            fachada.Compra();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");

        }
    }
}
