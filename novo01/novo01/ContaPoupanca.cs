using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class ContaPoupanca : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
