using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMemento.Clases
{
    //COriginador provee soporte a los objetos q seran salvados, en este ejemplo guardamos 3 variables nombre, modelo, costo
    //Decide q tanto del estado se necesita salvar
    [Serializable]
    class COriginador
    {
        private string nombre;
        private int modelo;
        private double costo;

        public string Nombre{ get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo = value; }

        public COriginador(string pNombre, int pModelo, double pCosto)
        {
            nombre = pNombre;
            modelo = pModelo;
            costo = pCosto;
        }

        //Aqui van los metodos q ocupemos dependiendo de la aplicacion, estos son solo para demostracion

        public void Mostrar()
        {
            Console.WriteLine("{0} {1}, Con Costo de ${2}", nombre, modelo, costo);
        }
        //Guarda el estado actual del objeto COriginador
        public CMemento CreaMemento()
        {
            CMemento miMemento = new CMemento();
            miMemento.Salvar(this);
            return miMemento;
        }
        //obtenemos el o los objetos(COriginador) guardados en algun momento
        public void Restaurar(CMemento pMemento)
        {
            COriginador temp = pMemento.Restaurar();
            nombre = temp.Nombre;
            modelo = temp.Modelo;
            costo = temp.Costo;
        }
    }
}
