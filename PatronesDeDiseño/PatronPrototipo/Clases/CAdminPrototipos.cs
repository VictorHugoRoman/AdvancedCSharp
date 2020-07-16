using PatronesDeDiseño.PatronPrototipo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronPrototipo.Clases
{
    class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipos()
        {
            //Adicionamos los objetos prototips con los valores iniciales que nos interesan
            CPersona persona = new CPersona("Ciudadano", 18);
            prototipos.Add("Persona", persona);
            //Instanciamos el rendimiento costoso para guardarlo en el administrador con el estado inicial 
            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);
        }
        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }
        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
