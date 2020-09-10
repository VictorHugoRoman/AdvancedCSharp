using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronSingleton.Clases
{
    //Clase q c encargará de tener aquellos q nosotros quisieramos interpretar
    class CContexto
    {
        private string expresion;
        private int valor;
        public int Valor { get => valor; set => valor = value; }
        public string Expresion { get => expresion; set => expresion = value; }

        //Colocamos la expresion a interpretar
        public CContexto(string pExpresion)
        {
            Expresion = pExpresion;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Se evaluará {0}", expresion);
        }

    }
}
