using RecuperacionJunio.Controladores;
using RecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void esAntiguo()
        {
            bool historico = true;
            foreach (PropietarioDto propietario in Program.propietario)
            {
                bool antiguo = false;
                if (propietario.EsHistorico == true)
                {
                    Console.WriteLine("Nº de historicos: " + Program.propietario.Count);
                    antiguo = true;
                    break;
                }


            }
            if (!historico)
            {
                Console.WriteLine("no hay coches historicos");
            }

        }


        public void altaPropietario()
        {
            PropietarioDto propietario = new PropietarioDto();
            Console.WriteLine("dni del nuevo cliente");
            string dni = Console.ReadLine();

            if (dni.Length != 9)
            {
                Console.WriteLine("Vuelva a intentarlo, debe de ser de 9 digitos");
            }
            else
            {
                propietario.Dni = dni;
                propietario.Id = idAuto();

                Console.WriteLine(propietario.ToString());
            }

        }

        private long idAuto()
        {
            int tamanioLista = Program.propietario.Count;
            long idN = 1;

            if (tamanioLista > 0)
            {
                idN = Program.propietario[tamanioLista - 1].Id + 1;
            }
            else
            {
                idN = 1;
            }

            return idN;
        }


    }
}

