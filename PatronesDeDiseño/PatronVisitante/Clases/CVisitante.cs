using PatronesDeDiseño.PatronVisitante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronVisitante.Clases
{
    //Clases q contienen los metodos que iterarán a la estructura y aplicarán las operaciones
    class CVisitante : IVisitante
    {
        private int conteo; //para conocer el conteo total de objetos q tenemos n l botiquin
        private int clasificaciones; //para conocer la cantidad total de clasificaciones
        private double total; //para conocer el costo total de todos los objetos q tenemos en el botiquin

        public int Conteo  { get => conteo; set => conteo = value; }
        public int Clasificaciones { get => clasificaciones; set => clasificaciones = value; }
        public double Total{ get => total; set => total = value; }

        public void ContarElementos(CElemento pElemento) //para recorrer el arbol 
        {
            //Nos mandamos como visitante al elemento
            pElemento.Aceptar(this);

            //Vemos si tiene hijos
            if (pElemento.hijo != null)
                ContarElementos(pElemento.hijo); ////pasamos al hijo

            //Vemos si tenemos siguiente
            if (pElemento.siguiente != null)
                ContarElementos(pElemento.siguiente); //pasamos al hermano
        }

        #region Implementando IVisitante
        //**Usamos sobrecargas de metodos para reconocer a los diferentes tipos de elementos (Elemento o ElementoL)
        //**Pudimos haber usado reflection para conocerlos.

        //cuando el nodo es una sola hoja o cuando el elemento no tenga hijos
        public void Visitar(CElemento pElemento)
        {
            conteo++; //incerementamos el conteo de elementos
            total += pElemento.Costo;
        }

        //
        public void Visitar(CElementoL pElemento)
        {
            clasificaciones++;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("No Conteos");
        }
        #endregion
    }
}
