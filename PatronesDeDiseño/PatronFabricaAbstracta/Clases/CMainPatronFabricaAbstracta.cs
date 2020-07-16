using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronFabricaAbstracta.Clases;
using PatronesDeDiseño.PatronFabricaAbstracta.Interfaces;

namespace PatronesDeDiseño.PatronFabricaAbstracta.Clases
{
    class CMainPatronFabricaAbstracta
    {
        public static void _Main()
        {
            //Iniciamos con Fabrica Quimica
            IFabrica miFabrica = new CFabricaQuimica();//como CFabricaQuimica implementa IFabrica  podemos crear una referencia de esta
            Console.WriteLine("--Fabrica Quimica--");
            //en CrearProductos() q pertenece a la interfazs IFabrica pero se implementa  
            //en CFabricaQuimica se instancian las clases CLecheVaca, CSaborChocolate 
            //y estas clases implementan las interfaces IProductoLeche e IProductoSaborizante
            //es decir se crean productos por familia 
            miFabrica.CrearProductos();

            //Como ya creamos los productos leche y saborizante en el metodo CrearProductos() de la interfaz IFabrica implementado en CFabricaQuimica
            //vamos a obtenerlos
            IProductoLeche miLeche = miFabrica.ObtenProductoLeche; //miLeche es CLecheVaca q implementa IProductoLeche 
            IProductoSaborizante miSabor = miFabrica.ObtenSabor; //miSabor es CSaborChocolate q implementa IProductoSaborizante

            //como miLeche se obtiene d la propiedada ObtenProductoLeche de la interfaz IFabrica implementada en CFabricaQuimica
            //q lo q hace es instanciar CLecheVaca y aqui se implementa el metodo Producir() q pertenece a la interfaz IProductoLeche
            miLeche.Producir();

            //como miSabor se obtiene d la propiedadad ObtenSabor de la interfaz IFabrica implementada en CFabricaQuimica
            //q lo q hace es instanciar CSaborChocolate y aqui se implementa el metodo Obtener() q pertenece a la interfaz IProductoSaborizante
            miSabor.Obtener();

            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());
            Console.WriteLine("-------");

            //Ahora instanciamos a fabrica Natural
            miFabrica = new CFabricaNatural();//como CFabricaNatural implementa IFabrica  podemos crear una referencia de esta
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--Fabrica Natural--");

            //en CrearProductos() q pertenece a la interfazs IFabrica pero se implementa 
            //en CFabricaNatural se instancian las clases CLecheAlmendras, CLecheCoco 
            //y esta clase implementa la interface IProductoLeche
            //es decir se crean productos por familia
            miFabrica.CrearProductos();

            //Como ya creamos los productos leche de almendras o leche de coco en el metodo y el sabor CVainillaNatural 
            //con CrearProductos() de la interfaz IFabrica implementado en CFabricaNatural
            //vamos a obtenerlos
            miLeche = miFabrica.ObtenProductoLeche;  //miLeche es CLecheAlmendras o CLecheCoco q implementan IProductoLeche 
            miSabor = miFabrica.ObtenSabor;        //miSabor es CVainillaNatural q implementa IProductoSaborizante
            Console.WriteLine("Mi malteada es de {0} y {1}", miLeche.ObtenDatos(), miSabor.Informacion());
            Console.ReadLine();
        }
    }
}
