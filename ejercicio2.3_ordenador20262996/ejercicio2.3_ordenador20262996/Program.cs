using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2._3_ordenador20262996
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ordenador miOrdenador = new ordenador("Dell", "Intel Core i7", 16, 500);

            miOrdenador.MayorCapacidad();
            miOrdenador.MenorCapacidad();

            Console.ReadKey();
        }

    }
}

