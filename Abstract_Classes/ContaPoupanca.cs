using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes
{
    class ContaPoupanca : Conta
    {
        public int DiadoAniversario { get; set; }

        public override void ImprimeExtratoDetalhado()
        {
            Console.WriteLine("EXTRATO DETALHADO DE CONTA POUPANÇA");
            Console.WriteLine("");
            
            DateTime agora = DateTime.Now;

            Console.WriteLine("DATA: " + agora.ToString("D"));
            Console.WriteLine("Saldo: " + this.saldo);
            Console.WriteLine("Aniversario: " + this.DiadoAniversario);
        }
    }
}
