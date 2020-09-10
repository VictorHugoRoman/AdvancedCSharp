using PatronesDeDiseño.PatronSingleton.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    abstract class CExpresion
    {
        public void Interpretar(CContexto pContexto)
        {
            //Si ya no hay elementos que interpretar salimos
            if (pContexto.Expresion.Length == 0) return;

            //Verificamos si empieza con nueve
            if (pContexto.Expresion.StartsWith(Nueve()))
            {
                //Agregamos el nuevo por la posicion donde esté 1,10,100
                pContexto.Valor += (9 * Factor());

                //Eliminamos dos caracteres IX, XC,CM
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }
            //Verificamos si empieza con Cuatro
            else if (pContexto.Expresion.StartsWith(Cuatro()))
            {
                //Agregamos el nuevo por la posicion donde esté 1,10,100
                pContexto.Valor += (4 * Factor());

                //Eliminamos dos caracteres
                pContexto.Expresion = pContexto.Expresion.Substring(2);
            }
            //Verificamos si empieza con Cinco
            else if (pContexto.Expresion.StartsWith(Cinco()))
            {
                //Agregamos el nuevo por la posicion donde esté 1,10,100
                pContexto.Valor += (5 * Factor());

                //Eliminamos dos caracteres
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
            //Recorremos las unidades enconctradas I, X, C
            while (pContexto.Expresion.StartsWith(Unidad()))
            {
                pContexto.Valor += (1 * Factor());
                pContexto.Expresion = pContexto.Expresion.Substring(1);
            }
        }

        //Metodos abastractos para encontrar el caracter y factor segun la posicion.
        //Seran interpretados por aquellas hijas de CExpresion 
        public abstract string Unidad();
        public abstract string Cuatro();
        public abstract string Cinco();
        public abstract string Nueve();
        public abstract int Factor();
    }
}
