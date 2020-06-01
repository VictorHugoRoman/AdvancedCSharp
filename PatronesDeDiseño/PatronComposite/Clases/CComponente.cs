using PatronesDeDiseño.PatronComposite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComposite.Clases
{
    //Clase que representa a un Componente
    class CComponente<T> : IComponente<T> //como la interfaz a implementar es generica, la clase CComponente tambien db ser
    {
        public CComponente(T _nombre)
        {
            Nombre = _nombre;
        }
        #region Implentando IComponente
        //Identificador del componente
        public T Nombre { get; set; }
        public void Adicionar(IComponente<T> _elemento)//Como estamos en un componente, un componente no puede guardar a otro componente o a un compuesto
        {
            Console.WriteLine("Solo se adiciona a los compuestos, no a los componentes ");
        }

        public IComponente<T> Borrar(T _elemento)
        {
            Console.WriteLine("No se puede eliminar directamente ");
            return this; //regresamos el mismo nodo, es decir, el mismo componente actual
        }

        public IComponente<T> Buscar(T _elemento)
         {
            if (_elemento.Equals(Nombre)) //si es el mismo regresamos la misma instancia
                return this;
            else
                return null;
        } 

        public string Mostrar(int _profundidad) //_profundidad representa q tan profundo esta el componente dentro de la jerarquia 
        {
            //Colocamos la cantidad de - segun la profundidad
            return new String('-', _profundidad) + Nombre + "(SoyComponente)" + "\n\r "; //String('-', _profundidad)  nos repetira el string segun el valor de _profundidad
        }
        #endregion
    }
}
