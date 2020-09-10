using PatronesDeDiseño.PatronDeComportamiento.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDeComportamiento.Clases
{
    class CEstadoEspera : IEstado
    {
        //referencia a la caldera, es la variable q nos dará el contexto(uml)
        Caldera miCaldera;

        /// <summary>
        /// Iinicializa la clase Caldera
        /// </summary>
        /// <param name="pCaldera">variable tipo Caldera</param>
        public CEstadoEspera(Caldera pCaldera)
        {
            miCaldera = pCaldera;
        }
        public override string ToString()
        {
            return string.Format("Espera -> temp {0}, comb {1}", miCaldera.Temperatura, miCaldera.Combustible);
        }

        #region Implementadno IEstado
        public void CortarFuego()
        {
            Console.WriteLine("No hay Fuego prendido");
        }
        public void ForzarFuego()
        {
            if (miCaldera.Combustible > 0)
            {
                Console.WriteLine("Se ha prendido el fuego de manera forzada");
                miCaldera.Combustible -= 10;
                miCaldera.Temperatura += 50;
                if (miCaldera.Temperatura > 100)
                    miCaldera.ActualizaEstado(miCaldera.Alarma);
            }
        }
        public void PonerCombustible()
        {
            Console.WriteLine("Colocando Combustible");
            miCaldera.Combustible += 28;
        }
        //para el estado de Espera, implementamos la forma de trabajo
        public void Trabajar()
        {
            miCaldera.Temperatura -= 5;
            //verificamos si hay cambio de estado
            if (miCaldera.Temperatura < 60 && miCaldera.Combustible > 0)
                miCaldera.ActualizaEstado(miCaldera.Calentando);
        }
        #endregion
    }
}
