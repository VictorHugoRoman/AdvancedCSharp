using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronComposite.Interfaces
{
    //Es la interfaz componente, los elementos compuestos o componentes tienen q implementar a esta interfaz
    interface IComponente<T>//esta interfaz define los comportamientos comunes tanto a los compuestos como a los componentes
    {
        T Nombre { get; set; }
        #region Comportamientos comunes de compuestos y componentes
        void Adicionar(IComponente<T> _elemento);
        IComponente<T> Borrar(T _elemento);
        IComponente<T> Buscar(T _elemento);
        string Mostrar(int _profundidad);
        #endregion
    }
}
