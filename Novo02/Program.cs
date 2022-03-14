using System;

namespace Novo02
{
    class Conta
    {
        public double Saldo { get; set; }
        public double Deposita(double Deposito)
        {
            return this.Saldo = Deposito;
        }
    }

    // codigo da interface
    interface ITributavel
    {
        double CalculaTributo();
    }

    class ContaPoupanca : Conta, ITributavel
    {
        // resto da classe aqui

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }

    class ContaInvestimento : Conta, ITributavel
    {
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }

    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }
    }

    // codigo da classe ContaInvestimento que implementa a interface
    class Programa
    {
        static void Main(string[] args)
        {
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            ContaInvestimento ci = new ContaInvestimento();
            ContaPoupanca cp = new ContaPoupanca();

            ci.Deposita(100.0);
            cp.Deposita(100.0);

            t.Acumula(ci);
            t.Acumula(cp);

            Console.WriteLine("O total é: " + t.Total);
        }
    }


}
