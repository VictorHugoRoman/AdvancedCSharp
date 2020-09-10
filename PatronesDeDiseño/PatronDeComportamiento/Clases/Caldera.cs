using PatronesDeDiseño.PatronDeComportamiento.Interfaces;
using System;
namespace PatronesDeDiseño.PatronDeComportamiento.Clases
{
    //Representa la maquina
    class Caldera
    {
        //variables de referencia a los estados (CEstadoCalentando, CEstadoAlarma, CEstadoEspera)
        private IEstado calentando;
        private IEstado alarma;
        private IEstado espera;

        //Esta variable representa el estado actual
        private IEstado estadoActual;

        private int temperatura;
        private int combustible;

        public int Combustible { get => combustible; set => combustible = value; }
        public int Temperatura { get => temperatura; set => temperatura = value; }

        //CEstadoCalentando:IEstado
        internal IEstado Calentando { get => calentando; set => calentando = value; }
        //CEstadoAlarma:IEstado
        internal IEstado Alarma { get => alarma; set => alarma = value; }
        //CEstadoEspera:IEstado
        internal IEstado Espera { get => espera; set => espera = value; }
        #region Constructor
        /// <summary>
        /// Iinicializa los estados de la caldera
        /// </summary>
        public Caldera()
        {
            temperatura = 60;
            combustible = 20;
            //inicializamos o instanciamos los estados q pueda tener la caldera
            calentando = new CEstadoCalentando(this);//con this estamos pasando al mismo objeto(Caldera) q esta llevando la ejecucion, es el contexto actual
            alarma = new CEstadoAlarma(this);
            espera = new CEstadoEspera(this);

            //arrancamos la caldera en el estado calentando
            estadoActual = calentando;
        }
        #endregion        
        #region interfaz IEstado
        public void TrabajarCaldera()
        {
            estadoActual.Trabajar();
        }
        public void CortarFuegoCaldera()
        {
            estadoActual.CortarFuego();
        }
        public void PonerCombustibleCaldera()
        {
            estadoActual.PonerCombustible();
        }
        public void ForzarFuegoCaldera()
        {
            estadoActual.ForzarFuego();
        }
        #endregion
        /// <summary>
        /// Cambia el estado de la caldera
        /// </summary>
        /// <param name="pEstado">Cualquier clase que implemente IEstado</param>
        public void ActualizaEstado(IEstado pEstado)
        {
            Console.WriteLine("--- Cambio de estadp ---");
            estadoActual = pEstado;
        }
        public override string ToString()
        {
            return estadoActual.ToString();
        }
    }
}