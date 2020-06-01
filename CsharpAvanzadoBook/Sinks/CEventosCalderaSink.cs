using CsharpAvanzadoBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    public class CEventosCalderaSink : IEventosCaldera
    {
        //El codigo del handler para EAltaTemperatura
        public void EAltaTemperatura(float t)
        {
            //Mandamos el mensaje de que queda poco combustible
            //Aqui podemos adicionar mas logica q c lleve a cabo cuando suceda el evento
            Console.WriteLine("----Evento Caldera----");
            Console.WriteLine("-------> Temperatura Alta, {0} grados", t);
            Console.WriteLine("--------");
        }

        //El codigo del handler para EPocoCombustible
        public void EPocoCombustible(float c)
        {
            //Mnadamos el msg d q queda poco combustible
            //Aqui podemos adicionar mas logica q c lleva a cabo cuando sucede el evento
            Console.WriteLine("----Evento Caldera-------");
            Console.WriteLine("-------> Queda poco combustible");
            Console.WriteLine("--------");
        }
    }
}
