using PatronesDeDiseño.PatronCadenaResponsabilidad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronCadenaResponsabilidad.Clases
{
    class CVendedor : IHandler
    {
        //nos sirve para conectarnos con el siguiente objeto adentro de la cadena de responsabilidad
        private IHandler siguiente = null;

        //En el ctor pasamos como parametro al siguiente q sera en la cadena de responsabilidad 
        //con IHandler podemos recibir a cualquier objeto q la implemente 
        public CVendedor(IHandler pSiguiente)
        {
            siguiente = pSiguiente;
        }
        
        #region Implementando IHandler
        /// <summary>
        /// en base a la cantidad y precio decide si puede llevar a cabo el calculo sino llama a su responsable en la cadena
        /// </summary>
        /// <param name="pCantidad">Cantidad de Articulos</param>
        /// <param name="pPrecio">Precio de Articulos</param>
        /// <returns></returns>
        public double CalculaPrecioFinal(int pCantidad, double pPrecio)
        {
            Console.WriteLine("Con el vendedor");

            //Si son mas de 20 articulos y mas de 20000 en ventas
            //pasa al jefe de piso
            double total = pCantidad * pPrecio;

            if (pCantidad > 20 || total > 20000)
                total = siguiente.CalculaPrecioFinal(pCantidad, pPrecio);
            else if(pCantidad > 10) //si son mas de 10 damos un 5% de descuento
                total *= 0.95;

            return total;
        }
        #endregion
    }
}
