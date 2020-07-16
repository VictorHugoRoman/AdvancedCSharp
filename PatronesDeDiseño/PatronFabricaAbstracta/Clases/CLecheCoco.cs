using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Producto q pertenecen a la interfaz IProductoLeche
    class CLecheCoco : IProductoLeche
    {
        #region Implementando IProductoLeche
        public string ObtenDatos()
        {
            return "Leche de coco natural, 250 ml";
        }

        public void Producir()
        {
            Console.WriteLine("Buscamos los cocos");
        }
        #endregion
    }
}
