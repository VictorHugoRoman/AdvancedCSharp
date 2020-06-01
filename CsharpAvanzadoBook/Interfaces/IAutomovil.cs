using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Interfaces
{
    public interface IAutomovil
    {
        //Calcular Impuesto
        void CalculaTenencia(double imp);
        //Mostrar Informacion
        void MuestraInformacion();
    }
}
