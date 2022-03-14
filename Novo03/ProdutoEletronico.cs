using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class ProdutoEletronico : Produto, ITributavel
    {
        public string Marca { get; set; }
        public string Voltagem { get; set; }
        public float CalculaImposto()
        {
            return this.Preco * 10 / 100;
        }
    }
}
