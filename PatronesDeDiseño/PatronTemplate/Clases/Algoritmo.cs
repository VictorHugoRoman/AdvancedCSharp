using PatronesDeDiseño.PatronTemplate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronTemplate.Clases
{
    //representa al Algoritmo en el UML, tendra el metodo Template
    //donde iran los pasos aquellos q permanece constantes y aquellos q cambian, para los q cambian se ocupa variables de referencia
    //IPrimitiva en este caso esta tendra como metodo o accion una o varias operaciones dependiendo d lo q necesitemos
    class Algoritmo
    {
        //Costo total de la produccion de los juguetes q queremos hacer
        //Este metodo llevara los pasos del algoritmo para crear el juguete
        public double MetodoTemplate(IPrimitiva pTipo, int pCantidad)
        {
            double total = 0;
            //crear juguete
            total += CrearJuguete(pCantidad); //metodo invariable o constante, siempre hara exactamente los mismo ya q pertence al agortimo

            //Lo decoramos
            total += pTipo.Decorar(pCantidad); //metodos q pueden variar, porque son metodos de las clasesN q implementan IPrimitiva

            //Verificamos la calidad
            Calidad(); //metodo invariable o constante, siempre hara exactamente los mismo ya q pertence al agortimo

            //Empacamos
            total += pTipo.Empacar(pCantidad); //metodos q pueden variar, porque son metodos de las clasesN q implementan IPrimitiva

            return total;
        }

        //Metodos de la clase algoritmo, son aquellos q no varian q son iguales q siempre se llevan a cabo de la misma
        //forma en el algoritmo por ello pertenecen a esta clase

        //Este metodo será invariable o constantes, es decir, siempre hará los mismo sin importar la calidad del juguete

        //En este caso simplemente Crea el juguete ya la calidad depede de CBarato y CNormal
        private double CrearJuguete(int pCantidad)
        {
            Console.WriteLine("Estamos creando {0} juguetes", pCantidad);
            return 16.50 * pCantidad;
        }
        //Simplemente manda el msg de que paso la calidad, pudimos haber metido validaciones respecto a CBarato y CNormal
        //ya q debe ser fija o constante
        private void Calidad()
        {
            Console.WriteLine("Pasa control de calidad");
        }
    }
}
