using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp
{
    //para hacer metodos extensores tenemos que usar tipos static en calses static
    public static class Extensions
    {
        //parametro1: un objecto ienumerable, parametro2: expresion lambda o funcion que queremos ejecutar por cauno de los parametros
        public static void Foreach<G>(this IEnumerable<G> value, Action<G> action) {
            if (value != null) {
                foreach (var item in value)
                {
                    //acttion es la funcion q mandamos q queremos ehecutar
                    action(item);
                }
            }
        }
        public static G Random<G>(this IEnumerable<G> value)
        {
            //definimos el resultado
            G result = default(G);

            if (value != null)
            {
                Random r = new Random();
                int index = r.Next(0, value.Count());
                result = value.ToArray()[index];
            }

            return result;
        }
    }
}
