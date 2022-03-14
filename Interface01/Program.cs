using System;

namespace Interface01
{
    class Program
    {
        static void Main(string[] args)
        {
            Iconta Ic = new ContaCorrente();

            GeradordeExtrato g = new GeradordeExtrato();
            ContaCorrente cc = new ContaCorrente();

            g.GeraExtrato(c);
        }
    }
}
