using System;

namespace Heranca_exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprestimo E = new Emprestimo();
            SeguroVeiculo Sv = new SeguroVeiculo();
            Sv.ValorSeguroVeiculo = 10245;

            Console.WriteLine("Taxa de Emprestimo: " + E.Calculataxa());
            Console.WriteLine("Taxa do Seguro: " + Sv.Calculataxa());
        }
    }
}
