using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMVC.Clases
{
    //Clase q representa al modelo
    class CMAuto
    {
        //datos del modelo
        private string nombre;
        private int modelo;
        private double costo;

        //constructor del modelo 
        public CMAuto(string pNombre, int pModelo, double pCosto)
        {
            nombre = pNombre;
            modelo = pModelo;
            costo = pCosto;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public double Costo { get => costo; set => costo=value; }
    }
}
