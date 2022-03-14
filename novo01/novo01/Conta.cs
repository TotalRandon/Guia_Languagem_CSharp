using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class Conta
    {
        public double Saldo { get; set; }
        public double Deposita(double Deposito)
        {
            return this.Saldo = Deposito;
        }
    }
}
