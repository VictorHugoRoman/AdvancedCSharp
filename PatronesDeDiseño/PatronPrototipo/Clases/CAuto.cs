﻿using PatronesDeDiseño.PatronPrototipo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronPrototipo.Clases
{
    class CAuto : IPrototipo
    {
        //Caracteristicas de esta clase
        private string modelo;
        private int costo;

        //propiedades
        public string Modelo { get => modelo; set => modelo = value; }

        public CAuto(string pModelo, int pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}", modelo, costo);
        }

        #region Implementando IPrototipo
        public object Clonar()
        {
            CAuto clon = new CAuto(modelo, costo);

            return clon;
        }
        #endregion

    }
}
