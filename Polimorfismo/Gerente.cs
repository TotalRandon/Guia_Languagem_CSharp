using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo_
{
    class Gerente : Funcionarios
    {
        public void pontoG()
        {
            DateTime Entrada = DateTime.Now;
            DateTime Saida = DateTime.UtcNow;

            string HorarioE = string.Format("{0:d/m/yyyy HH:mm:ss}", Entrada);
            string HorarioS = string.Format("{0:d/m/yyyy HH:mm:ss}", Saida);

            Console.WriteLine("Folha de ponto do Gerente: ");
            Console.WriteLine("");
            Console.WriteLine("Entrada: " + HorarioE);
            Console.WriteLine("Saida: " + HorarioS);

        }

    }
}
