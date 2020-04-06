using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs8
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario)
            : base(pNombre, pEdad)
        {
            Console.WriteLine("Constructor de Persona");
            puesto = pPuesto;
            salario = pSalario;
        }



        public string Puesto
        {
            set { puesto = value; }
            get { return puesto; }
        }
        public double Salario
        {
            set { salario = value; }
            get { return salario; }
        }

        public void ponerDatos(string pNombre, int pEdad, string pPuesto, double pSalario)
        {
            Nombre = pNombre;
            Edad = pEdad;
            puesto = pPuesto;
            salario = pSalario;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabajo de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
