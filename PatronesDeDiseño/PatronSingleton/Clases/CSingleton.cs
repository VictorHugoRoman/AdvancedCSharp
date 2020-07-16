using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronSingleton.Clases
{
    //Esta tecnica de singleton funciona cuando no usamos concurrencia/paralelismo, para ello tendremos q asegurarnos
    //q la clase exista unicamente en el hilo llamado
    class CSingleton
    {
        //Aqui guardamos la unica instancia q va a existir
        private static CSingleton instancia;

        //Datos propios de la clase
        private string nombre;
        private int edad;

        //creamos el constructo privado q s forzoso para el singleton,
        //cuando creamos un constructor privado no c pueda crear la instancia ya q no hay acceso desde afuera
        //para ello usamos el metodo ObtenInstancia()
        private CSingleton()
        {
            nombre = "Sin Asignar";
            edad = 99;
        }

        //como los metodos static se pueden ejecutar sin instanciar la clase
        //lo usamos para crear una
        public static CSingleton ObtenInstancia()
        {
            //Verificamos si no existe la instancia
            if (instancia is null)
            {
                //Si no existe, instanciamos
                //aqui si podemos instanciar la clase porque estamos adentro de la misma
                instancia = new CSingleton();
                Console.WriteLine("--- Instancia creada por primera vez ---");
            }

            //Regresamos la instancia q fue creada anteriormente
            return instancia;
        }
        
        //Metods propios de la clase
        public override string ToString()
        {
            return string.Format("La Persona {0}, Tiene edad de {1}", nombre, edad);
        }
        public void PonerDatos(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }

        //Esto representa cualquier otro objeto
        //solo para ejemplificar q la clase singleton puede llevar otras cosas no relacionadas con la admon de la instancia
        public void AlgunProceso()
        {
            Console.WriteLine("{0} está trabajando en algo", nombre);
        }
    }
}
