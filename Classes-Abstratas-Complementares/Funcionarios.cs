using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas_Complementares
{
    abstract class Funcionarios
    {
        public double saldo { get; set; }

        public abstract void CalculaBonificacao();
    }
}
