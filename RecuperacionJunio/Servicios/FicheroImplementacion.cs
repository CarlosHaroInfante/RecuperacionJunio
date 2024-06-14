using RecuperacionJunio.Controladores;
using RecuperacionJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{

    internal class FicheroImplementacion : FicheroInterfaz
    {
        public void ficheroLog(string mensaje)
        {
            DateTime fechaHoy = DateTime.Now;
            string hoy = fechaHoy.ToString("ddMMyyyy");
            string ruta = "C:\\Users\\Carlos\\Desktop\\Programación\\RecuperacionJunio\\";
            string nombre = string.Concat("log-", hoy , ".txt");
            string archivo = string.Concat(ruta, nombre);

            try
            {

                using(StreamWriter escribe = new StreamWriter(archivo, true))
                {
                    escribe.Write(mensaje + "\n");
                    escribe.Close();
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error al escribir/crear el fichero log " + ex.Message.ToString());
            }

        }
        public void carga()
        {

            string carga = "C:\\Users\\Carlos\\Desktop\\Programación\\RecuperacionJunio\\datosIniciales.txt";

            try
            {

                string linea;

                using(StreamReader lee = new StreamReader(carga))
                {

                    while((linea = lee.ReadLine()) != null) {
                        PropietarioDto propietarioDto = new PropietarioDto();
                        PropietarioDto propietario = propietarioDto;
                        VehiculosDto vehiculos = new VehiculosDto();
                        string[] separa = linea.Split(":");
                        propietario.Matricula = separa[0];
                        vehiculos.FchMatriculacion = Convert.ToDateTime(separa[1]);
                        propietario.Dni = separa[2];
                        propietario.FechaCompra = Convert.ToDateTime(separa[3]);
                        propietario.Id = idAuto();
                        propietario.EsHistorico = antiguo();


                        Program.propietario.Add(propietario);
                        Program.vehiculo.Add(vehiculos);
                        
                    }

                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error al leer el fichero de datosIniciales " + ex.Message.ToString());
            }


        }
        /// <summary>
        /// Método privado que calcula el id automaticamente.
        /// 140624 - CHI
        /// </summary>

        private long idAuto()
        {
            int tamanioLista = Program.propietario.Count;
            long idN = 1;

            if(tamanioLista > 0)
            {
                idN = Program.propietario[tamanioLista - 1].Id + 1;
            }
            else
            {
                idN = 1;
            }

            return idN;
        }

        /// <summary>
        /// Pone que el bool en si es antiguo o no.
        /// 140624 - CHI
        /// </summary>
        private bool antiguo()
        {

            VehiculosDto vehiculos = new VehiculosDto();
            PropietarioDto propietario = new PropietarioDto();
            bool historico = true;
            foreach (VehiculosDto vehiculo in Program.vehiculo)
            {

                DateTime fechaVehiculo = vehiculo.FchMatriculacion;


                DateTime fechaHoy = DateTime.Today;

                long fechaAntigua = fechaHoy.Year - 25;


                if (fechaAntigua >= fechaVehiculo.Year - 25)
                {
                    historico = true;
                    propietario.EsHistorico = true;
                }
                else
                {
                    historico = false;
                    propietario.EsHistorico = false;
                }



            }
            return historico;

        }

    }

   }

