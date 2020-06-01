using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program2
    {
        static void Main(string[] args)
        {
            #region Usando CRectangulo Para IComparable
            //IComparable.CompareTo() implementado
            CRectangulo[] rectangulos = new CRectangulo[5];
            rectangulos[0] = new CRectangulo(7, 5);
            rectangulos[1] = new CRectangulo(4, 1);
            rectangulos[2] = new CRectangulo(2, 8);
            rectangulos[3] = new CRectangulo(1, 9);
            rectangulos[4] = new CRectangulo(4, 3);
            foreach (CRectangulo r in rectangulos)
                Console.WriteLine(r);
            Console.WriteLine("-------------");
            Array.Sort(rectangulos);//ejecucion de Icomparable.CompareTo
            foreach (CRectangulo r in rectangulos)
                Console.WriteLine(r);
            Console.ReadLine();
            #endregion
            Console.ReadLine();
        }
    }
}
