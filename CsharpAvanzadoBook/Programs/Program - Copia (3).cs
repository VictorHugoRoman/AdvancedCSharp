using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program3
    {
        static void Main(string[] args)
        {
            #region Usando CAutomovil Para ICloneable
            //ICloneable.Clone() implementado
            CAuto auto1 = new CAuto("March", 170000);
            CAuto auto2 = auto1; //esto no es clonacion, aqui simplemente pasamos la referencia del objeto creado con auto1

            auto1.CalculaTenencia(0.10);
            auto2.CalculaTenencia(0.10);

            //Imprimimos
            auto1.MuestraInformacion();
            auto2.MuestraInformacion();

            Console.WriteLine("--------------");

            //hacemos un cambio, si fuera un clon solo uno cambiaria
            auto1.Costo = 60000;

            //Imprimimos
            auto1.MuestraInformacion();
            auto2.MuestraInformacion();

            Console.WriteLine("===========================");

            //Ahoria si hacemos un Clon
            CAuto auto3 = (CAuto)auto1.Clone();

            auto1.MuestraInformacion();
            auto3.MuestraInformacion();
            Console.WriteLine("--------------");

            //modificamos uno, el otro no debe alterarse
            auto1.Costo = 250000;

            //imprimimos para verificar
            auto1.MuestraInformacion();
            auto3.MuestraInformacion();
            Console.WriteLine("--------------");
            Console.ReadLine();
            #endregion
            Console.ReadLine();

        }
    }
}
