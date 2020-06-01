using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Interfaces
{/// <summary>
/// Interfaz de Callback
/// </summary>
    interface IEventosCaldera
    {
        /*
           en este tipo de interfaces ocupamos un tipo de objeto llamado sink, la clase de objeto sink tendrá los metodos q seran invocados
           cuando la clase llamadora tenga su evento.
        */

        //Este metodo se ejecuta cuando queda poco combustible
        //Recive como parametro la cantidad de combustible en la caldera
        void EPocoCombustible(float c); //Cuando se genere el evento, unicamente podrán invocarse metodos en el otro objetos que tengan estas mismas caracteristicas o q implementen estos metodos de la interfaz
        //Este evento se invoca cuando se ha excedido la temperatura de operacion
        //Recive como parametro la temperatura de la caldera
        void EAltaTemperatura(float t);
        //Aqui podemos adicionar mas eventos
    }
}
