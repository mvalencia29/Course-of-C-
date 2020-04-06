using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs5
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona p1 = new CPersona();


            CPersona p2 = new CPersona("Juan", 87);

            p1.Muestra();
            p2.Muestra();


        }
    }
}
