using PatronesDeDiseño.PatronMediador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMediador.Clases
{
    //Implementamos un estilo de colega
    class CColegaA: IColega
    {
        private CMediador mediador; //variable de referencia hacia l mediador
        private string nombre; //nombre del colega

        public CColegaA(string pNombre, CMediador pMediador)
        {
            nombre = pNombre;

            //Tenemos la referencia al mediador
            mediador = pMediador;

            //Nos Suscribimos
            mediador.Suscribir(Recibir);
        }

        #region Implementando IColega
        //este metodo usará el mediador para el envio de los mensajes con el delegado
        public void Recibir(string emisor, string mensaje)//metodo de la interfaz q c conecta con el delegado del mediador pasandole las firmas q l corresponden
        {
            //Lleva a cabo la recepcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("soy {0}, recibi de {1}: {2}", nombre, emisor, mensaje);
        }

        //Metodo para el envio de los mensajes, podemos usar otro metodo para procesar el mensaje y usar este metodo solo para enviar mnsgs
        public void Enviar(string mensaje)
        {
            //Aqui colocamos la logica para el envio de los mensajaes
            //No Necesariamente db ser un parametro
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Soy {0}, envio:{1}", this.nombre, mensaje);//Hasta aqui enviamos el mensaje en pantalla
            
            //aqui se envia el mensaje a los colegas suscritos en el delegado del Mediador
            //es decir, ejecuta la funcion Recibir
            mediador.Enviar(this.nombre, mensaje);
        }
        #endregion
    }
}
