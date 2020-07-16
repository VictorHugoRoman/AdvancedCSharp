using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Producto q pertenecen a la interfaz  IProductoSaborizante
    //Esta clase la vamos a utilizar para la fabrica q crea la familia de productos quimicos
    class CSaborChocolate : IProductoSaborizante
    {
        #region Implementando IProductoLeche
        public string Informacion()
        {
            return "Sabor a chocolate";
        }
        public void Obtener()
        {
            Console.WriteLine("Se produce C7H8N402");
        }
        #endregion
    }
}
