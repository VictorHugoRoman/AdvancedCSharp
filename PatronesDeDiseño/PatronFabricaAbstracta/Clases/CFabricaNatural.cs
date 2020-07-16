using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    //Clase tipo fabrica
    class CFabricaNatural : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        public string variableNoInterfaz = "";
        #region Implementando IFabrica
        public IProductoLeche ObtenProductoLeche { get { return leche; } }
        public IProductoSaborizante ObtenSabor { get { return sabor; } }
        /// <summary>
        /// Crea dos tipos de leche, de coco y de almendras
        /// dandole al usuario la opcion de elegir uno
        /// </summary>
        public void CrearProductos()
        {
            //verde la para Fabrica Natural
            Console.ForegroundColor = ConsoleColor.Green;
            string seleccion;
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendras    2) Coco");
            seleccion = Console.ReadLine();

            if (seleccion == "1")
                leche = new CLecheAlmendras();
            else
                leche = new CLecheCoco();
            leche.Producir();
            Console.WriteLine("Ahore extraemos el sabor");
            //Pudimo haber agregado otras combinaciones para el sabor
            sabor = new CVainillaNatural();
            sabor.Obtener();
        }
        #endregion
    }
}
