using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    //No podemos recorrer una clase normal con foreach, tenemos q usar IEnumerable 
    [Serializable()]//usamos Serializable para poder usar new IFormatter().Serialize en en Clone
    public class CTiendaTelevisor : IEnumerable, ICloneable, IComparable
    {
        //Guardamos los televisores de la tienda
        public CTelevisor[] televisors; //IEnumerable tmabien se puede implementar en la misma clase
        public CTelevisor[] televisores; //IEnumerable tmabien se puede implementar en la misma clase
        public string nombreTienda = string.Empty;
        /// <summary>
        /// Contstructor q crea un array de objetos CTelevisor medienta el constructor CTelevisor(_descr, _nombre, _costo)
        /// </summary>
        public CTiendaTelevisor(string _nombreTienda)
        {
            nombreTienda = _nombreTienda;
            //el arreglo contendra 3 televisores
            televisors = new CTelevisor[3];
            televisors[0] = new CTelevisor("Tele LCD", "Tele LG", 1500.00);
            televisors[1] = new CTelevisor("Tele Plasma", "Tele SAMSUNG", 1800.50);
            televisors[2] = new CTelevisor("Tele LED", "Tele Hisense", 2500.00);
            televisores = new CTelevisor[3];
            televisores[0] = new CTelevisor("Tele LCD 2", "Tele LG", 1500.00);
            televisores[1] = new CTelevisor("Tele Plasma 2", "Tele SAMSUNG", 1800.50);
            televisores[2] = new CTelevisor("Tele LED 2", "Tele Hisense", 2500.00);
        }
        #region Implementando Interfaz IEnumerable
        //el metodo regresa un objeto interfaz IEnumerator, dandole el comportamiento de un iterador
        public IEnumerator GetEnumerator()
        {
            return televisors.GetEnumerator();
        }
        /*
         * Como esta definido la interfaz IEnumerator
         * la podemos implementar si sabemos como funciona un iterator
        public interface IEnumerator
        {
            bool MoveNext();//permite al iterador moverse al sig elemento
            object Current { get; }//obtenemos el elemento actual
            void Reset();//se encarga de colocar la posicion actual antes del primer elemento listado, para permitir volver a recorrer la coleccion correspondioente
        }
         */
        #endregion
        #region Implementando interfaz ICloneable
        public object Clone()
        {
            return Utiles.Copia(this);//usamos el metodo Utiles.Copia q copia los datos en memoria
            //este metodo es bastante util para clses con muchas propiedades
        }
        #endregion
        #region Implementando interfaz IEcomparable
        public int CompareTo(object obj)
        {
            if (!(obj is CTiendaTelevisor))
                throw new ArgumentException("El objeto no es de tipo CTelevisor");
            CTiendaTelevisor temp = (CTiendaTelevisor)obj;            
            return nombreTienda.CompareTo(temp.nombreTienda);
            //var _televisores = this.televisores;
            //var _televisors = this.televisors;
            //Array.Sort(_televisores);
            //Array.Sort(_televisors);
        }
        #endregion
    }
}