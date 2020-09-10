using PatronesDeDiseño.PatronComando.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComando.Clases
{
    //Esta clase representa al Invoker (UML)
    //Separa al cliente de quien llevará las acciones del Receptor(CAutomovil)
    class CControlRemoto
    {
        //areglo q contendrá los comandos particulares
        private IComando[] comandos = new IComando[4];

        /// <summary>
        /// Crea un array de 4 valores de tipo IComando
        /// </summary>
        /// <param name="pAuto">Cualquier clase o tipo q implemente IComando</param>
        public CControlRemoto(CAutomovil pAuto)
        {
            comandos[0] = new CComandoEncender(pAuto);
            comandos[1] = new CComandoApagar(pAuto);
            comandos[2] = new CComandoPrendeAlarma(pAuto);
            comandos[3] = new CComandoApagarAlarma(pAuto);
        }

        /// <summary>
        /// ejecuta un comando del 0 al 3
        /// </summary>
        /// <param name="pIndice">tipo entero</param>
        public void Boton(int pIndice)
        {
            comandos[pIndice].Ejecutar();
        }
    }
}
