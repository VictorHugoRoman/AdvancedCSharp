using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Producto q pertenecen a la interfaz IProductoLeche
    class CLecheAlmendras : IProductoLeche
    {
        #region Implementando IProductoLeche
        public string ObtenDatos()
        {
            return "Leche organica de almendra, 250 ml";
        }

        public void Producir()
        {
            Console.WriteLine("Procesar las almendras");
        }
        #endregion
    }
}
