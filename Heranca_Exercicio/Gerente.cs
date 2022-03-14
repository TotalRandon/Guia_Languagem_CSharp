using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Exercicio
{
    class Gerente : Funcionario
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public override double CalculaBonificacao()
        {
            return this.Salario * 0.6 + 100;
        }
    }
}
