using PatronesDeDiseño.PatronVisitante.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronVisitante.Interfaces
{
    //Interfaz para las clases q actuaran como visitantes
    interface IVisitante
    {
        //Utilizaremos un arbol para hacer la estructura de objetos
        //Vamos variar a los elementos como si fuese una hoja y como si tuviesen hijos

        //Un metodo visitar para cada tipo de elemento o un metodo con sobrecargas
        void Visitar(CElemento pElemento); //Este metodo funcionara para las hojas
        void Visitar(CElementoL pElemento);//Este metod funcionara para aquellose elementos q funcionen como raiz de un subarbol
    }
}
