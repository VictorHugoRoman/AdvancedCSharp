using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronVisitante.Interfaces
{
    interface IElemento
    {
        void Aceptar(IVisitante pVisitante);//el paramatro son las clases q esten implementando a IVisitante, es decir, estamos aceptando a un visitante  
    }
}
