using PatronesDeDiseño.PatronPrototipo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronPrototipo.Clases
{
    class CPersona : IPrototipo
    {
        //Caracteristicas de esta clase
        private string nombre;
        private int edad = 1;

        //propiedades
        public string Nombre{ get => nombre; set => nombre = value; }

        public CPersona(string pNombre, int pEdad)
        {
            nombre = pNombre;
            edad = pEdad;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", nombre, edad);
        }

        #region Implementando IPrototipo
        //Clonamos el estado del objeto no tanto por la rendimiento que lleva instanciar un nuevo objeto
        public object Clonar()
        {
            CPersona clon = new CPersona(nombre, edad);

            return clon;
        }
        #endregion

    }
}
