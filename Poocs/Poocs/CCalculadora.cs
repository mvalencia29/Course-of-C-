using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs
{
    class CCalculadora
    {
        //Atributos
        public double a;
        public double b;
        private double r;

        //Declaramos los metodos
        public void Suma()
        {
            //Se lleva acabo la accion
            r = a + b;
        }

        public void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r={2}", a, b, r);
        }



    }
}
