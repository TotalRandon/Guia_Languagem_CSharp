using System;

namespace Console_Prova
{
    static public class Constante
    {
        public const int Total = 5;
    }
    class Cadastro
    {
        public string Nome;
        public string Pronturario;
        public string Email;
        public int Idade;

        public void EscreverCadastro()
        {
            Console.WriteLine("Nome: ");
            this.Nome = Console.ReadLine();
            Console.WriteLine("Prontuario: ");
            this.Pronturario = Console.ReadLine();
            Console.WriteLine("Email: ");
            this.Email = Console.ReadLine();
            Console.WriteLine("Idade: ");
            this.Idade = Int32.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void LerCadastro()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Prontuario: " + this.Pronturario);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Idade: " + this.Idade);
        }
        public void LerCadastroSelecionar()
        {

        }
    }

    class Aluno
    {
        public void Inicializa(Cadastro[] A)
        {
            string Nome = "";
            int Idade = 0;
        }

        class ListaChamada
        {
            public void ListaCadastro(Cadastro[] A)
            {
                int cont;
                Console.WriteLine("=============== Cadastro de Alunos ===============");
                for (cont = 0; cont < Constante.Total; cont++)
                {
                    A[cont] = new Cadastro();
                }
            }
            public void ListaMostrarTudo(Cadastro[] A)
            {
                int cont;
                Console.WriteLine("=============== Cadastro de Alunos ===============");
                for (cont = 0; cont < Constante.Total; cont++)
                {
                    A[cont] = new Cadastro();
                }
            }

            public void ListaMostrarSelecionado(Cadastro[] A)
            {
                int cont;
                Console.WriteLine("=============== Cadastro de Alunos ===============");
                for (cont = 0; cont < Constante.Total; cont++)
                {
                    A[cont] = new Cadastro();
                }
            }
        }

        class Lobby
        {
            private int num1;
            public int Menu(Cadastro[] A)
            {
                while (true)
                {
                    Console.WriteLine("=============== Menu de Cadastros ===============");
                    Console.WriteLine();
                    Console.WriteLine("Digite um número correspondente a o que deseja fazer");
                    Console.WriteLine("1 - Cadastrar Alunos");
                    Console.WriteLine("2 - Exibir todos os alunos");
                    Console.WriteLine("3 - Exibir alunos");
                    Console.WriteLine();
                    this.num1 = Int32.Parse(Console.ReadLine());
                    if (num1 == 1)
                    {
                        Console.Clear();
                        Cadastro[] Lista1 = new Cadastro[Constante.Total];
                        ListaChamada LC = new ListaChamada();

                        LC.ListaCadastro(Lista1);
                    }
                    else
                    {
                        if (num1 == 2)
                        {
                            Console.Clear();
                            
                            Cadastro[] Lista1 = new Cadastro[Constante.Total];
                            ListaChamada LC = new ListaChamada();

                            LC.ListaMostrarTudo(Lista1);
                        }
                        else
                        {
                            if (num1 == 3)
                            {
                                Console.Clear();
                               
                                Cadastro[] Lista1 = new Cadastro[Constante.Total];
                                ListaChamada LC = new ListaChamada();

                                LC.ListaMostrarSelecionado(Lista1);
                            }
                            else
                            {
                                Console.WriteLine("Número Invalido!");
                                return 1;
                            }
                        }
                    }
                }
            } 
        }
        class Program
        {
            static void Main(string[] args)
            {
                Cadastro[] Lista = new Cadastro[Constante.Total];

                Aluno Al = new Aluno();
                Lobby Lb = new Lobby();

                Al.Inicializa(Lista);
                Lb.Menu(Lista);
            }
        }
    }
}
