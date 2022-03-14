using System;
using System.Collections.Generic;
using System.Text;

namespace Interface02
{
    class ContaPoupanca : IConta
    {
        public double Saldo { get; set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
        public void Saca (double valor)
        {
            this.Saldo -= valor;
        }

    }
}
