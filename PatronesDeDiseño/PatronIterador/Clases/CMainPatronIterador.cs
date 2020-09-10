using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronIterador.Clases;

namespace PatronesDeDiseño.PatronIterador.Clases
{
    class CMainPatronIterador
    {
        public static void _Main()
        {
            CContenedora datos = new CContenedora();
            //lo q hara aqui el foreach va a implementar lo q hemos construido en CContenedora
            //es decir le pedira a la clase Enumerador y ya q el forEach lo tenga  ira invocando el Reset() para 
            //colocarse al inicio, el MoveNext() para ver si hay o no elementos.
            //En el momento n l q no tenga mas elementos adentro de la coleccion el forEach finalizara, es decir, cuando
            //MoveNext() le regrese un false
            //y se continua con el resto del programa.
            //si el MoveNext retorna true, Current retorna el elemento q qquedara guardado en valor
            foreach (int valor in datos)
            {
                Console.WriteLine(valor);
            }

            Console.ReadLine();
        }
    }
}
