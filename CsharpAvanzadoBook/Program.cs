using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Clases;
using CsharpAvanzadoBook.Interfaces;
using CsharpAvanzadoBook.Sinks;

namespace CsharpAvanzadoBook
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Usando CCaldera Sinks
            CCaldera miCaldera = new CCaldera(50.0f);
            //creamos el sink Eventos Caldera
            CEventosCalderaSink sinkNormal = new CEventosCalderaSink();
            //creamos el sink Paranoico
            CEventoParanoicoSink sinkParanoico = new CEventoParanoicoSink();
            //le indicamos a la caldera q c va a comunicar con el sink
            miCaldera.AdicionaSink(sinkNormal);//se ejecutara primero por la posicion en el array es el primero q ingreso
            miCaldera.AdicionaSink(sinkParanoico);//se ejecutara segundo por la posicion en el array es el segundo q ingreso
            //hacemos trabajar la caldera
            while (miCaldera.Combustible > 0)
            {
                miCaldera.trabajo();

            }
            #endregion
            
            Console.ReadLine();

        }
    }
}
