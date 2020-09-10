using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMediador.Interfaces
{
    //Todos los objetos q esten enviando y recbiendo mensajes dbn implementar esta interfaz
    interface IColega
    {
        void Recibir(string emisor, string mensaje);//el parametro mensaje puede ser de otro tipo por ejemplo un json, int, clase custom, etc.
        void Enviar(string mensaje);
    }
}
