using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronIterador.Clases
{
    class CContenedora : IEnumerable
    {
        //simulamos la coleccion de informacion, pero podria ser una lista ligada, un arbol, un diccionario 
        //o culaquier cosa q ocupemos
        private int[] valores = new int[10];

        public CContenedora()
        {
            for (int n = 0; n < 10; n++)
                valores[n] = n*n;
        }
        #region Implementando IEnumerable
        //El enumerador s l q c encarga d dar l sig elemento, d tnr las reglas para recorrer la coleccion o estructura de datos
        //Implementamos el GetEnumerator necesario para IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            //Instanciamos el enumardor y lo regresamos
            return (new ContenedorEnum(valores));//CContenedorEnum s l enumerador propio de la clase contenedora (CContenedora)
        }
        #endregion        
    }
    //hacemos un enumerador de IEnumerator
    class ContenedorEnum : IEnumerator
    {
        public int[] arreglo;
        private int posicion = -1;//esta variable nos indica en q posicion estamos del arreglo en particular

        //recibimos el arreglo con el cual trabajeremos
        public ContenedorEnum(int[] pArreglo)
        {
            arreglo = pArreglo;
        }

        #region Implementando IEnumerator
        //Metodo para movernos sobre los elementos
        public bool MoveNext()
        {
            posicion++;
            //Aqui podemos meter la regla de acuerdo a nuestra aplicacion en la estructura de datos o coleccion
            if (posicion < arreglo.Length)
                return true;
            else
                return false;
        }

        //Nos regresa al inicio de la coleccion
        public void Reset()
        {
            posicion = -1;//- para q n l MoveNext() nos coloque en la posicion 0 q s la posicion valida adentro del arreglo
        }

        //Nos regresa el elemento actual en la posicion que nos da MoveNext()
        public object Current
        {
            get
            {
                return arreglo[posicion];
            }
        }
        #endregion
    }
}
