using PatronesDeDiseño.PatronMetodoFabirca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMetodoFabirca.Clases
{
    class CBici : IVehiculo
    {
        #region Implementando IVehiculo
        public void Acelerar()
        {
            Console.WriteLine("Las Bicis no ocupan encendido");
        }

        public void Encender()
        {
            Console.WriteLine("Pedalea fuerte para acelerar");
        }

        public void Frenar()
        {
            Console.WriteLine("presiona el freno trasero primero");
        }

        public void Girar()
        {
            Console.WriteLine("Usa el manubrio ");
        }
        #endregion
    }
}
