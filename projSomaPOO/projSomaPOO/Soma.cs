using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSomaPOO
{
    class Soma
    {
        #region atributos
        private int num1;
        private int num2;
        private int resultado;
        #endregion

        #region construtores
        public Soma()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Soma(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public int getNum1()
        {
            return this.num1;
        }

        public int getNum2()
        {
            return this.num2;
        }

        public int getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado = this.num1 + this.num2;
        }
        #endregion
    }
}
