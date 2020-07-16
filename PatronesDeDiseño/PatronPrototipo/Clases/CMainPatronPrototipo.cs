using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronPrototipo.Clases;
using PatronesDeDiseño.PatronPrototipo.Interfaces;

namespace PatronesDeDiseño.PatronPrototipo.Clases
{
    class CMainPatronPrototipo
    {
        public static void _Main() //representa al cliente en el UML
        {
            //Creamos Administrador, lo primero q tenemos q hacer
            CAdminPrototipos admin = new CAdminPrototipos();

            //obtenemos dos instancias
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            //Verificamos que tengan los valores del prototipo original
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------------");

            //Modificamos el estado, cada uno db d tener su propia instancia
            uno.Nombre = "Ana";
            dos.Nombre = "Chepe";

            //Verificamos q cada qien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("--------------");

            //Creamos una instancia
            CAuto auto = new CAuto("Nissan", 250000);

            //Lo Colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto de ese prototipo
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el estado
            auto2.Modelo = "Honda";

            //Verificamos que tengan los valores del prototipo original
            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("--------------");

            //Obtenemos una instancia de la clase con rendimiento costoso, simplemente obtenemos un clon con la instancia inicial y asi no c recalcula 
            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }
    }
}
