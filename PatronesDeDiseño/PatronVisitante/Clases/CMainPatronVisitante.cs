using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronVisitante.Clases;

namespace PatronesDeDiseño.PatronVisitante.Clases
{
    //La clase q crea la estructura y la llena de datos
    class CMainPatronVisitante
    {
        public static void _Main()
        {
            double totalCosto = 0;
            int totalObjetos = 0;
            int totalClasificaciones = 0;

            //Estructura compuesta de tipos relacionados
            //Creamos la estructura de objetos, recordar CElementoL hereda de CElemento por ello lo podemos pasar como parametro
            CElemento estructuraObjeto = 
                new CElemento(89.0, "Botiquin", 
                new CElemento(25.60, "Termometro",
                new CElementoL(//ramificamos
                    new CElemento(35.8, "Antibiotico", 
                    new CElemento(15.5, "Antiacido", 
                        new CElementoL(//ramificamos
                            new CElemento(12.8, "Aspirina", null),//null no tiene hermano o siguiente
                            new CElemento(56.6, "Anti Inflamatorio", null)//null no tiene hermano o siguiente
                       ))),
                    new CElemento(12.8, "Grasa", 
                    new CElemento(23.5, "Cinta", 
                    new CElemento(112.5, "Tijeras", null))))//null no tiene hermano o siguiente
               ));

            CVisitante visitante = new CVisitante();
            //visitante va contando cuantos objetos tenemos, cuantas clasificaciones, esta acumulando el total de los costos
            visitante.ContarElementos(estructuraObjeto);
            

            totalCosto = visitante.Total;
            totalClasificaciones = visitante.Clasificaciones;
            totalObjetos = visitante.Conteo;
            Console.WriteLine("Se tienen {0} objetos con un costo de ${1} en {2} clasificaciones", totalObjetos, totalCosto, totalClasificaciones);

            Console.ReadLine();
        }
    }
}
