using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public double ReajustarPreco(float percentual)
        {
            return this.Preco += percentual;
        }
    }
}
