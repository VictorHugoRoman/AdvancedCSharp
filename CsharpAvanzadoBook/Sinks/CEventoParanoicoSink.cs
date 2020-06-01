using CsharpAvanzadoBook.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Sinks
{
    //Esta otra clase tambien tiene un handler y precisa su logica de manera diferente
    class CEventoParanoicoSink : IEventosCaldera
    {
        public void EAltaTemperatura(float t)
        {
            
        }

        //El codigo hanlder para EPocoCombustible
        public void EPocoCombustible(float c)
        {
            //Mandamos el mensaje de q qeuda poco combustible
            //Aqui poddemos adicionar mas logica q c lleve a cabo cuando suceda el evento
            Console.WriteLine("----Evento Paranoico----");
            Console.WriteLine("----PELIGRO----");
            Console.WriteLine("---->CASI SIN COMBUSTIBLE, {0} litros", c);
            Console.WriteLine("------------------------------------------");
        }
    }
}
