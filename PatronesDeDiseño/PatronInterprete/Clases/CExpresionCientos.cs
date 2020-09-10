using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    //en  CExpresionCientos vamos a tener la interpretacion de cada uno de los metodos de CExpresion
    //Interpreta a la regla Regla gramatical
    class CExpresionCientos : CExpresion
    {
        #region Implementando Clase Abstract CExpresion
        public override string Cinco()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "D";
        }

        public override string Cuatro()
        {
            return "CD";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 100 en el interprete
            return 100;
        }

        public override string Nueve()
        {
            return "CM";
        }

        public override string Unidad()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "C";
        }
        #endregion
    }
}
