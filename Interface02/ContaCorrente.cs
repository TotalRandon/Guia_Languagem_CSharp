using System;
using System.Collections.Generic;
using System.Text;

namespace Interface02
{
    class ContaCorrente : IConta
    {
        public double Saldo { get; set; }
        private double taxaporOperacao = 0.45;

        public void Deposita(double valor)
        {
            this.Saldo = this.Saldo + valor - this.taxaporOperacao;
        }

        public void Saca(double valor)
        {
            this.Saldo = this.Saldo - valor + this.taxaporOperacao;
        }
    }
}
