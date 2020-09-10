using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronMemento.Clases
{
    //Se encarga de hacer el salvado de los objetos
    class CMemento
    {
        //internal es para aquellos archivos q se encuentran en el mismo assembly podran ver el metodo
        internal void Salvar(COriginador objeto)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream MiStream = new FileStream("Autos.aut", FileMode.Create, FileAccess.Write, FileShare.None);//Creamos el archivo "Autos.aut"
            formateador.Serialize(MiStream, objeto);//Serializamos el objeto
            MiStream.Close();

            Console.WriteLine("Se ha salvado");
        }

        internal COriginador Restaurar()
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream miStream = new FileStream("Autos.aut", FileMode.Open, FileAccess.Read, FileShare.None);//Abrimos el archivo "Autos.aut"
            COriginador temp = (COriginador)formateador.Deserialize(miStream);//Deserializamos el stream y lo casteamos
            miStream.Close();

            Console.WriteLine("Se ha restaurado");
            return temp;
        }
    }
}
