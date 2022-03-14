using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_
{
    class Telefonista : Funcionarios
    {
        public void pontoT()
        {
            DateTime Entrada = DateTime.Now;
            DateTime Saida = DateTime.UtcNow;

            string HorarioE = string.Format("{0:d/m/yyyy HH:mm:ss}", Entrada);
            string HorarioS = string.Format("{0:d/m/yyyy HH:mm:ss}", Saida);

            Console.WriteLine("Folha de ponto do telefonista: ");
            Console.WriteLine("");
            Console.WriteLine("Entrada: " + HorarioE);
            Console.WriteLine("Saida: " + HorarioS);
        }
    }
}
