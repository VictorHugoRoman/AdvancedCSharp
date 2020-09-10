using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMVC.Clases
{
    //Clase q representa al controller
    class CControladorAuto
    {
        //Referencia a la vista
        private IVistaAuto vista;

        //Referencia al modelo
        private CMAuto modelo;

        //variable q usaremos para llevar a cabo diferentes acciones 
        private int opcion;
        public int Opcion { get => opcion; set => opcion = value; }

        //constructor del modelo
        //guardamos el modelo y la vista para saber con cual modelo y/o vista esta trabajando el controlador
        public CControladorAuto(CMAuto pModelo, IVistaAuto pVista)
        {
            modelo = pModelo;
            vista = pVista;
        }

        //desplegamos la vista pasandole el modelo como parametro
        public void DespliegaVista()
        {
            vista.despliegaAuto(modelo);
        }

        //metodo para la parte de entrada de informacion
        //es como decirle a la interfaz de usuario q necesita informacion para saber actuar
        public void Solicita()
        {
            opcion = vista.SolicitaEntrada();//aqui le decimos a la vista q entrada dieron
            if (opcion == 1) ActualizaCosto(modelo.Costo *1.15);
            if (opcion == 2) ActualizaModelo();
        }

        //actualizamos el campo costo del modelo
        public void ActualizaCosto(double pCosto)
        {
            modelo.Costo = pCosto;
        }

        //Actualiza el campo Modelo del modelo
        public void ActualizaModelo()
        {
            Console.WriteLine("Deme el modelo");
            modelo.Modelo = Convert.ToInt32(Console.ReadLine());
        }
    }
}
