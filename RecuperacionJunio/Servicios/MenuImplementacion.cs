using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionJunio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {
            Console.WriteLine("Menú de la aplicación");
            Console.WriteLine("---------------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Número de históricos");
            Console.WriteLine("[2] - Alta nuevo propietario");
            Console.WriteLine("---------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
