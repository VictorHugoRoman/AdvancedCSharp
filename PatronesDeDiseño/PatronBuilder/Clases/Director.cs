using PatronesDeDiseño.PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    //El director c encarga de darle la secuencia al constructor para q vaya creando aquello q s necesario
    class Director
    {
        //Recibe como parametro algun objeto q implemente IBuilder, es decir, recibirá como parametro a algun constructor en particular
        public void Construye(IBuilder pConstructor)
        {
            //Aqui el Director indica los pasos para hacer la construccion
            //pero el constructor s l q c encarga de construir segun
            //esta especificacion

            pConstructor.ConstrulleMotor();
            pConstructor.ConstrulleCarroceria();
            pConstructor.ConstrulleLlantas();
        }
    }
}
