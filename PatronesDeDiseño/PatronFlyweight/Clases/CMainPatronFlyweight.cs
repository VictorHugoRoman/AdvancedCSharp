using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronFlyweight.Interfaces;
using PatronesDeDiseño.PatronFlyweight.Clases;

namespace PatronesDeDiseño.PatronFlyweight.Clases
{
    class CMainPatronFlyweight
    {
        public static void _Main()
        {
            int i = 0;
            #region UML(Unshared) state. Listas, Tipos de Recetas
            //Esta lista contendran los diferentes FlyWeight
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();
            #endregion

            //flyWf seran los objetos tipo FlyWeight, este objeto puede pertenecer a diferentes colecciones
            CFlyweightFactory flyWf = new CFlyweightFactory();

            //Creamos los productos y guardamos los indices en el q c guardó (i = flyWf.Adiciona("NombProd")),
            //en las Listas Tipos de Recetas Guardamos los indices del producto,
            //de esta manera no creamos varias veces el mismo producto para guardarlo en las listas
            //simplemente guardamos su indice en este caso. pero pudo haber sido una varible de referencia

            i = flyWf.Adiciona("Hamburguesa");//Guardamos el indice n l q c adicionó, es igual para las demas
            Americana.Add(i);//Guardamos el indice en cada seccion en la q puede estar Hamburguesas
            Carnes.Add(i);
            Rapida.Add(i);

            i = flyWf.Adiciona("Wisconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flyWf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flyWf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flyWf.Adiciona("Tacos al Pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flyWf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flyWf.Adiciona("Nopales");
            Mexicana.Add(i);
            Ensaladas.Add(i);

            i = flyWf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            //Mostramos y llevamos a cabo proceso en la comida rapida
            foreach (var n in Rapida)//Recorremos la Lista de Receta
            {
                //flyWf es d tipo CFlyweightFactory y esta clase tiene implementado un indexer
                CReceta receta = (CReceta)flyWf[n];//hacemos uso de el indexer

                //aqui estamos haciendo la parte del estado extrinseco(parte del patron), 
                //ese estado q no c encuentra de manera natural adentro del objeto 
                //sino q c obtiene a traves de un calculo
                receta.CalculaCosto();
                //Mostramos el nombre y el costo del producto,
                //donde nombre es el estado intrinseco(parte del patron), el estado q c esta compartiendo entre todos
                //los demas objetos q tengamos creados
                receta.Mostrar();
            }
            Console.WriteLine("------------");
            //Mostramos y llevamos a cabo proceso en la comida americana
            //no calculamos el costo o el estado extrinseco
            foreach (var n in Americana)//Recorremos la Lista de Receta
            {
                //flyWf es d tipo CFlyweightFactory y esta clase tiene implementado un indexer
                CReceta receta = (CReceta)flyWf[n];//hacemos uso de el indexe

                //aqui estamos haciendo la parte del estado extrinseco(parte del patron), 
                //ese estado q no c encuentra de manera natural adentro del objeto 
                //sino q c obtiene a traves de un calculo
                //receta.CalculaCosto();
                //Mostramos el nombre y el costo del producto,
                //donde nombre es el estado intrinseco(parte del patron), el estado q c esta compartiendo entre todos
                //los demas objetos q tengamos creados
                receta.Mostrar();
            }
            Console.WriteLine("------------");
            //intentamos adicionar un ya existente
            i = flyWf.Adiciona("Pizza");
            Console.WriteLine("------------");
            //Mostramos y llevamos a cabo proceso en las Ensaladas
            foreach (var n in Ensaladas)//Recorremos la Lista de Receta
            {
                //flyWf es d tipo CFlyweightFactory y esta clase tiene implementado un indexer
                CReceta receta = (CReceta)flyWf[n];//hacemos uso de el indexe
                 
                //aqui estamos haciendo la parte del estado extrinseco(parte del patron), 
                //ese estado q no c encuentra de manera natural adentro del objeto 
                //sino q c obtiene a traves de un calculo
                receta.CalculaCosto();
                //Mostramos el nombre y el costo del producto,
                //donde nombre es el estado intrinseco(parte del patron), el estado q c esta compartiendo entre todos
                //los demas objetos q tengamos creados
                receta.Mostrar();
            }
            Console.WriteLine("------------");
            //Mostramos todas las recetas q c encuentram dentro del factory
            for (int m = 0; m < flyWf.Conteo; m++)
            {
                CReceta receta = (CReceta)flyWf[m];
                receta.Mostrar();
            }
            Console.ReadLine();
        }
    }
}
