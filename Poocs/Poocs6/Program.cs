using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poocs6
{
    class Program
    {
        static void Main(string[] args)
        {
            CCompu compu1 = new CCompu();
            CCompu compu2 = new CCompu("i5",4,450);
            CCompu compu3 = new CCompu("i7",8,670);

            compu1.TipoCambio = 15.70;

            compu1.MuestraDolares();
            compu1.MuestraPesos();
            Console.WriteLine("--------------");

            compu2.TipoCambio = 16;

            compu2.MuestraDolares();
            compu2.MuestraPesos();
            Console.WriteLine("--------------");

            compu3.TipoCambio = 1;

            compu3.MuestraDolares();
            compu3.MuestraPesos();
            Console.WriteLine("============================");

        }
    }
}
