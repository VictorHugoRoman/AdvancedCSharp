using PatronesDeDiseño.PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    //IMplementa estas la clases
    class MotorAvanzado
    {
        class MotorV8FullInjection: IMotor
        {
            #region Implementando IMotor
            public string Especificaciones()
            {
                return "Motor de 8 cilindros";
            }
            #endregion
        }
        #region Implementando IMotor
        public string Especificaciones()
        {
            return "Motor de 8 cilindros";
        }
        #endregion
    }
}
