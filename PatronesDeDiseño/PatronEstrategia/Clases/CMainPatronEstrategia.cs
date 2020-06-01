using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronEstrategia.Interfaces;
using PatronesDeDiseño.PatronEstrategia.Clases;

namespace PatronesDeDiseño.PatronEstrategia.Clases
{
    class CMainPatronEstrategia
    {
        public  static void _Main()
        {
            string dato, opcion = "";
            double x, y, r = 0;

            //La Variable q referencia al algoritmo
            //Instanciamos con un default para permitir compilacion correcta, solo para eso ya que si no instanciamos la interfaz al querer ejecutar el metodo(s) nos maracari error
            IOperacion miOperacion = new CSuma();
            while (opcion != "5")
            {
                Console.WriteLine("1-Suma,  2-Resta,  3-Multi, 4-Div, 5-Salir");
                opcion = Console.ReadLine();
                if (opcion == "5") break;
                Console.WriteLine("Dame el valor a: ");
                dato = Console.ReadLine();
                x = Convert.ToDouble(dato);
                Console.WriteLine("Dame el valor b");
                dato = Console.ReadLine();
                y = Convert.ToDouble(dato);
                //Aqui seleccionamos el algoritmo(estrategia) de acuerdo a la necesidad
                if (opcion == "1")
                    miOperacion = new CSuma();
                if (opcion == "2")
                    miOperacion = new CResta();
                if (opcion == "3")
                    miOperacion = new CMultiplicacion();
                if (opcion == "4")
                    miOperacion = new CDiv();

                //nuestro metodo abstracto operacion se ejecutaria segun la estrategia seleccionada
                r = miOperacion.operacion(x, y);
                Console.WriteLine("El resultado es {0}", r);
            }
        }
    }
}
