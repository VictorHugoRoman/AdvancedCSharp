using PatronesDeDiseño.PatronComposite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComposite.Clases
{
    //Clase que representa a un Compuesto
    class CCompuesto<T> : IComponente<T> //como la interfaz a implementar es generica, la clase CCompuesto tambien db ser generica
    {
        //Lista donde guardamos los elementos(Componentes) q va a guardar
        List<IComponente<T>> elementos; //para guardar los elementos  q compuesto tendra  
        public CCompuesto(T _nombre)
        {
            Nombre = _nombre;
            //Instanciamos la lista
            elementos = new List<IComponente<T>>();
        }
        #region Implentando IComponente
        //Identificador del componente
        public T Nombre { get; set; }
        public void Adicionar(IComponente<T> _elemento)//Como estamos en un componente, un componente no puede guardar a otro componente
        {
            elementos.Add(_elemento);
        }

        public IComponente<T> Borrar(T _elemento)
        {
            //Buscamos el elemento a borrar
            IComponente<T> elemento = this.Buscar(_elemento);

            //si la encontramos, la eliminamos de la lista
            if (!(elemento is null))
                (this as CCompuesto<T>).elementos.Remove(elemento);
            return this; //retornamos la instancia actual
        }

        public IComponente<T> Buscar(T _elemento)
        {
            //Si somos quien se busca nos regresamos
            if (Nombre.Equals(_elemento))
            {
                return this;
            }
            IComponente<T> encontrado = null;

            //recorremos la lista y buscamos en nuestros elementos
            foreach (IComponente<T> elemento in elementos)
            {
                encontrado = elemento.Buscar(_elemento);
                if (!(encontrado is null)) break;
            }
            return encontrado;
        }

        public string Mostrar(int _profundidad) //_profundidad representa q tan profundo esta el componente dentro de la jerarquia 
        {
            //Construimos la cadena con una cantidad de - igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-', _profundidad));

            //Adicionamos la informacion del compuesto
            infoElemento.Append(Nombre + "(SoyCompuesto)" + " Elementos : "+ elementos.Count + "\r\n ");

            //Adicionamos los elementos
            foreach (IComponente<T> elemento in elementos)//con la interfaz IComponente<T> podemos acceder al compuesto o componente ya q los dos implementan a la misma
            {
                infoElemento.Append(elemento.Mostrar(_profundidad + 1));
            }
            return infoElemento.ToString();
        }
        #endregion
    }
}
