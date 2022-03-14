using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exemplo2
{
    class Emprestimo : Servico
    {
        public double Valor { get; set; }
        public double Taxa { get; set; }

        public Emprestimo()
        {
            Console.WriteLine("Emprestimo servico!");
        }

        public override double Calculataxa()
        {
            return base.Calculataxa() + this.Valor * 0.1;
        }
    }
}
