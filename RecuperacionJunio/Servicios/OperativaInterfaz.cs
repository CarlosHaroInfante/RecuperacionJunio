using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Método que dice si el coche es antiguo o no.
        /// 140624 - CHI
        /// </summary>
        public void esAntiguo();

        /// <summary>
        /// Alta de un nuevo vehiculo.
        /// 140624 - CHI
        /// </summary>
        public void altaPropietario();

    }
}
