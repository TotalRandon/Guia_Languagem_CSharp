using System;

namespace Abstract_Classes
{
    class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c = new ContaPoupanca();
            c.saldo = 1000;
            c.ImprimeExtratoDetalhado();
        }
    }
}
