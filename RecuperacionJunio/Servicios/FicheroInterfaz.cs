using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Método log que va guardando cada paso del usuario por la aplicación.
        /// 140624 - CHI
        /// </summary>
        public void ficheroLog(string mensaje);


        /// <summary>
        /// Método que realiza la carga inicial de la aplicación.
        /// 140624 - CHI
        /// </summary>
        public void carga();
    }
}
