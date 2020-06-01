using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program4
    {
        static void Main(string[] args)
        {
            #region Usando CTelevisor Para Interfaz
            //Implementanod Interfaz IProducto
            //una interfaz no c puede instanciar
            //IProducto iproducto = new IProducto();
            //Instancioamos una clase q implemente la interfaz
            CTelevisor cTelevisor = new CTelevisor();
            //invomcamos a los comportamientos de la interfaz IProducto
            cTelevisor.calculaImpuesto(0.15);
            cTelevisor.MuestraInformacion();
            //invocamos metodos propíos d la clase
            cTelevisor.ColocarCosto(567.82);
            cTelevisor.calculaImpuesto(0.16);
            cTelevisor.MuestraInformacion();
            #endregion
            Console.ReadLine();

        }
    }
}
