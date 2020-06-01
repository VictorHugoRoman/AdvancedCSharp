using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAvanzadoBook.Clases
{
    //https://www.youtube.com/watch?v=gQH0mak38WE
    public class CRectangulo : IComparable
    {
        public double ancho { get; set; }
        public double alto { get; set; }
        public double area { get; set; }
        public CRectangulo(double _ancho, double _alto)
        {
            ancho = _ancho;
            alto = _alto;
            CalcularArea();
        }
        private void CalcularArea()
        {
            area = ancho * alto;
        }
        public override string ToString()
        {
            return string.Format("[{0},{1}]={2}", ancho, alto, area);
        }

        #region Implementacion IComparable
        int IComparable.CompareTo(object obj)
        {
            if (!(obj is CRectangulo)) throw new Exception("el objeto no es tipo CRectangulo");
            CRectangulo temp = (CRectangulo)obj;
            //hacemos la regla de validacion mediante el area para saber si un triangulo es mayor, menor o igual q al comparado
            //aqui podemos meter mas reglas de validacion para comparar objetos
            if (area > temp.area) //Si somos mas grande q el objeto retornamos 1
                return 1;
            else if (area < temp.area)//Si somos menos grande q el objeto retornamos -1
                return -1;
            return 0;//si somos iguales al objeto 
        }
        #endregion

    }
}
