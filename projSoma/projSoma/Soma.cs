using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSoma
{
    class Soma
    {
        // Sobrecarga ou Overload de métodos
        static public int calcular(int n1, int n2)
        {
            return (n1 + n2);
        }

        static public int calcular(int n1, int n2, int n3)
        {
            return (n1 + n2 + n3);
        }

        static public double calcular(double n1, double n2)
        {
            return (n1 + n2);
        }
    }
}
