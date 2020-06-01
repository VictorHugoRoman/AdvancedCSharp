using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Interfaces;
namespace CsharpAvanzadoBook.Clases
{
    [Serializable()]//usamos Serializable para poder usar new IFormatter().Serialize en en Clone
    public class CTelevisor : IProducto, IComparable, IEnumerable
    {
        public double costo { get; set; }
        public double impuesto { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
        #region Metodos propios
        public CTelevisor()
        {
            costo = 400D;
            nombre = "televisor";
            descripcion = "television en pantalla plana";
        }
        public CTelevisor(string _descr, string _nombre, double _costo)
        {
            costo = _costo;
            nombre = _nombre;
            descripcion = _descr;
        }
        public void ColocarCosto(double nCosto)
        {
            //asginmos nuevo costo
            costo = nCosto;
        }
        #endregion 
        #region metodos a implementar de la interfaz IProducto
        public void calculaImpuesto(double imp)
        {
            //calculmaos el impuesto
            impuesto = costo * imp;
        }

        public void MuestraInformacion()
        {
            //mostramos la informacion necesaria
            Console.WriteLine("-----Producto Televisor");
            Console.WriteLine(descripcion);
            Console.WriteLine("Costo {0}, impuesto {1} ", costo, impuesto);
        }
        #endregion
        #region Implementacion IComparable
        /// <summary>
        /// Compara el campo costo
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (!(obj is CTelevisor))
                throw new ArgumentException("El objeto no es de tipo CTelevisor");
            CTelevisor temp = obj as CTelevisor;
            //hacemos las comparaciones con el campo costo implementando las reglas de CompareTo
            //aqui podemos meter mas reglas para compara el objeto
            if (costo > temp.costo) return 1;
            else if (costo < temp.costo) return -1;
            else return 0;
            //return nombre.CompareTo(temp.nombre);//comparamos por el CompareTo que implemente la clase string en este caso nombbre, pueden ser distintas reglas de validacion para validar si el objeto es igual
        }
        /*
        IComparable tiene el unico metodo a implementar
        public interface IComparable
        {
              //el metodo recibe un objecto por ende hay q hacer un typeCast internamenteen la clase
          int CompareTo(object o);// lo ejecuta la instancia q deseamos comparar, retorna un entero, indicando 
              //si la instancia y el objeto son iguales, o si alguno es mayor q el otro
              //si los 2 objetos son iguales return 0, 
              //si la instancia es menor o viene anterior al objeto por comparar, return valor < a 0
              //si la instancia es mayor o es psoterior al objeto por compara, return valor > a 0
        */
        #endregion
        #region Implementando la interfaz IEnumerable
        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion

    }
}
