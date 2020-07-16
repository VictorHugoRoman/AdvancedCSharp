using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Interfaces
{
    interface ILlantas
    {
        //Aqui pueden ir los metodos q c requieran
        string Informacion();
    }
    //Creamos las clases de los tipos de llantas concretas
    class Llantas12 : ILlantas
    {
        #region Implementando ILlantas
        public string Informacion()
        {
            return "Lantas de 14 pulgadas";
        }
        #endregion
    }
    class LlantasSuper: ILlantas
    {
        #region Implementando ILlantas
        public string Informacion()
        { 
          return "Lantas de 18 pulgadas, rines aluminio";
        }
        #endregion
    }
}
