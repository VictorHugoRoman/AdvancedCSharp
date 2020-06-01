using PatronesDeDiseño.PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDecorador.Clases
{
    //Esta clase representa al componente del patron y db d implementar IComponente para poder llevar a cabo la decoracion
    class CAuto : IComponente
    {
        private string modelo, caracteristicas;
        private double costo;
        public CAuto(string pModelo, string pCaracter, double pCosto)
        {
            modelo = pModelo;
            caracteristicas = pCaracter;
            costo = pCosto;
        }
        public void Puertas(bool pEstado)
        {
            if (pEstado) Console.WriteLine("Puertas Cerradas");
            else Console.WriteLine("Puertas Abiertas");
        }
        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }
        #region Implementando IComponente
        public double Costo()
        {
            return costo;
        }
        public string Funciona()
        {
            return "Encendi el motor";
        }
        #endregion
    }
}
