using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronesDeDiseño.PatronMemento.Clases;

namespace PatronesDeDiseño.PatronMemento.Clases
{
    class CMainPatronMemento
    {
        public static void _Main()
        {
            //Creamos el originador
            COriginador auto = new COriginador("March", 2019, 250000);
            auto.Mostrar();

            //Creamos el careTaker
            CCareTaker ct = new CCareTaker();

            //Guardamos el estado
            ct.Memento = auto.CreaMemento();//se guarda el objeto con los datos de arriba new COriginador("March", 2019, 250000);

            //metimos el ejemplo de modificar para ejemplo en la aplicacion, pero supongamos q por alguna razon el equipo dejo
            //de funcionar guardando o modificando informacion hasta este punto.
            //Modificamos el objeto
            auto.Nombre = "Vocho";
            auto.Modelo = 1970;
            auto.Costo = 35000;
            auto.Mostrar();

            //aqui supopngamos q volvimos a la aplicacion y queremos recuperar la informacion al estado anterior 
            //a q sucediera el problema

            //Restauramos el estado anterior
            auto.Restaurar(ct.Memento);
            auto.Mostrar();

            Console.ReadLine();
        }
    }
}
