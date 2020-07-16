using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronBridge.Interfaces;
using PatronesDeDiseño.PatronBridge.Clases;

namespace PatronesDeDiseño.PatronBridge.Clases
{
    class CMainPatronBridge
    {
        public  static void _Main() //representa al cliente en el UML
        {
            #region Productos
            Dictionary<string, double> productos = new Dictionary<string, double>();
            productos.Add("CD13", 56.32);
            productos.Add("CO34", 23.88);
            productos.Add("DK44", 974.56);
            productos.Add("DK56", 43.28);
            productos.Add("MC89", 785.12);
            productos.Add("MK89", 432.56);
            productos.Add("CO77", 874.54);
            productos.Add("DM31", 23.18);
            productos.Add("MH56", 43.12);
            productos.Add("CR23", 21.42);
            #endregion

            #region Ejecuta Implementacion 1
            //Creamos el Bridge, metodo 1
            CAbstraccion bridge = new CAbstraccion(new CImplementacion1(), productos);//trabajamos con version 1 representada con la clase  CImplementacion1
            //Creamos el Bridge, metodos 2
            //CAbstraccion bridge = new CAbstraccion(1, productos); //De esta forma simplmente le mandamos al constructor cual es la version con cual trabajar por medio del primer parametro
            #endregion
            #region Ejecuta Implementacion 2
            //Creamos el Bridge, metodo 1
            //CAbstraccion bridge = new CAbstraccion(new CImplementacion2(), productos);//trabajamos con version 2 representada con la clase  CImplementacion2
            //Creamos el Bridge, metodos 2
            //CAbstraccion bridge = new CAbstraccion(2, productos); //De esta forma simplmente le mandamos al constructor cual es la version con cual trabajar por medio del primer parametro
            #endregion
            #region Ejecuta Implementacion 3
            //Creamos el Bridge, metodo 1
            //CAbstraccion bridge = new CAbstraccion(new CImplementacion3(), productos);//trabajamos con version 3 representada con la clase  CImplementacion3
            //Creamos el Bridge, metodos 2
            //CAbstraccion bridge = new CAbstraccion(3, productos); //De esta forma simplmente le mandamos al constructor cual es la version con cual trabajar por medio del primer parametro
            #endregion
            
            //como estamos en el cliente, este simplemente se comunica con la abstraccion y la abstraccion(CAbstraccion) ejecuta metodo(s) correspondientes a la instanciacion que queramos usar new CAbstraccion(new CImplementacion1())
            bridge.MostrarTotales();
            bridge.Listar();
        }
    }
}
