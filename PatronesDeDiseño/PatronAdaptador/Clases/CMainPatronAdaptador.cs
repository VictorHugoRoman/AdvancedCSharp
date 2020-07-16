using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronAdaptador.Clases;
using PatronesDeDiseño.PatronAdaptador.Interfaces;

namespace PatronesDeDiseño.PatronAdaptador.Clases
{
    class CMainPatronAdaptador
    {
        public  static void _Main() //representa al cliente en el UML
        {
            int resultado = 0;
            //usamos la interfaz q l cliente conoce con una clase q conoce
            ITarget calcu = new CCalcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine("--------------");
            Console.WriteLine("\nUsando el adaptador");
            Console.ReadLine();

            //Hacemos Uso del adaptador, para adaptar la clase CCalculadoraArray
            //CAdaptador implementa ITarget y la clase a adaptar
            //CAdaptador viene siendo como un puente para ejecutar clase q no fueran diseñadas conjuntamente
            calcu = new CAdaptador();

            //Usamos el adaptador pára hacer la operacion
            resultado = calcu.Sumar(5, 6);

            Console.WriteLine("El resultado es {0}", resultado);
            Console.ReadLine();
        }
    }
}
