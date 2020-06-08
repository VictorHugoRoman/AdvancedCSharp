using PatronesDeDiseño.PatronFlyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFlyweight.Clases
{
    //Esta clase representa la fabrica para q se encargue de administrar a los flyWeight
    class CFlyweightFactory 
    {
        //puede ser cualquier tipo de coleccion, en este caso List
        private List<IFlyweight> flyweights = new List<IFlyweight>();//Aqui se guardan los objetos creados q implemente a la interfaz IFlyweight, por ende son objetos Flyweihgt
        private int conteo = 0;
        public int Conteo { get => conteo; set => conteo = value; }
        public int Adiciona(string _nombre)
        {
            //Verficamos si ya existe
            bool existe = false;
            foreach (IFlyweight f in flyweights)
                if (f.ObtenNombre() == _nombre) existe = true; //indicamos q el objeto ya existe por el nombnre
            if (existe)
            {
                Console.WriteLine("El Objeto ya existe, no se ha adicionado");
                return -1;
            }
            else //creamos un nuevo objeto CReceta
            {
                CReceta miReceta = new CReceta();
                miReceta.ColocaNombre(_nombre);
                flyweights.Add(miReceta);
                conteo = flyweights.Count; //obtenemos el  numero de objetos de la lista
                return conteo - 1; //retornamos el indice del objeto q añadimos
            }
        }
        //creamos un indexer
        public IFlyweight this[int index]//this = CFlyweightFactory, IFlyweight = a cualquier clase implementando a esta interfaz
        {
            get { return flyweights[index]; }
        }
    }
}
