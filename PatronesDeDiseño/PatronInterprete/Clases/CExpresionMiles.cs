using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronInterprete.Clases
{
    //en  CExpresionMiles vamos a tener la interpretacion de cada uno de los metodos de CExpresion
    //Interpreta a la regla Regla gramatical
    class CExpresionMiles : CExpresion
    {
        #region Implementando Clase Abstract CExpresion
        public override string Cinco()
        {
            //sin caracter ya q en este programa no lo implementaremos
            return " ";
        }

        public override string Cuatro()
        {
            //sin caracter ya q en este programa no lo implementaremos
            return " ";
        }

        public override int Factor()
        {
            //El valor encontrado sera multiplicado por 1000 en el interprete
            return 1000;
        }

        public override string Nueve()
        {
            //sin caracter ya q en este programa no lo implementaremos
            return " ";
        }

        public override string Unidad()
        {
            //Regresamos el caracter para que sea utilizado por el interprete
            //para reconcer y evaluar el valor
            return "M";
        }
        #endregion
    }
}
