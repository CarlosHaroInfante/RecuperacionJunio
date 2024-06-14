using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Dtos
{
    /// <summary>
    /// Dto que contiene los campos del vehiculo.
    /// 140624 - CHI
    /// </summary>
    internal class VehiculosDto
    {
        long id;

        string matricula = "aaaaa";

        DateTime fchMatriculacion = new DateTime(9999, 12, 31);

        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }

        public VehiculosDto() { }
    }
}
