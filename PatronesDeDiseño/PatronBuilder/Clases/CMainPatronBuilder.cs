using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronBuilder.Clases;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    class CMainPatronBuilder
    {
        public static void _Main()
        {
            Director miDirector = new Director();

            //Construimos un auto economico
            BuilderNormal normal = new BuilderNormal();
            //le decimos al director q construya un auto normal
            miDirector.Construye(normal);

            //Obtenemos el auto
            Producto auto1 = normal.ObtenProducto();

            auto1.MostrarAuto();

            Console.WriteLine("------------");

            //Construimos un auto deportivo
            BuilderDeportivo deportivo = new BuilderDeportivo();
            //Le decimos al director q construya un auto deportivo
            miDirector.Construye(deportivo);

            //Obtenemos el auto
            Producto auto2 = deportivo.ObtenProducto();

            auto2.MostrarAuto();

            Console.ReadLine();
        }
    }
}
