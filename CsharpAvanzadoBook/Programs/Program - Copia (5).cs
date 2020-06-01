using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program5
    {
        static void Main(string[] args)
        {
            #region Usando CTiendaTelevisor Para IEnumerable
            //IEnumerable Implementado
             CTiendaTelevisor miTienda = new CTiendaTelevisor("Coppel");
             //foreach (CTelevisor tv in miTienda) //si le pasamos miTienda al forEach recorre el primer arreglo declarado en CTiendaTelevisor
             foreach (CTelevisor tv in miTienda.televisores) //CTiendaTelevisor tiene implementado IEnumerable por eso la podemos iterar
             {
                 //Calculamos su impuesto
                 tv.calculaImpuesto(0.16);
                 //Mostramos la informacion
                 tv.MuestraInformacion();
             }
            #endregion
            
            Console.ReadLine();

        }
    }
}
