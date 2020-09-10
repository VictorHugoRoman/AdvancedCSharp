using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMediador.Clases
{
    class CMediador 
    {
        //Creamos un delegadoq usaremos para invocar los metodos
        //metodo delegate para conectarnos al metodo recibir de la interfaz IColega
        //para asi poder invocar el metodo recibir de diferentes colegas
        public delegate void dEnvio(string emisor, string mensaje); //este delegado se puede conectar a cualquier metodo q tenga como parametro 2 string
        dEnvio enviarMensaje; //variable para mantener nuestra lista de colegas y para llevar a cabbo las invocaciones

        //Adicionamos el metodo invocar
        public void Suscribir(dEnvio metodo)//recibe como parametro el metodo de aquel colega q queremos q c suscriba a este mediador
        {
            enviarMensaje += metodo;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Suscrito ---");
        }


        //Metodo para enviar el mensaje a los colegas suscritos en el delegado dEnvio
        public void Enviar(string emisor, string mensaje)
        {
            //Usamos el mediador para censurar
            if (mensaje.Contains("palabrota")) // una simple caracteristica d lo q puede hacer el mediador
                mensaje = mensaje.Replace("palabrota", "***********");
          
            //Enviamos los mensaje correspondientes via delegado
            //ejecuta la funcion Recibir de los Colegas suscritos al delegado
            enviarMensaje(emisor, mensaje);//como enviarMensaje s d tipo delegado podemos invocar los metods adicionados al delegado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Mensajes enviados ----");
        }

        //Quitamos el metodo del delagado, ya no sera invocado 
        public void Bloqueo(dEnvio metodo)
        {
            enviarMensaje -= metodo; //quitamos el metodo del delegado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--- Bloqueo ---");
        }
    }
}
