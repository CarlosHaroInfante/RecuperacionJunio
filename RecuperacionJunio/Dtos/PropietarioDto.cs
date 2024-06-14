using RecuperacionJunio.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Dtos
{
    /// <summary>
    /// Dto que contiene los campos del propietario del vehiculo.
    /// 140624 - CHI
    /// </summary>
    internal class PropietarioDto
    {
        long id;

        string dni  = "aaaaa";

        string matricula = "aaaaa";

        DateTime fechaCompra = new DateTime(9999, 12, 31);

        bool esHistorico = false;

       

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }

        
        public string ToString()
        {
            string mensaje = string.Concat("Nuevo propietario: ", this.Id, " - ", this.dni);

            return mensaje;
        }

    }
}
