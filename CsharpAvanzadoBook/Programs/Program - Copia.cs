using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program1
    {
        static void Main(string[] args)
        {
            #region Usando CTelevisor para IComparable
            //IComparable implementacion
             CTelevisor[] televisors = new CTelevisor[]
             {
                 new CTelevisor(){nombre = "Zinco", costo=1500.50},
                 new CTelevisor(){nombre = "VW", costo=2300.45},
                 new CTelevisor(){nombre = "BMW", costo=575.85}
             };
             Console.WriteLine("---Antes de ordenar \n");
             Array.ForEach(televisors, x => Console.WriteLine(x.nombre));
             Array.Sort(televisors);//sort ocupa q la clase implemente la interfaz IComparable el metodo compareTo
             Console.WriteLine("\n---Despues de ordenar \n");
             Array.ForEach(televisors, x => Console.WriteLine(x.nombre));
            #endregion            
            Console.ReadLine();

        }
    }
}
