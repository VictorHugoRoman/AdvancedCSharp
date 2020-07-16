using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Clase tipo fabrica
    class CFabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        public string varPruebaNoInterfaz="";
        #region Implementando IFabrica
        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }
        public void CrearProductos()
        {
            //aqui podemos meter logica para la validacion de los productos por familia como ejemplo practico
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new CLecheVaca();
            sabor = new CSaborChocolate();
        }
        
        #endregion
    }
}
