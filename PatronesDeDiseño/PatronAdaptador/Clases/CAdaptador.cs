using PatronesDeDiseño.PatronAdaptador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronAdaptador.Clases
{
    //Esta clase es el adaptador, usa la interfaz ITarget la cual es conocida por el cliente
    //el adaptador comunica al cliente con la clase adaptada
    class CAdaptador : ITarget
    {
        public CAdaptador()
        {

        }
        //clase para adaptar
        CCalculadoraArray adaptado = new CCalculadoraArray();

        #region Implementando ITarget
        //aqui hacemos la adaptacion de una operacion
        public int Sumar(int pA, int pB)
        {
            double r = 0;
            //creamos el array q necesita el adaptado
            //adaptamos los datos q c envian
            int[] operadores = { pA, pB };

            //realizamos la operacion en el adaptado
            r = adaptado.suma(operadores);

            return (int)r;
        }
        #endregion
    }
}
