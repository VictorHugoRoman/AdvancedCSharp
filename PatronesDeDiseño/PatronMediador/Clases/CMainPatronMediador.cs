using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronMediador.Clases;

namespace PatronesDeDiseño.PatronMediador.Clases
{
    class CMainPatronMediador
    {
        public static void _Main()
        {
            //Creamos el mediador
            CMediador miMediador = new CMediador();

            //Creamos los Colegas
            CColegaA Ana = new CColegaA("Ana", miMediador);
            CColegaA Luis = new CColegaA("Luis", miMediador);

            ColegaB David = new ColegaB("David", miMediador);

            Ana.Enviar("Saludos a todos");
            Luis.Enviar("Como estan?");
            David.Enviar("Visiten Nicosiored");
            David.Recibir("David", "Hola Puta Mgare");
            Console.WriteLine();

            //Console.WriteLine("***** Verificamos censura ******");
            //Luis.Enviar("Los palabrota no me agradan");
            //Console.WriteLine();

            //miMediador.Bloqueo(Luis.Recibir);
            //Ana.Enviar("Vean los playList");
            //Console.WriteLine();

            //miMediador.Suscribir(Luis.Recibir);
            //David.Enviar("Me gusta programar");
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
