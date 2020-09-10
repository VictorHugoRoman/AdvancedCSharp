using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    //en  CExpresionUnidad vamos a tener la interpretacion de cada uno de los metodos de CExpresion
    //Interpreta a la regla Regla gramatical
    class CExpresionUnidad : CExpresion
    {
        #region Implementando Clase Abstract CExpresion
        public override string Cinco()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "V";
        }

        public override string Cuatro()
        {
            return "IV";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 1 en el interprete
            return 1;
        }

        public override string Nueve()
        {
            return "IX";
        }

        public override string Unidad()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "I";
        }
        #endregion
    }
}
