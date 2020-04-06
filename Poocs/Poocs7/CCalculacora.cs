using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs7
{
    class CCalculacora
    {
        private double a;
        private double b;
        private double r;

        public CCalculacora(double pa, double pb)
        {
            a = pa;
            b = pb;
        }

        public double R
        {
            get { return r; }
        }

        public void Suma()
        {
            r = a + b;
        }

        public void Resta()
        {
            r = a - b;
        }
    }
}
