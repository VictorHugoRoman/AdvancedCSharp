using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Interfaces
{
    interface IProducto
    {
        //Metodos q componen el comportamiento del producto
        //Calcular el impuesto
        void calculaImpuesto(double imp);
        //Mostrar Inforamcione
        void MuestraInformacion();
    }
}
