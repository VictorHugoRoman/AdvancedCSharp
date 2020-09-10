using PatronesDeDiseño.PatronVisitante.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronVisitante.Clases
{
    //arbol generico
    //Elemento raiz de la estructura
    class CElemento : IElemento
    {
        //variables de interfaz de tipo elemento
        public CElemento siguiente; //para la referencia ql sig. q seria el hermano
        public CElemento hijo; //referencia al hijo

        //Datos del elemento, aqui colocamos la informacion q ocupamo para nuestra aplicacion
        private double costo;
        public double Costo { get => costo; set => costo = value; }
        private string nombre;
        public string Nombre { get => nombre; set => nombre = value; }

        public CElemento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elemento creado");
        }
        public CElemento(double pCosto, string pNombre, CElemento pSiguiente)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento creado con siguiente {0}-> ${1}", pNombre, pCosto);
            siguiente = pSiguiente; //guardamos quien sera el siguiente para que quede la conexion 
            costo = pCosto;
            nombre = pNombre;
        }
        #region Implementando IElemento
        //Aceptamos al vvisitante
        //hacemos virtual el metodo porque el ElementoL (CElementoL) descendera de Elemento(CElemento) y si es necesario q elementoL tenga una version
        //diferente de Aceptar(metodo) haremos un override al metodo por ello hacemos el metodo virtual
        public virtual void Aceptar(IVisitante pVisitante)//estamos recibiendo a alguien q esté implementando a IVisitante
        {
            //Nos mandamos como parametro para q l visitante procese lo necesario,
            //estamos haciendo una abstraccion para q l exterior pueda trabajar sobre nosotros
            pVisitante.Visitar(this); //invocamos al metodo visitar del visitante y nos mandamos(this)  para q l visitante pueda visitarnos
        }
        #endregion
    }
}
