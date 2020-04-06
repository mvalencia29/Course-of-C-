using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs1
{
    class Program
    {
        static void Main(string[] args)
        {
            double impuesto = 0.0;
            CEmpleado Juan = new CEmpleado();

            Juan.set_sueldo(1000590);

            Juan.Muestra();
            Juan.CalculaIMpuesto();

            impuesto = Juan.get_impuesto();

            Console.WriteLine("El impuesto es {0}", impuesto);

            Juan.Muestra();

        }
    }
}
