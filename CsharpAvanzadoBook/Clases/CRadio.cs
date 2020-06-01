using CsharpAvanzadoBook.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    public class CRadio: IProducto, ICloneable, IEnumerable, IEnumerator
    {
        double costo;
        double impuesto;
        string descripcion;
        
        #region Metodos Propios
        public CRadio()
        {
            costo = 150.85;
            descripcion = "Radio de onda corta";
        }
        public void CalcularCosto(double nCosto)
        {
            costo = nCosto;
        }
        #endregion
        #region Implementando Interfaz IProducto
        public void calculaImpuesto(double imp)
        {
            impuesto = costo * imp;
        }
        public void MuestraInformacion()
        {
            //mostramos la informacion necesaria
            Console.WriteLine("-----Producto Radio");
            Console.WriteLine(descripcion);
            Console.WriteLine("Costo {0}, impuesto {1} ", costo, impuesto);
        }
        #endregion
        #region Implementando Interfaz ICloneable
        public object Clone()
        {
            CRadio temp = new CRadio();
            //Empezamos con el copiado del estado actual del objeto, aqui tambien pueden ir datos privates
            temp.costo = costo;
            temp.descripcion = descripcion;
            temp.impuesto = impuesto;
            return temp;
        }
        /*
ICloneable tiene el unico metodo
public interface ICloneable
{
object Clone();//metodo a implementar, tenemos q hacer un typeCast
}
*/
        #endregion
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public object Current => throw new NotImplementedException();
    }
}
