using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs3
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;

        public void Muestra()
        {
            Console.WriteLine("Sueldo={0}, impuesto={1}", sueldo, impuesto);
        }

        public double Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        public double Impuesto
        {
            get
            {
                return impuesto;

            }
            set
            {
                impuesto = value;
            }
        }

        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }
    }
}
