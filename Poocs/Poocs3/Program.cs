using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs3
{
    class Program
    {
        static void Main(string[] args)
        {
            CEmpleado Juan = new CEmpleado();

            Juan.Sueldo = 15000;
            Juan.CalculaImpuesto();

            Console.WriteLine("El impuesto de Juan es {0}", Juan.Impuesto);

            Juan.Muestra();
        }
    }
}
