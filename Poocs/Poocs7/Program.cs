using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0;

            CCalculacora miCalcu = new CCalculacora(5,3);

            miCalcu.Suma();
            Console.WriteLine("La suma es {0}", miCalcu.R);

            miCalcu.Resta();
            Console.WriteLine("La resta es {0}", miCalcu.R);

            r = CCalculadoraS.Suma(10, 9);
            Console.WriteLine("La suma es {0}", r);
            r = CCalculadoraS.Resta(10, 9);
            Console.WriteLine("La Resta es {0}", r);
        }
    }
}
