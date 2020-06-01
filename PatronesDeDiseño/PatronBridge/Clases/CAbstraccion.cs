using PatronesDeDiseño.PatronBridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBridge.Clases
{
    //Esta clase conecta al cliente con la abstraccion(Implementacion) a utilizar
    class CAbstraccion //en el diagrama UML seria Abstraccion
    {
        //Referencia a la implementacion
        IBridge implementacion;// nos sirve de referencia para conectarnos con las instancias de las implementaciones especificas

        Dictionary<string, double> productos;

        //Metodo 1, el mas usual
        //Constructor, recibimos la implementacion concreta
        public CAbstraccion(IBridge _imp, Dictionary<string, double> _prod)//(IBridge _imp) con este parametro recibimos la instancia con q c requiere trabajar
        {
            implementacion = _imp;
            productos = _prod;
        }

        //Metodo 2, cuidado no deseamos hacer una fabrica(patron Fabrica)
        public CAbstraccion(int _tipo, Dictionary<string, double> _prod)//con _tipo decimos con cual instancia o version deseamos trabajar
        {
            if (_tipo == 1) implementacion = new CImplementacion1();
            else if (_tipo == 2) implementacion = new CImplementacion2();
            else if (_tipo == 3) implementacion = new CImplementacion3();
            productos = _prod;
        }

        //Estos metodos representan la interfaz q conoce el cliente, serian los metodos de la abstraccion q implementan la interfaz
        //el cliente simplemente ejecutaria estos metodos y la abstraccion decide q version o implementacion ejecutar
        public void MostrarTotales()
        {
            implementacion.MostrarTotales(productos);//Abstrae la funcionalidad que trae (IBridge implementacion)
        }
        public void Listar()
        {
            implementacion.ListarProductos(productos);//Abstrae la funcionalidad que trae (IBridge implementacion)
        }
    }
}
