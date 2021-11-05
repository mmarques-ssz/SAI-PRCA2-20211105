using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSomaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Soma s;
            s = new Soma(45, 67);
            #endregion

            #region entrada
            //Console.Write("Digite o 1º número: ");
            //s.setNum1(int.Parse(Console.ReadLine()));

            //Console.Write("Digite o 2º número: ");
            //s.setNum2(int.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("A soma de {0} com {1} é {2}", 
                s.getNum1(), s.getNum2(), s.getResultado());
            #endregion
        }
    }
}
