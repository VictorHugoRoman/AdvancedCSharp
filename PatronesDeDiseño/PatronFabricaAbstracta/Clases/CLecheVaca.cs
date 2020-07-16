using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Producto q pertenecen a la interfaz IProductoLeche
    class CLecheVaca : IProductoLeche
    {
        #region Implementando IProductoLeche
        public string ObtenDatos()
        {
            return "Leche de vaca, 250 ml";
        }

        public void Producir()
        {
            Console.WriteLine("Ordenar vaca en la granja");
        }
        #endregion
    }
}
