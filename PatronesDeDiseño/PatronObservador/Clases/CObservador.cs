using PatronesDeDiseño.PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronObservador.Clases
{
    //Si vamos a tener varios sujetos se puede crear una interfaz ISujeto
    //Observador La clase q espera la notificacion del sujeto(CSujeto)
    class CObservador : IObservador
    {
        private string nombre;
        private CSujeto sujeto;

        //Constructor
        public CObservador(string pNombre, CSujeto pSujeto)//recibimos un nombre y la referencia al Sujeto
        {
            nombre = pNombre;
            sujeto = pSujeto;
            sujeto.Suscribir(this);//añade a la lista del sujeto cada observador creado
        }
        #region Implementando IObservador
        //Este metodo es usado por el sujeto en el caso o modelo push
        public void Update(string mensaje)
        {
            //en una aplicacion real llevamos todo un proceso con la informacion recibida con el cambio de estado

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Modelo Push, {0}-{1}", nombre, mensaje);
        }

        //Aqui es para el caso o modelo pull
        public void UpdatePull()//el sujeto nos avisa de un cambio de estado, pero aqui decidimos si llevamos a cabo la lectura o no de ese nuevo estado 
        {
            //Obtenemos del sujeto
            //puede ir mas logica para decidir cuando vamos a leer o no la informacion del sujeto
            int n = sujeto.N; //aqui llevamos la lectura de ese nuevo estado
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Modelo Pull, {0}-{1}", nombre, n);
        }
        #endregion
    }
}
