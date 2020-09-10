using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronInterprete.Clases;
using PatronesDeDiseño.PatronSingleton.Clases;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    class CMainPatronInterprete
    {
        public static void _Main()
        {
            string expresionEvaluar = "MCMXCIX";
            CContexto contexto = new CContexto(expresionEvaluar);

            //Se contruye el arbol de parse
            //cada clase corresponde a una regla en la gramatica
            //empezamos por los miles
            List<CExpresion> Arbol = new List<CExpresion>();
            Arbol.Add(new CExpresionMiles());
            Arbol.Add(new CExpresionCientos());
            Arbol.Add(new CExpresionDecenas());
            Arbol.Add(new CExpresionUnidad());

            //Interpretamos siguiendo las reglas gramaticales q estan n l arbol
            foreach (var exp in Arbol)
                exp.Interpretar(contexto);
            Console.WriteLine("El numero romano {0} es {1} en decimal", expresionEvaluar, contexto.Valor);
            Console.ReadLine();
        }
    }
}
