using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComando.Clases
{
    //Esta clase será la q vaya llevando las acciones y no el cliente(program) del invoker(control remoto en este proyecto)
    class CAutomovil
    {
        //Comandos para esta clase en concreto, puediera existir un clase q represente a un camion con diferentes comandos

        public void Encender()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha encendido el auto");
        }
        public void Apagar()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Se ha apagado el auto");
        }
        public void ColocarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Alarma Encendida");
        }
        public void QuitarAlarma()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alarma Apagada");
        }
    }
}
