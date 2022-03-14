using System;

namespace Interface02
{
    class TestaContas
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Deposita(500);
            cp.Deposita(600);

            cc.Saca(100);
            cp.Saca(150);

            GeradordeExtrato g = new GeradordeExtrato();
            g.GeraExtrato(cc);
            g.GeraExtrato(cp);
        }
    }
}
