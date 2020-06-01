using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            lista.Add("Luis");
            lista.Add("Pepep");
            lista.Add("Antonio");
            //la sig instruccion solo asigna una lista de instruccion, es decir, query aun no tiene valor, sino hasta q
            //c ejecuta, c l conoce como Deferred Query
            var query = from p in lista
                        where p.StartsWith("A")
                        orderby p
                        select p;
            //aqui ya ejecutamos query para pbtener los valores
            var myList = query.ToList();
            var myArray = query.ToArray();
            var first = query.First();

            //linq para obtener los valores
            var query2 = (from p in lista
                          where p.StartsWith("A")
                          orderby p
                          select p).Take(5).OrderBy(p => p);

            //Meotods extensores
            //metodo extensor where lo usamos en lista.where y Enumerable.Where            
            //Ejecutamos where directamente de la lista
            var query3 = lista.Where(p => p.StartsWith("A")).OrderBy(p => p).Select(p => p);
            //ejecutamos where dsde la clase Enumerable
            query3 = Enumerable.Where(lista, p => p.StartsWith("A"));

            //Mi metod de extension
            lista.Foreach(p => { Console.WriteLine(p); });
            lista.Foreach(p => Console.WriteLine(p));

            //mi metodo de extension random
            Console.WriteLine("Mi metodo de extension randomize");
            Console.WriteLine(lista.Random());
            Thread.Sleep(100);
            Console.WriteLine(lista.Random());
            Thread.Sleep(100);
            Console.WriteLine(lista.Random());


            //Validaciones
           var primero = lista.FirstOrDefault();
           var last = lista.LastOrDefault();

            if (string.IsNullOrWhiteSpace(first))
            {

            }
            if (string.IsNullOrWhiteSpace(last))
            {

            }

            Number n1 = new Number() { Value = 1 };
            Number n2 = new Number() { Value = 2 };
            if (n1 == n2)
            {
                Console.WriteLine("Ok");
            }
            else
                Console.WriteLine("No");
            Console.ReadLine();
            
        }
    }
}
