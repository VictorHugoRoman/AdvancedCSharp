using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronVisitante.Interfaces;

namespace PatronesDeDiseño.PatronVisitante.Clases
{
    //ElementoL por la herencia es un elemento(CElemento)
    //Subclase del Elemento
    class CElementoL : CElemento
    {
        public CElementoL(CElemento pHijo, CElemento pSiguiente)
        {
            //Asignamos valor a las variables d la herencia
            siguiente = pSiguiente; //siguiente fue declarado en la clase CElemento
            hijo = pHijo; //hijo fue declarado en la clase CElemento
        }

        //sino hicieramos este override Aceptar cuando se fuera el elementoL c iria como elemento (CElemento) y no como elementoL(CELementoL)
        //es decir se irir como la clase padre
        //con el override y this ya nos mandamos como tipo CElementoL
        public override void Aceptar(IVisitante pVisitante)
        {
            //Nos Mandamos como parametro para q l visitante procese lo necesario
            //base.Aceptar(pVisitante); es lo mismo q abajo
            pVisitante.Visitar(this);
        }
    }
}
