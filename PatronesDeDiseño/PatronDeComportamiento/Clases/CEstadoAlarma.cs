using PatronesDeDiseño.PatronDeComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDeComportamiento.Clases
{
    class CEstadoAlarma : IEstado
    {
        //referencia a la caldera, es la variable q nos dará el contexto(uml)
        Caldera miCaldera;

        /// <summary>
        /// Iinicializa la clase Caldera
        /// </summary>
        /// <param name="pCaldera">variable tipo Caldera</param>
        public CEstadoAlarma(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }
        public override string ToString()
        {
            return string.Format("Alarma -> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }

        #region Implementadno IEstado
        public void CortarFuego()
        {
            Console.WriteLine("No se encuentra prendida");
        }
        public void ForzarFuego()
        {
            Console.WriteLine("Aumentra la temperatura");
            miCaldera.Combustible -= 5;
            miCaldera.Temperatura += 10;
        }
        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible con temperatura alta");
        }
        //para el estado de Alarma, implementamos la forma de trabajo
        public void Trabajar()
        {

            Console.WriteLine("ALARMA! Alta Temperatura");
            miCaldera.Temperatura -= 5;
            //verificamos si hay cambio de estado
            if (miCaldera.Temperatura < 9 || miCaldera.Combustible <= 0)
                miCaldera.ActualizaEstado(miCaldera.Espera);
        }
        #endregion
    }
}
