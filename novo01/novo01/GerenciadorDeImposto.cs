using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class GerenciadorDeImposto
    {
        public double Total { get; private set; }
        public void Adiciona(ITributavel tributavel)
        {
            this.Total += tributavel.CalculaTributo();
        }
    }
}
