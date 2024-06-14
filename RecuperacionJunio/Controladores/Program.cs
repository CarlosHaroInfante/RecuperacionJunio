using RecuperacionJunio.Dtos;
using RecuperacionJunio.Servicios;

namespace RecuperacionJunio.Controladores
{
    /// <summary>
    /// Class program de la aplicación, la cual contiene el metodo main.
    /// 140624 - CHI
    /// </summary>
    class Program
    {
         public static   List<PropietarioDto> propietario = new List<PropietarioDto>();
         public static List<VehiculosDto> vehiculo = new List<VehiculosDto>();
        /// <summary>
        /// Método main de la aplicación, la cula contiene las llamadas a métodos.
        /// 140624 - CHI
        /// </summary>
        public static void Main(string[] args)
        {

            FicheroInterfaz fichero = new FicheroImplementacion();
            string mensaje = "";
            fichero.carga();

            try
            {
                MenuInterfaz menu = new MenuImplementacion();
                OperativaInterfaz operativa = new OperativaImplementacion();
                bool cerrarMenu = false;

                while (!cerrarMenu)
                {

                    int op = menu.menu();

                    switch (op)
                    {

                        case 0:
                            Console.WriteLine("Se cierra el menú");
                            mensaje = "Se cierra el menú";
                            fichero.ficheroLog(mensaje);
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("Número de históricos");
                            operativa.esAntiguo();
                            mensaje = "Opción número de historicos";
                            fichero.ficheroLog(mensaje);
                            break;
                        case 2:
                            Console.WriteLine("Alta de nuevo propietario");
                            operativa.altaPropietario();
                            mensaje = "Opción alta de nuevo propietario";
                            fichero.ficheroLog(mensaje);
                            break;
                        default:
                            Console.WriteLine("Opción erronea, vuelve a intentarlo");
                            break;

                    }

                }


            }catch(Exception ex)
            {
                Console.WriteLine("Error en el método main de la aplicacion " + ex.ToString());
                mensaje = "Error en el método main de la aplicacion";
                fichero.ficheroLog(mensaje);
            }

            


        }

    }

}
