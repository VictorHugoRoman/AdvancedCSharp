using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    //en  CExpresionDecenas vamos a tener la interpretacion de cada uno de los metodos de CExpresion
    //Interpreta a la regla Regla gramatical
    class CExpresionDecenas : CExpresion
    {
        #region Implementando Clase Abstract CExpresion
        public override string Cinco()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "L";
        }

        public override string Cuatro()
        {
            return "XL";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 10 en el interprete
            return 10;
        }

        public override string Nueve()
        {
            return "XC";
        }

        public override string Unidad()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "X";
        }
        #endregion
    }
}
