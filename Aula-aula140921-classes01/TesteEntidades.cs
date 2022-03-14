using System;

namespace Aula_aula140921_classes01
{
    class Conta //classe flexivel
    {
        public float limite;
        public float saldo;
        public int numero;

        public void Deposita (int valor)
        {
            this.saldo = this.saldo + valor;
        }
    }

    class Cliente
    {
        public string nome;
        public int codigo;
    }

    class CartaoCred
    {
        public int numero;
        public string dataval;
        public Cliente cliente;

    }


    class TesteEntidades
    {
        static void Main(string[] args) //classe estatica
        {
            Conta C; //objeto tipo conta (classe conta)

            ///// CONTA /////

            C = new Conta();// C e a referencia do objeto

            C.Deposita(250);
            C.Deposita(300);

            //C.saldo = 100;
            C.limite = 500;
            C.numero = 1;

            Console.WriteLine("Numero: " + C.numero);
            Console.WriteLine("Limite: " + C.limite);
            Console.WriteLine("Saldo: " + C.saldo); 

            ///// CLIENTE /////

           /* Cliente c1 = new Cliente();
            Cliente c2 = new Cliente();
            CartaoCred cartao1 = new CartaoCred();

            c1.nome = "Joao Victor de Castro Ferro";
            c1.codigo = 1;
            c2.nome = "Victor Yudi";
            c2.codigo = 2;
            cartao1.numero = 1;
            cartao1.dataval = "01/01/2025";
            cartao1.cliente = c1;

            Console.WriteLine(c1.nome + "\n" + c2.nome);
            Console.WriteLine("Nome do cliente do cartao: " + cartao1.cliente.nome); */

        }
    }
}
