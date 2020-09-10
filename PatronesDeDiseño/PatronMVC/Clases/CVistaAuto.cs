using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMVC.Clases
{
    class CVistaAuto : IVistaAuto
    {
        #region Implementando IVistaAuto
        public void DespliegaAuto(CMAuto pAuto)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("El auto");
            Console.WriteLine("{0} {1}, ${2}", pAuto.Nombre, pAuto.Modelo, pAuto.Costo);
        }

        public int SolicitaEntrada()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.- Cambiar Costo    2.- Cambiar Modelo, 3.-Salir");
            Console.WriteLine("Dame tu Opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
        #endregion
    }
}
