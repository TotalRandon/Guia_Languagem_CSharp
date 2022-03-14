using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class ContaCorrente : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.01;
        }
    }
}
