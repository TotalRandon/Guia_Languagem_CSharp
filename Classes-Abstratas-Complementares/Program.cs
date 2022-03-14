using System;

namespace Classes_Abstratas_Complementares
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f = new Gerentes();
            f.saldo = 5000;
            f.CalculaBonificacao();
        }
    }
}
