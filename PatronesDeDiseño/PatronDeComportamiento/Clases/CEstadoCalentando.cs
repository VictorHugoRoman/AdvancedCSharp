using PatronesDeDiseño.PatronDeComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDeComportamiento.Clases
{
    class CEstadoCalentando : IEstado
    {
        //referencia a la caldera, es la variable q nos dará el contexto(uml)
        Caldera miCaldera;

        /// <summary>
        /// Iinicializa la clase Caldera
        /// </summary>
        /// <param name="pCaldera">variable tipo Caldera</param>
        public CEstadoCalentando(Caldera pCaldera)
        {
            miCaldera = pCaldera;
            
        }
        public override string ToString()
        {
            return string.Format("Calentando -> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }

        #region Implementadno IEstado
        public void CortarFuego()
        {
            Console.WriteLine("Cortamos Fuego");
            miCaldera.ActualizaEstado(miCaldera.Espera);
        }
        public void ForzarFuego()
        {
            Console.WriteLine("El fuego ya está prendido");
        }
        public void PonerCombustible()
        {
            Console.WriteLine("No se puede colocar combustible cuando esta prendida");
        }
        //para el estado de calentando, implementamos la forma de trabajo
        public void Trabajar()
        {
            if (miCaldera.Combustible > 0)
            {
                Console.WriteLine("Estamos calentando");
                miCaldera.Combustible -= 3;
                miCaldera.Temperatura += 10;
            }
            //verificamos si hay cambio de estado
            if (miCaldera.Temperatura > 100)
                miCaldera.ActualizaEstado(miCaldera.Alarma);
            else if (miCaldera.Temperatura > 80)
                miCaldera.ActualizaEstado(miCaldera.Espera);

            if (miCaldera.Temperatura <= 0)
                miCaldera.ActualizaEstado(miCaldera.Espera);
        }
        #endregion
    }
}
