using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
