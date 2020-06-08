using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    //Aqui en Fachada se inicializan los diferentes subsitemas
    class CFachada //UML Fachada, esta expone la interfaz(los metodos de alto nivel) hacia el cliente
    {
        //Estos son los subsistemas q c estan utilizando
        //el cliente solo manda llamar los metods y la fachada se encarga del proceso
        private CSistemaCompra compra = new CSistemaCompra();
        private CSubSistemaAlmacen almacen = new CSubSistemaAlmacen();
        private CSubSistemaEnvio envio= new CSubSistemaEnvio();

        //Este metodo es usado para realizar de forma sencilla una operacion
        //mas compleja que requiere de uno o varios subsistemas
        //aqui podemos meter mas complejidad, ciclos, validaciones
        public void Compra()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }
        }        
    }
}
