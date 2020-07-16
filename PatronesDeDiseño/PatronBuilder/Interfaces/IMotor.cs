using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Interfaces
{
    //Implementamos aqui las clases concretas ya q para este ejercicio no son grandes
    interface IMotor
    {
        //Aqui pueden ir los metodos q c requieran
        string Especificaciones();
    }
    
    //Creamos las clases de los tipos de llantas concretas

    class MotorBasico : IMotor
    {
        #region Implementando IMotor
        public string Especificaciones()
        {
            return "Motor de 4 cilindros";
        }
        #endregion
    }
    class MotorGrande: IMotor
    {
        #region Implementando IMotor
        public string Especificaciones()
        {
            return "Motor de 8 cilindros";
        }
        #endregion
    }
}
