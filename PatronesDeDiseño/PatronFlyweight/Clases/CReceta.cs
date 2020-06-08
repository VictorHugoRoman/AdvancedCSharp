using PatronesDeDiseño.PatronFlyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronFlyweight.Clases
{
    //este clase sera el FlyWeight concreto, ver UML
    class CReceta : IFlyweight 
    {
        private string nombre;
        private double costo;
        private double venta;
        #region Implementando IFlyweight
        public void CalculaCosto()
        {
            foreach (char letra in nombre)
            {
                costo += (int)letra;//suma el valor del codigo asccii del letra, nos sirve para demostrar la parte extrinseca, porque es un valor q no c comparte es un calculo individual
            }
            venta = costo * 1.30;
        }


        public void ColocaNombre(string _nombre)
        {
            nombre = _nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine("{0} cuesta {1}", nombre, venta);
        }

        public string ObtenNombre()
        {
            return nombre;//nombre de la receta
        }
        #endregion
    }
}
