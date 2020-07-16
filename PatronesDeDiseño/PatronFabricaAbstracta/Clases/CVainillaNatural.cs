using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Producto q pertenecen a la interfaz  IProductoSaborizante
    //Esta clase sera un producto concreto
    class CVainillaNatural : IProductoSaborizante
    {
        #region Implementando IProductoLeche
        public string Informacion()
        {
            return "Extracto Natural de Vainilla";
        }
        public void Obtener()
        {
            Console.WriteLine("Se extrae de las vainas");
        }
        #endregion
    }
}
