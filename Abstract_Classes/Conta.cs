using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    abstract class Conta
    {
        public double saldo { get; set; }

        public abstract void ImprimeExtratoDetalhado();
    }
}
