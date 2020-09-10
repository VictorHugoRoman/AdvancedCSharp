using PatronesDeDiseño.PatronObservador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronObservador.Clases
{
    //Si vamos a tener varios sujetos se puede crear una interfaz ISujeto.
    //Sujeto, la calse q cuando cambia de estado, notifica a los observadores(CObservadores)
    class CSujeto
    {
        private List<IObservador> observadores = new List<IObservador>();
        private string mensaje;
        private Random rnd = new Random();
        private int n;
        public int N { get => n; set => n = value; } //podemos mandar cualquier tipo de dato, un json, xml, string, float, etc.

        public void Suscribir(IObservador suscrito)
        {
            //Lo adicionamos a la lista
            observadores.Add(suscrito);
        }

        public void Desuscribir(IObservador suscrito)
        {
            //Recomendable poner codigo de seguridad
            observadores.Remove(suscrito);
        }

        private void Notificar()
        {
            //Notificamos el nuevo estado a todos los observadores
            //q esten suscritos
            foreach (IObservador o in observadores)
            {
                //Descomentamos el metodo q queremos usar y comentamos el otro
                o.Update(mensaje); //Modo push
                //o.UpdatePull();  //Modo Pull
            }
        }

        //Aqui simulamos el trabajo del observador y un cambio de estado q necesita ser modificado
        public void Trabajo()
        {
            n = rnd.Next(10);
            if (n % 2 == 0)//si es par
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---- Nuevo estado valido ----");
                mensaje = string.Format("El nuevo valor es {0}", n);
                Notificar();
            }
        }
    }
}
