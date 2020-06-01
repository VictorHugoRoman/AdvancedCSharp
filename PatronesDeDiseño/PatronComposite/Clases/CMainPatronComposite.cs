using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronComposite.Interfaces;
using PatronesDeDiseño.PatronComposite.Clases;

namespace PatronesDeDiseño.PatronComposite.Clases
{
    class CMainPatronComposite
    {
        public static void _Main()
        {
            //arbol contendra todos los elementos, siempre es Compuesto
            IComponente<string> arbol = new CCompuesto<string>("root");//instanciamos un compuesto(CCompuesto) es la raiz del arbol a crear
            //incializamos al varaible trabajo a arbol, para q inicialmente este referenciado
            IComponente<string> trabajo = arbol; //la variable trabajo sera la referencia hacia el nodo o al elemento ya sea compuesto o componente con el cual estamos trabajando
            string opcion = "";
            string dato = "";
            while (opcion != "6")
            {
                Console.WriteLine("Estoy en {0} ", trabajo.Nombre);//
                Console.WriteLine("1-AdicionarCompuesto  2-AdicionarComponente  3-Borrar  4-Buscar  5-Mostrar  6-Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("----------------");
                if (opcion == "1")//AdicionarCompuesto 
                {
                    Console.WriteLine("Dame el nombre del compuesto: ");
                    dato = Console.ReadLine();//Nombre del compuesto
                    //creamos un compuesto nuevo, el ctor inicializa la lista
                    IComponente<string> c = new CCompuesto<string>(dato);//usamos la interfaz IComponente para q se adicione detro de la jerarquia
                    trabajo.Adicionar(c);//Añadimos el compuesto al arbol, ya q trabajo = arbol
                    trabajo = c; //ahora la variable trabajo  apuntara al nuevo elemento (c) tipo Compuesto, simpre nos posiciones a este tipo porque si le podemos añadir elementos
                }
                if (opcion == "2")//AdicionarComponente
                {
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();
                    //aqui no se actualiza la varibale trabajo ya que estamos añadiendo un componente y los componenetes no c pueden contener a si mismos
                    trabajo.Adicionar(new CComponente<string>(dato));//Añadimos la nueva instancia tipo componente, como es componente solo añadimos
                }
                if (opcion == "3") //Borrar, el elemento a borrar tiene q ser hijo o formar parte de la seccion en la q estamos trabajando
                {
                    //Aqui solamente c pueden borrar elementos del compuesto con el cual estoy trabajando
                    //tenemos movernos a otros compuestos para borrar su pertenencias
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();

                    trabajo = trabajo.Borrar(dato);
                }
                if (opcion == "4")//Buscar
                {
                    Console.WriteLine("Dame el elemento a encontrar: ");
                    dato = Console.ReadLine();

                    trabajo = arbol.Buscar(dato);
                }
                if (opcion == "5")//Mostrar
                {
                    Console.WriteLine(arbol.Mostrar(0));//arbol.Mostrar(0) le mandamos la prfundidad en este caso mostamos desde la raiz(0)
                }
                if (opcion == "6")
                {

                }
            }
        }
    }
}
