using PatronesDeDiseño.PatronComando.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComando.Clases
{
    class CComandoPrendeAlarma : IComando
    {
        CAutomovil auto;

        /// <summary>
        /// Inicializa una variable de tipo CAutomovil
        /// </summary>
        /// <param name="pAuto">tipo CAutomovil</param>
        public CComandoPrendeAlarma(CAutomovil pAuto)
        {
            auto = pAuto;
        }

        #region Implementando IComando
        public void Ejecutar()
        {
            //Invocamos la accion correspondiente al auto
            auto.ColocarAlarma();
        }
        #endregion
    }
}
