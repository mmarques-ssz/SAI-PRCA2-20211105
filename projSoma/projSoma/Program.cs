using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSoma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Soma.calcular(5, 8));

            Console.WriteLine(Soma.calcular(2, 4, 6));

            Console.WriteLine(Soma.calcular(5.4, 8.7));

        }
    }
}
