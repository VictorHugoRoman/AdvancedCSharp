using PatronesDeDiseño.PatronBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDiseño.PatronBuilder.Clases
{
    //Esta clase representa al producto q l builder va a construir, a traves de lo q le diga el Director(ver UML)
    class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;
        //colocamos los metodos de esta manera ya q l Builder s l q c encargará de instanciar los componentes
        //q c van adicionando al producto, por ello el builder necesita una forma de poder colocarle o adicionarle al producto
        //ese elemento q a creado

        //Primero ColocarMotor, el builder c encargar de pasarle al producto pMotorq l corresponde
        public void ColocarMotor(IMotor pMotor)
        {
            motor = pMotor;
            Console.WriteLine("Se ha colocado el motor: {0}", motor.Especificaciones());
        }

        public void ColocarCarroceria(ICarroceria pCarroceria)
        {
            carroceria = pCarroceria;
            Console.WriteLine("Se ha colocado una carroceria: {0}", carroceria.Caracteristicas());
        }

        public void ColocarLlantas(ILlantas pLlantas)
        {
            llantas = pLlantas;
            Console.WriteLine("Se han colocado las llantas: {0}", llantas.Informacion());
        }
        public void MostrarAuto()
        {
            Console.WriteLine("Tu auto tiene {0}, {1}, {2}", motor.Especificaciones(), llantas.Informacion(), carroceria.Caracteristicas());
        }
        //Podemos otros metodos como tal d la calse Producto
    }
}
