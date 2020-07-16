using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Interfaces
{
    //esta inerfaz sería la parte Interfaz IFabricaAbstracta
    interface IFabrica
    {
        void CrearProductos();
        IProductoLeche ObtenProductoLeche { get; }
        IProductoSaborizante ObtenSabor { get; }
        //podemos meter las acciones necesarias dependiendo del articulo en particular q deseamos crear
    }
}
