using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_
{
    class GeradordeExtratos
    {
        public void ImprimeExtratoBasico(Conta c)
        {
            DateTime agora = DateTime.Now;
            string Horario = string.Format("{0:d/m/yyyy HH:mm:ss}", agora);

            Console.WriteLine("Data: " + Horario);
            Console.WriteLine("Saldo: " + c.Saldo);
        }
    }
}
