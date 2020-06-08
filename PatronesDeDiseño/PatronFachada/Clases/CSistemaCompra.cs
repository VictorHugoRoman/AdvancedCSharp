using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Aqui tendremos los subsistemas, en lo profesional si serian sistemas mas complejos
//las clases q creamos aqui nos va a representar esos sistemas
namespace Subsistemas
{
    //Esta clase representa uno de los subSistemas
    class CSistemaCompra
    {
        //Este metodo representa alguna operacion que puede llevar a cabo el subSistema,
        //puede haber muchas mas y d mayor complejidad
        public bool Comprar()//simulamos una compra
        {
            string dato = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Introducir numero de tarjeta");
            dato = Console.ReadLine();

            if (dato == "12345")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pago Aceptado");
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Pago Rechazado");
                return false;
            }
        }

    }
    //Esta clase representa uno de los subSistemas
    class CSubSistemaAlmacen
    {
        private int cantidad;
        public CSubSistemaAlmacen()
        {
            cantidad = 3;
        }
        public bool SacarAlmacen()
        {
            if (cantidad > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Producto Listo para enviarse");
                cantidad--;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto no disponible, espera a que haya existencias");
                return false;
            }
        }
    }
    //Esta clase representa uno de los subSistemas
    class CSubSistemaEnvio
    {
        public void EnviarPedido()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("El envío va en camino");
        }
    }
}
