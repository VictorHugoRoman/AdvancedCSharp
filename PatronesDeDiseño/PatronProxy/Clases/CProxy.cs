using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronProxy.Clases
{
    //Hacemos uso de anidamiento adentro de la clase
    //esto hace q cualquier clase colocada como privada y anidada
    //solo sea conocida por CProxy
    public class CProxy
    {
        public interface ISujeto //mediante esta interfaz el cliente podra acceder a cualquer proxy(clases) q la implemente 
        {
            void Peticion(int _opcion);
        }

        public class ProxySencillo : ISujeto //En el patron es el Proxy ya que aqui se hacen las validaciones para ejecutar el sujeto(CCocina)
        {
            private CCocina cocina;

            public void Peticion(int _opcion)
            {
                if (cocina is null)//instancia CCocina si es nulo
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }
                if (_opcion == 1)
                    cocina.RecetaSecreta();
                if (_opcion == 2)
                    cocina.Cocinar(5);
            }
        }
        public class ProxySeguro : ISujeto //En el patron es el Proxy ya que aqui se hacen las validaciones para ejecutar el sujeto (CCocina)
        {
            private CCocina cocina;

            public void Peticion(int _opcion)
            {
                string password;
                Console.WriteLine("Dame el password: ");
                password = Console.ReadLine();
                if (password == "abc123")
                {
                    if (cocina is null)//instancia CCocina si es nulo
                    {
                        Console.WriteLine("Activando el Sujeto");
                        cocina = new CCocina();
                    }
                    if (_opcion == 1)
                        cocina.RecetaSecreta();
                    if (_opcion == 2)
                        cocina.Cocinar(5);
                }
                else Console.WriteLine("Acceso Denegado");
            }
        }
        //Esta es la clase q estamos protegieno con el proxy, no puede ser accedida desde clases externas
        private class CCocina //en el patron es el sujeto
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de Oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }
            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinando {0} recetas ", n);
            }
        }
    }
}
