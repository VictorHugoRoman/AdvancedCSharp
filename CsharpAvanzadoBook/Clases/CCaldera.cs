using CsharpAvanzadoBook.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    //Esta clase representa la caldera
    class CCaldera
    {
        //Datos necesarios
        private float combustible, temperatura;
        //Este arreglo contiene los Sinks de la Caldera
        ArrayList misSinks = new ArrayList();
        //Constructor
        public CCaldera(float combInicial)
        {
            //Asignamos el combustible
            combustible = combInicial;
            //Inicializamos la temperatura
            temperatura = 10.0f;
        }
        public float Combustible { get { return combustible; } }
        //Este metodo inndica el trabajo de la caldera
        public void trabajo()
        {
            //Reducimos el combustible
            combustible -= 0.3f;
            //Incrementamos la temperatura
            temperatura += 0.8f;
            //Mostramos la informacion, se muestra despues de la ejecucion de los eventos
            Console.WriteLine("datos trabajo(): Combustible={0}, Temperatura={1}", combustible, temperatura);
            //Verificamos si existe la condicion necesario para hacer una llamada callback y generar el evento
            if (combustible < 5.0f)
            {
                //Recorremos todos los sinks relacionados con la caldera enviandole el msg a cada uno de ellos para q
                //actue segun su logica
                foreach (IEventosCaldera evento in misSinks)
                {
                    //Aqui hacemnos la llamada callback
                    evento.EPocoCombustible(combustible);
                }
            }
        }
        //Los Siguientes metodos proveen la funcionalidad para la administracion de los sink
        //Adicionamos un Sink
        public void AdicionaSink(IEventosCaldera sink)
        {
            //Adicionamos el sink al Array
            misSinks.Add(sink);
        }
        //Eliminamos un sink
        public void BorrarSink(IEventosCaldera sink)
        {
            //Eliminamos del ArrayList el sink
            misSinks.Remove(sink);
        }
    }
}
