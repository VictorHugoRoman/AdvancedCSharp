using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    public class CUtileriasBasicas
    {
        #region Constantes y ReadOnly
        //Como agregar valor a readOnly en tiempo de ejecucion
        public class EjecutarCostoExtra
        {
            public double res = new CostoExtra(123.123d).GetCostoExtra;
        }
        public class CostoExtra
        {
            private readonly double costoExtra;
            //el valor asignado en el constructor ya no podra cambiar
            public CostoExtra(double _costoExtra)
            {
                costoExtra = _costoExtra;
            }
            public double GetCostoExtra
            {
                get { return costoExtra; }
                // set { costoExtra = value; }
            }
            //public void VolverAsignarCostoExtra() {
            //    costoExtra = 12534354.545d;
            //}
        }
        #endregion
        #region Usando static
        public void _MainMiClase()
        {
            //Ejecutando metodo con instancia
            MiClase miClase = new MiClase();
            miClase.Saluda();
            //Ejecutando metodo estatico sin instancia
            MiClase.Mensaje();
            //MiClase.ImprimirValor();
            MiClase.ImprimirNumero();
            //Probando la asignacion a una variable
            MiClase obj1 = new MiClase();
            MiClase obj2  = new MiClase();
            MiClase obj3 = new MiClase();
            obj1.PonValor(3);
            obj2.PonValor(57);
            obj3.PonValor(140);
            obj1.MuestraDatos();
            obj2.MuestraDatos();
            obj3.MuestraDatos();
            
            //Cambiamos de valor a una variable static, lo que hara es cambiar en todas la instancias q contiene esta variable
            obj1.PonNumero(100);
            Console.WriteLine("cambiamos el valor a numero, debio afectar en todas la instancias q lo contiene");
            obj1.MuestraDatos();
            obj2.MuestraDatos();
            obj3.MuestraDatos();
            //ejecutamos el constructor que afecta la variable estatica
            Console.WriteLine("ejecutamos el constructor que afecta la variable estatica numero");
            new MiClase(888);
            obj1.MuestraDatos();
            obj2.MuestraDatos();
            obj3.MuestraDatos();
        }
        class MiClase
        {
            private int valor = 50;
            private static int numero = 10;
            public MiClase()
            {

            }
            public MiClase(int _numero)
            {
                //si hay instancias, al ejecutar este constructor tambien cambiara a este valor
                numero = _numero;
            }
            public void Saluda()
            {
                Console.WriteLine("Solo saludo si hay una instancia de la clase");
            }
            public static void Mensaje()
            {
                Console.WriteLine("Puedo dar el mensaje sin instancia");
            }
            //public static void ImprimirValor()
            //{
            //    //no podemos imprimir la variable valor en un metodo estatico, ya que esta, ocupa una instancia
            //    Console.WriteLine("El Valor es: {0}", valor);
            //}
            public static void ImprimirNumero()
            {
                //Podemos imprimir la variable numero , ya que esta, no ocupa una instancia porque es estatico
                Console.WriteLine("El Valor es: {0}", numero);
            }
            public void PonValor(int _valor)
            {
                valor = _valor;
            }
            public void PonNumero(int _numero)
            {
                //numero al ser una variable estatica reflejara el cambio del nuevo valor en todas las instancias
                //de esta clase al ejecutar este metodo en cualquier clase
                numero = _numero;
            }
            public void MuestraDatos()
            {
                Console.WriteLine("valor={0}, numero={1}", valor, numero);
            }
        }
        #endregion
    }
}
