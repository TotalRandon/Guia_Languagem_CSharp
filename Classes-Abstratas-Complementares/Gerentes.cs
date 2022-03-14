using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas_Complementares
{
    class Gerentes : Funcionarios
    {
        public double Bonificacao { get; set; }

        public override void CalculaBonificacao()
        {
            Bonificacao = saldo * 0.1;

            Console.WriteLine("BONIFICAÇÃO DO FUNCIONARIO [Gerente]");
            Console.WriteLine("");
            Console.WriteLine("Saldo: " + this.saldo);
            Console.WriteLine("Bonificação: " + this.Bonificacao);
            Console.WriteLine("");
        }
    }
}
