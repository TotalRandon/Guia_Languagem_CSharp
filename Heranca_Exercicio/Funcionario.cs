using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Exercicio
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalculaBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
