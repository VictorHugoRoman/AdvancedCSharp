using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronObservador.Clases;

namespace PatronesDeDiseño.PatronObservador.Clases
{
    class CMainPatronObservador
    {
        public static void _Main()
        {
            //Creamos el sujeto primeramente
            CSujeto miSujeto = new CSujeto();

            //posteriormente, creamos los observadores
            //pasammos la referencia del sujeto miSujeto para q sepan comunicarse con el
            CObservador a = new CObservador("A", miSujeto);
            CObservador b = new CObservador("B", miSujeto);
            CObservador c = new CObservador("C", miSujeto);

            //Trabajamos
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo();//Trabajo notifica a los observadores con el metodo o modelo push o pull

            //Alguien sale de la lista
            Console.WriteLine("\n----- Desuscribir B------\n");
            miSujeto.Desuscribir(b);

            //Trabajamos
            for (int n = 0; n < 5; n++)
                miSujeto.Trabajo(); //Trabajo notifica a los observadores con el metodo o modelo push o pull

            Console.ReadLine();
        }
    }
}
