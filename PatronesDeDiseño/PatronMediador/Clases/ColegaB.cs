using PatronesDeDiseño.PatronMediador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMediador.Clases
{
    class ColegaB : IColega
    {
        private CMediador mediador;
        private string nombre;
        private int conteo; // para contar la cantidad de mensajes q ha recibido

        public ColegaB(string pNombre, CMediador pMediador)
        {
            nombre = pNombre;
            //Tenemos la referencia al mediador
            mediador = pMediador;

            //Nos Suscribimos
            mediador.Suscribir(Recibir);
        }

        #region Implementando IColega
        //Metodo para el envio de los mensajes, podemos usar otro metodo para procesar el mensaje y usar este metodo solo para enviar mnsgs
        public void Enviar(string mensaje)
        {
            //Aqui colocamos la logica para l envio de mensajes
            //no necesariamente db ser un parametro
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("->[{0}]:{1}", nombre, mensaje);
            mediador.Enviar(nombre, mensaje);
        }

        //este metodo usará el mediador para el envio de los mensajes con el delegado
        public void Recibir(string emisor, string mensaje)
        {
            conteo++;
            //Lleva a cabo la recepcion segun su estilo
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<-[{0},{1}]({2}): {3}", nombre, emisor, conteo, mensaje); //le damos formato al mensaje solo para la disticion de la clase ColegaB
        }
        #endregion
    }
}
