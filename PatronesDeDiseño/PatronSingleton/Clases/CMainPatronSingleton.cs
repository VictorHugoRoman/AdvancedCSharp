using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronSingleton.Clases;

namespace PatronesDeDiseño.PatronSingleton.Clases
{
    class CMainPatronSingleton
    {
        public static void _Main()
        {
            //No se puede obtener la instancia directamente
            //CSingleton single = new CSingleton();

            //Obtenemos la instancia, se crea por primera vez
            CSingleton uno = CSingleton.ObtenInstancia();

            //Hacemos algo con la instancia
            uno.PonerDatos("Ana", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("----------");

            //Comprobamos q s la misma instancia
            //si lo es, tendrá el mismo estado
            //Obtenemos la instancia
            CSingleton dos = CSingleton.ObtenInstancia();            
            Console.WriteLine("--Volvemos a ejecutar dos = ObtenInstancia()--");
            dos.AlgunProceso();
            Console.WriteLine(dos);

            //Modificamos la instancia, la guardamos en otra variable
            //Obtenemos la instancia
            CSingleton tres = CSingleton.ObtenInstancia();
            Console.WriteLine("--Volvemos a ejecutar tres = ObtenInstancia()--");
            tres.PonerDatos("Sofia", 30); //Editamos la unica instancia
            tres.AlgunProceso();
            Console.WriteLine(tres);
            Console.WriteLine("----------");

            //Retornamos la instancia uno
            Console.WriteLine("--Ejecutamos la instancia creada en la variable uno");
            uno.AlgunProceso();
            Console.WriteLine(uno);

            Console.ReadLine();
        }
    }
}
