using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronTemplate.Interfaces
{
    //interface IPrimitiva en UML, esta sera la q dbran implementar las ClasesN(UML), en este ejemplo ClasesN son CBarato y CNormal
    //aqui van los pasos q pueden variar porque los implementan las clasesN(UML) en este caso CBarato y CNormal
    interface IPrimitiva
    {
        //estos serian los pasos q podremos implementar de diferente manera dependiendo del estilo
        //, en este caso la calidad del juguete que deseamos crear
        double Decorar(int cantidad); //Paso Decoracion
        double Empacar(int cantidad); //Paso Empacar
    }
}
