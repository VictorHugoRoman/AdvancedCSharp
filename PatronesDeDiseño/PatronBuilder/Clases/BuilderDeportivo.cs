using PatronesDeDiseño.PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    class BuilderDeportivo : IBuilder
    {
        //Primero en este Builder Deportivo tenemos q tener una instancia del producto 
        private Producto auto = new Producto();
        #region Implementando IBuilder
        public void ConstrulleMotor()
        {
            //Creamos una instancia de MotorGrande ya q estamos en el BuilderDeportivo, esto por cuestiones de implementacion ya q estamos construllendo un auto Deportivo
            auto.ColocarMotor(new MotorGrande());
        }
        public void ConstrulleCarroceria()
        {
            //Creamos una instancia de LlantasSuper ya q estamos en el BuilderDeportivo, esto por cuestiones de implementacion ya q estamos construllendo un auto Deportivo
            auto.ColocarLlantas(new LlantasSuper());
        }
        public void ConstrulleLlantas()
        {
            //Creamos una instancia de CarroceriaEspecial ya q estamos en el BuilderDeportivo,esto por cuestiones de implementacion ya q estamos construllendo un auto Deportivo
            auto.ColocarCarroceria(new CarroceriaEspecial());
        }
        #endregion
        //Metodo q no permite sacar el producto q ya a sido construido por el Builder
        public Producto ObtenProducto()
        {
            return auto;
        }
    }
}
