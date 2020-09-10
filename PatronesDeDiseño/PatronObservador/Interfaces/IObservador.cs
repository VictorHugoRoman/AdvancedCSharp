using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronObservador.Interfaces
{
    interface IObservador
    {
        //metodo para el modelo de push        
        void Update(string mensaje);
        //metodo para el modelo de pull
        void UpdatePull();
    }
}
