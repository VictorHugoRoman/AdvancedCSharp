using PatronesDeDiseño.PatronDecorador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronDecorador.Clases
{
    //Esta clase representa al decorador del patron y db d implementar IComponente para poder llevar a cabo la decoracion
    class CNitrogeno : IComponente
    {
        //Variable de referencia a quien decoramos, representa la referencia en el patron
        //Con esta varible de referencia es como nos comunicaremos con aquel a quien estemos decorando, ya se el nucleo(CAuto) u otro objeto de tipoDecorador(patron)
        //podemos conectarnos con alguien mas q represente a IComponente
        private IComponente decoramosA;

        //Pasamos el objeto q va a ser decorado
        //Recibimos el objeto a quien vamos a decorar como representa IComponente ponemos como parametro la interfaz IComponente  
        public CNitrogeno(IComponente _componente)
        {
            decoramosA = _componente;//una vez asignado el componte los podemos decorar, ya nos comunicamos con él
        }
        public override string ToString()
        {
            //mensaje propio de CSistemaSonido concatenado con el mensaje de aquel a quien este decorando
            return string.Concat("Sistema de Nitrogeno \r\n", decoramosA.ToString());//ToString() es el msg del objeto a decorar, como hace override a ToString() trae un msg
        }
        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso");
        }
        #region Implementando IComponente
        public double Costo()
        {
            //Calculamos el costo
            //El Costo de lo que decoro mas mi costo como componente (CNitrogeno)
            return decoramosA.Costo() + 45000; //decoramosA.Costo(), como el componente a decorar ya trae un estado podemos usar sus valores
        }
        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo"; //decoramosA.Funciona(), como el componente a decorar ya trae un estado podemos usar sus valores
        }
        #endregion
    }
}
