using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs9
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona uno = new CPersona("Maria",43);
            uno.Nombre = "Miguel Valencia";
            uno.Edad = 18;
            uno.Muestra();
            Console.WriteLine("----------------------");

            CEmpleado dos = new CEmpleado("Maria", 53, "Contadora", 56789287);
            dos.Nombre = "Sara Nicholls";
            dos.Edad = 18;
            dos.Puesto = "Programador";
            dos.Salario = 171392;

            dos.EmpleadoMuestra();
            Console.WriteLine("----------------------");

            CEmpleado tres = new CEmpleado("Nicol", 34, "Maga", 23);
            tres.ponerDatos("ANA", 84, "MAMA",16382.93 );
            tres.EmpleadoMuestra();
            Console.WriteLine("----------------------");
        }
    }
}
