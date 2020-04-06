using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs2
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado Juan = new CEmpleado();

            Juan.set_sueldo(7800);
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.MuestraLog();

            Console.WriteLine("--------------------------");


            CEmpleado Pablo = new CEmpleado();

            Pablo.set_sueldo(50000);
            Pablo.set_sueldo(25000);
            Pablo.set_sueldo(10000);

            Console.WriteLine("El sueldo de pablo es {0}", Pablo.get_sueldo(12345));

            Pablo.Muestra();
            Pablo.MuestraLog();
        }
    }
}
