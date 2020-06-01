using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAvanzadoBook.Interfaces;

namespace CsharpAvanzadoBook.Clases
{
    public class CAuto : IAutomovil, ICloneable
    {
        private double costo;
        private double tenencia;
        private string modelo;

        public CAuto(string _modelo, double _costo)
        {
            this.costo = _costo;
            this.modelo = _modelo;
        }
        public double Costo { get { return costo; } set { costo = value; } }
        public double Tenencia { get { return tenencia; } set { tenencia = value; } }

        #region Implementacion interfaz IAutomovil
        public void CalculaTenencia(double imp)
        {
            tenencia = 5000.0 + costo * imp;
        }

        public void MuestraInformacion()
        {
            Console.WriteLine("Tu Automovil {0}", modelo);
            Console.WriteLine("Costo {0}, con una tenencia de {1}", costo, tenencia);
            Console.WriteLine("Total {0}", costo + tenencia);
            Console.WriteLine("--------");
        }
        #endregion
        #region Implementacion ICloneable
        public object Clone()
        {
            CAuto temp = new CAuto(modelo, costo);//creamos un objeto con los valores actuales modelo y costo
            temp.Tenencia = tenencia;//al objeto creado le asignamos la tenencia actual, lo hacemos asi porque no construi un ctor q asigne el valor
            return temp;
        }
        #endregion
    }
}
