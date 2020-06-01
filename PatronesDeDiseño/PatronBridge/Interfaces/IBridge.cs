using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBridge.Interfaces
{
    //Esta interfaz es la q las implementaciones deben de mostrar, es decir, muestra las implementaciones q c tienen q llevar a cabo
    interface IBridge //En el diagrama UML es la interface IBridge
    {
        void MostrarTotales(Dictionary<string, double> _productos);
        void ListarProductos(Dictionary<string, double> _productos);
    }
}
