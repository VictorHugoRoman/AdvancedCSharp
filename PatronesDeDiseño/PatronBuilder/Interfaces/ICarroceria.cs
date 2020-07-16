using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Interfaces
{
    //Implementamos aqui las clases concretas ya q para este ejercicio no son grandes
    interface ICarroceria
    {
        //Aqui pueden ir los metodos q c requieran
        string Caracteristicas();
    }
    //Creamos las clases de los tipos de Carrocerias concretas
    class CarroceriaBasica : ICarroceria
    {
        #region Implementando ICarroceria
        public string Caracteristicas()
        {
            return "Carroceria de metal";
        }
        #endregion
    }
    class CarroceriaEspecial : ICarroceria
    {
        #region Implementando ICarroceria
        public string Caracteristicas()
        {
            return "Carroceria de fibra de carbono";
        }
        #endregion
    }
}
