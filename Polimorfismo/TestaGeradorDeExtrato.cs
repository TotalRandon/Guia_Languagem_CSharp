using System;

namespace Polimorfismo_
{
    class TestaGeradorDeExtrato
    {
        static void Main()
        {
            /*
            GeradordeExtratos gerador = new GeradordeExtratos();

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 2000;

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 1000;

            gerador.ImprimeExtratoBasico(cp);
            gerador.ImprimeExtratoBasico(cc);
            */

            Telefonista t = new Telefonista();
            Gerente g = new Gerente();

            t.pontoT();
            Console.WriteLine("");
            g.pontoG();


        }
    }
}
