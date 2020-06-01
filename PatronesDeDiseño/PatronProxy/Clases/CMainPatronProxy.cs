using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronProxy.Clases;

namespace PatronesDeDiseño.PatronProxy.Clases
{
    public class CMainPatronProxy
    {
        public static void _Main()
        {
            //Ejecutando Proxy Sencillo
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();//instanciamos la clase anidada CProxy.ProxySencillo
            //No podemos acceder a la clase CCocina
            //CProxy.CCocina miCocina = new CProxy.CCocina();

            miProxy.Peticion(1);
            Console.WriteLine("------");
            miProxy.Peticion(2);//

            Console.WriteLine("-------");

            //Ejecutando Proxy Seguro
            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();//instanciamos la clase anidada CProxy.ProxySeguro
            miProxyS.Peticion(1);
            Console.WriteLine("---------");
            miProxyS.Peticion(2);
            Console.ReadLine();

        }
    }
}
