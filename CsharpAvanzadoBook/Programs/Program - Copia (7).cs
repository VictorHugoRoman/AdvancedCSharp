using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program7
    {
        static void Main(string[] args)
        {
            #region Usando CTiendaTelevisor para IEcloneable, IComparable, IEnumerable
            CTiendaTelevisor miTiendaTV = new CTiendaTelevisor("Coppel");
            CTiendaTelevisor tuTiendaTV = (CTiendaTelevisor)miTiendaTV.Clone();
            CTiendaTelevisor tuTiendaTV2 = miTiendaTV;
            Console.WriteLine("---clonando miTienda a tuTienda...\n\n");
            Console.WriteLine("---Objetos antes de modificarlos\n");
            Console.WriteLine("---Objeto mi tienda");
            Array.ForEach(miTiendaTV.televisores, x => Console.WriteLine(string.Concat(x.nombre, " - ", x.costo)));
            Console.WriteLine("---Objeto tu tienda");
            Array.ForEach(tuTiendaTV.televisors, x => Console.WriteLine(string.Concat(x.nombre, " - ", x.costo)));
            bool iguales = false;
            iguales = miTiendaTV.Equals(tuTiendaTV);
            iguales = miTiendaTV.Equals(tuTiendaTV2);//retorna true pórque tuTiendaTV2 no esta clonado
            Console.WriteLine(string.Concat("miTienda es igual a tuTienda? ", iguales.ToString()));

            Console.WriteLine("\n---Objetos despues de modificarlos\n");
            tuTiendaTV.nombreTienda = "FAMSA";
            tuTiendaTV.televisores[0].costo = 1;
            tuTiendaTV.televisores[1].costo = 1;
            tuTiendaTV.televisores[2].costo = 1;
            tuTiendaTV.televisors[0].costo = 1;
            tuTiendaTV.televisors[1].costo = 1;
            tuTiendaTV.televisors[2].costo = 1;
            Console.WriteLine("---Objeto mi tienda"); 
            Array.ForEach(tuTiendaTV.televisores, x => Console.WriteLine(string.Concat(x.nombre, " - ",x.costo)));
            Console.WriteLine("---Objeto tu tienda");
            Array.ForEach(tuTiendaTV.televisors, x => Console.WriteLine(string.Concat(x.nombre, " - ", x.costo)));
            iguales = miTiendaTV.Equals(tuTiendaTV);
            Console.WriteLine(string.Concat("miTienda es igual a tuTienda? ", iguales.ToString()));
            #endregion
            Console.ReadLine();
        }
    }
}
