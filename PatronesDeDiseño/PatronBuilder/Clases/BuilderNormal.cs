using PatronesDeDiseño.PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    //Constructor Normalm 
    class BuilderNormal : IBuilder
    {
        //Primero en este Builder Normal tenemos q tener una instancia del producto 
        private Producto auto = new Producto();
        #region Implementando IBuilder
        public void ConstrulleMotor()
        {
            //Creamos una instancia del motor basico ya q estamos en el BuilderNormal, esto por cuestiones de implementacion ya q estamos construllendo un auto normal
            auto.ColocarMotor(new MotorBasico());
        }
        public void ConstrulleCarroceria()
        {
            //Creamos una instancia de Llantas12 ya q estamos en el BuilderNormal, esto por cuestiones de implementacion ya q estamos construllendo un auto normal
            auto.ColocarLlantas(new Llantas12());
        }
        public void ConstrulleLlantas()
        {
            //Creamos una instancia de CarroceriaBasica ya q estamos en el BuilderNormal,esto por cuestiones de implementacion ya q estamos construllendo un auto normal
            auto.ColocarCarroceria(new CarroceriaBasica());
        }
        #endregion
        //Metodo q no permite sacar el producto q ya a sido construido por el Builder
        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
