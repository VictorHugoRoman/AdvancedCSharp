using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronDecorador.Interfaces;
using PatronesDeDiseño.PatronDecorador.Clases;

namespace PatronesDeDiseño.PatronDecorador.Clases
{
    class CMainPatronDecorador
    {
        public static void _Main()
        {
            //Creamos el componente central con tipo IComponente, para permitir la decoracion
            IComponente miAuto = new CAuto("2018", "4 Puertas", 200000);
            Console.WriteLine(miAuto);

            //Si necesitamos usar un metodo propio de CAuto, necesitamos hacer uso de un type cast
            ((CAuto)miAuto).Puertas(true);
            Console.WriteLine("----------------");

            //Decoramos el auto con un sistema de sonido, miAuto q es el nucleo o la clase original ahora le asignaremos el sistema Sonido 
            miAuto = new CSistemaSonido(miAuto);//miAuto se instancia con CAuto y esta clase implementa IComponente entonces podemos pasarsela al constructo de CSistemaSonido

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");

            //((CAuto)miAuto).Puertas(false);//arroja excepcion ya q CAuto se decoro al menos una vez

            //Decoramos el auto con un sistema de Nitrogeno, miAuto q es el nucleo o la clase original ahora le asignaremos el sistema Nitrogeno
            miAuto = new CNitrogeno(miAuto);//miAuto se instancia con CAuto y CAuto  implementa IComponente entonces podemos pasarsela al constructo de CNitrogeno

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");

            //Para usar algo propio del nitrogeno(CNitrogeno) necesitamos un typeCast
            ((CNitrogeno)miAuto).UsaN();
            Console.WriteLine("----------------");

            //Decoramos el auto con un sistema de Suspension, miAuto q es el nucleo o la clase original ahora le asignaremos el sistema Suspension
            miAuto = new CSuspension(miAuto);//miAuto se instancia con CAuto y CAuto  implementa IComponente entonces podemos pasarsela al constructo de CSuspension

            //Comprobamos la adicion de las caracteristicas
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);
            Console.WriteLine("----------------");

            //Ojo, No podemos usar metodos especificos una vez que  decoramos sobre ella o alguien en particular
            //((CNitrogeno)miAuto).UsaN();//arroja excepcion ya que CSuspension decoró despues que CNitrogeno 
            //((CAuto)miAuto).Puertas(false);//arroja excepcion ya q CAuto se decoro al menos una vez

            /*Podemos crear alguna estrategia para poder usar estos metodos propios una vez decorados por otras decoraciones
             * ((CNitrogeno)miAuto).UsaN(); ((CAuto)miAuto).Puertas(false);*/
            Console.ReadLine();
        }
    }
}
