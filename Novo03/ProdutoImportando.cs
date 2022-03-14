using System;
using System.Collections.Generic;
using System.Text;

namespace novo01
{
    class ProdutoImportando : Produto, ITributavel
    {
        public string Pais { get; set; }
        public string AnoFabricacao { get; set; }
        public float CalculaImposto()
        {
            return this.Preco * 15 / 100;
        }
    }
}
