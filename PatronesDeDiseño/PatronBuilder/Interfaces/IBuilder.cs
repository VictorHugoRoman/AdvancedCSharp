using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Interfaces
{
    //Interfaz del Builder es del constructor como tal
    interface IBuilder
    {
        void ConstrulleMotor();
        void ConstrulleCarroceria();
        void ConstrulleLlantas();
    }
}
