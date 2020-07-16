using PatronesDeDiseño.PatronMetodoFabirca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMetodoFabirca.Clases
{
    class CAvion : IVehiculo
    {
        #region Implementando IVehiculo
        public void Acelerar()
        {
            Console.WriteLine("Sigue todo el procedimiento");
        }

        public void Encender()
        {
            Console.WriteLine("Empuja el acelerador");
        }

        public void Frenar()
        {
            Console.WriteLine("jala el acelerador");
        }

        public void Girar()
        {
            Console.WriteLine("Mueve el timon de cola");
        }
        #endregion
    }
}
