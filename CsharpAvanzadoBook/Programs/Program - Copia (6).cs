using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook
{
    class Program6
    {
        static void Main(string[] args)
        {
            #region CTelevisor Para ICloneable
            //Ejemplo con objetos q no c han clonado
            CTelevisor miTV = new CTelevisor();
            CTelevisor tuTV = miTV;//Aqui pensamos q hicimos un clonado
                                   //Vemos los objetos
            Console.WriteLine("Objetos sin ningun cambio \n");
            miTV.MuestraInformacion();
            tuTV.MuestraInformacion();
            //Modificamos un objeto
            tuTV.ColocarCosto(1300.80);
            //Vemos los 2 objectos
            Console.WriteLine("\nObjetos despues del cambio \n");
            miTV.MuestraInformacion();
            tuTV.MuestraInformacion();
            //***Lo Mismo pero con las Clase CRadio que si impleenta ICloneable
            CRadio miRadio = new CRadio();
            CRadio tuRadio = (CRadio)miRadio.Clone();//Aqui Hacemos el clonado
                                                     //Vemos los objetos
            Console.WriteLine("Objetos sin ningun cambio \n");
            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();
            //Modificamos un objeto
            tuRadio.CalcularCosto(800.50);
            //Vemos los 2 objectos
            Console.WriteLine("\nObjetos despues del cambio \n");
            miRadio.MuestraInformacion();
            tuRadio.MuestraInformacion();
            #endregion
            Console.ReadLine();

        }
    }
}
