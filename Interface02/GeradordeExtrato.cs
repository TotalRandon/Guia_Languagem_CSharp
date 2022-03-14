using System;
using System.Collections.Generic;
using System.Text;

namespace Interface02
{
    class GeradordeExtrato
    {
        public void GeraExtrato(IConta c)
        {
            Console.WriteLine("EXTRATO");
            Console.WriteLine("Saldo: " + c.Saldo);
        }
    }
}
