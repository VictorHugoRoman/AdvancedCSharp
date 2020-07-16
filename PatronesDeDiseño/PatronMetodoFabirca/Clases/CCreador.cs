using PatronesDeDiseño.PatronMetodoFabirca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMetodoFabirca.Clases
{
    //Aqui Implementamos la fabrica
    class CCreador
    {
        //Se hace static solo para no instanciar CCreador, pero si deseamos guaradar o inicializar
        //algun estado podemos instanciar esta clase
        //no necesariamente MetodoFabrica tiene q ser static
        public static IVehiculo MetodoFabrica(int pDinero)
        {
            IVehiculo temp = null;

            //seleccionamos el tipo de instancia segun nuestras reglas
            if (pDinero > 10000000) temp = new CAvion();
            else if (pDinero > 200000) temp = new CAuto();
            else temp = new CBici();
            return temp;
        }
    }
}
