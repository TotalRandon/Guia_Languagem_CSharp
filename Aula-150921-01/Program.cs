using System;

namespace Aula_150921_01
{
    static public class Constantes
    {
        public const int Total = 2;
    }

    class Contato
    {
        public string Nome;
        public string Email;
        public string Endereco;
        public string Cidade;
        public string Telefone;
        public string Numero;
        public string Estado;
        public string Observacoes;
        public int Idade;

        public void LerContato()
        {
            Console.Write("Nome: ");
            this.Nome = Console.ReadLine();
            Console.Write("Email: ");
            this.Email = Console.ReadLine();
            Console.Write("Endereço: ");
            this.Endereco = Console.ReadLine();
            Console.Write("Numero: ");
            this.Numero = Console.ReadLine();
            Console.Write("Telefone: ");
            this.Telefone = Console.ReadLine();
            Console.Write("Cidade: ");
            this.Cidade = Console.ReadLine();
            Console.Write("Estado: ");
            this.Estado = Console.ReadLine();
            Console.Write("Observações: ");
            this.Observacoes = Console.ReadLine();
            Console.Write("Idade: ");
            this.Idade = Int32.Parse(Console.ReadLine());
            Console.Clear();

        }

        public void MostrarContatoTotal()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Endereço: " + this.Endereco);
            Console.WriteLine("Número: " + this.Numero);
            Console.WriteLine("Telefone: " + this.Telefone);
            Console.WriteLine("Cidade: " + this.Cidade);
            Console.WriteLine("Estado: " + this.Estado);
            Console.WriteLine("Observações: " + this.Observacoes);
            Console.WriteLine("Idade: " + this.Idade);

        }

        public void MostrarContatoMeio()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Endereço: " + this.Endereco);
            Console.WriteLine("Cidade: " + this.Cidade);
            Console.WriteLine("Estado: " + this.Estado);
        }
    }

    class Agenda
    {
        public void Inicializa(Contato[] A)
        {
           int cont;
           for(cont=0; cont<Constantes.Total;cont++)
           {
               A[cont] = new Contato();
           }
        }

        public void LerAgenda(Contato[] A)
        {
            int cont;
            for (cont = 0; cont < Constantes.Total; cont++)
            {  
                Console.WriteLine("===== Cadastro de Contatos "+ cont +" =====");
                A[cont].LerContato();
            }
        }

        public void MostrarAgendaTotal(Contato[] A)
        {
            int cont;
               
            Console.WriteLine("===== Lista de Contatos =====");
            for(cont = 0; cont < Constantes.Total; cont++)
            {
                Console.WriteLine("Nome: " + A[cont].Nome);
                Console.WriteLine("Email: " + A[cont].Email);
                Console.WriteLine("Endereço: " + A[cont].Endereco);
                Console.WriteLine("Número: " + A[cont].Numero);
                Console.WriteLine("Telefone: " + A[cont].Telefone);
                Console.WriteLine("Cidade: " + A[cont].Cidade);
                Console.WriteLine("Estado: " + A[cont].Estado);
                Console.WriteLine("Observações: " + A[cont].Observacoes);
                Console.WriteLine("Idade: " + A[cont].Idade);
            }
        }
        public void MostrarAgendaMeio(Contato[] A)
        {
            int cont;

            Console.WriteLine("===== Lista de Contatos =====");
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                Console.WriteLine("Nome: " + A[cont].Nome);
                Console.WriteLine("Endereço: " + A[cont].Endereco);
                Console.WriteLine("Cidade: " + A[cont].Cidade);
                Console.WriteLine("Estado: " + A[cont].Estado);
            }
        }
        public void MostrarMenores18Total(Contato[] A)
        {
            int cont;

            Console.WriteLine("===== Lista de Contatos =====");
            for (cont = 0; cont < Constantes.Total; cont++)
            {
               if(A[cont].Idade < 18)
               {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Email: " + A[cont].Email);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Número: " + A[cont].Numero);
                    Console.WriteLine("Telefone: " + A[cont].Telefone);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                    Console.WriteLine("Observações: " + A[cont].Observacoes);
                    Console.WriteLine("Idade: " + A[cont].Idade);
                }
               else
               {
               }
            }
        }

        public void MostrarMenores18Meio(Contato[] A)
        {
            int cont;

            Console.WriteLine("===== Lista de contatos menores de 18 anos =====");
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                if (A[cont].Idade < 18)
                {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                }
                else
                {
                }
            }
        }

        public void MostrarMenores12Total(Contato[] A)
        {
            int cont;

            Console.WriteLine("===== Lista de contatos menores de 12 anos =====");
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                if (A[cont].Idade < 12)
                {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Email: " + A[cont].Email);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Número: " + A[cont].Numero);
                    Console.WriteLine("Telefone: " + A[cont].Telefone);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                    Console.WriteLine("Observações: " + A[cont].Observacoes);
                    Console.WriteLine("Idade: " + A[cont].Idade);
                }
                else
                {
                }
            }
        }

        public void MostrarMenores12Meio(Contato[] A)
        {
            int cont;

            Console.WriteLine("===== Lista de contatos menores de 12 anos =====");
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                if (A[cont].Idade < 12)
                {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                }
                else
                {
                }
            }
        }

        public void MostrarContatoNovoTotal(Contato[] A)
        {
            int cont, pos = 0;
            Console.WriteLine("===== Contato mais novo =====");
            Console.WriteLine();
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                if(A[cont].Idade < A[pos].Idade )
                {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Email: " + A[cont].Email);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Número: " + A[cont].Numero);
                    Console.WriteLine("Telefone: " + A[cont].Telefone);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                    Console.WriteLine("Observações: " + A[cont].Observacoes);
                    Console.WriteLine("Idade: " + A[cont].Idade);
                }
                else
                {
                }
            }
        }

        public void MostrarContatoNovoMeio(Contato[] A)
        {
            int cont, pos = 0;
            Console.WriteLine("===== Contato mais novo =====");
            Console.WriteLine();
            for (cont = 0; cont < Constantes.Total; cont++)
            {
                if (A[cont].Idade < A[pos].Idade)
                {
                    Console.WriteLine("Nome: " + A[cont].Nome);
                    Console.WriteLine("Endereço: " + A[cont].Endereco);
                    Console.WriteLine("Cidade: " + A[cont].Cidade);
                    Console.WriteLine("Estado: " + A[cont].Estado);
                }
                else
                {
                }
            }
        }
    }

    class Lobby
    {
        private int num1, num2;
        public int Menu(Contato[] A)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("======== Bem vindo ao Menu ========");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("======== Escolha o que deseja visualizar ? ========");
                Console.WriteLine("");
                Console.WriteLine("Digite 1 para ver todos os contatos cadastrados");
                Console.WriteLine("Digite 2 para ver pessoas menores que 18 anos");
                Console.WriteLine("Digite 3 para ver pessoas menores que 12 anos");
                Console.WriteLine("Digite 4 para ver o contato mais novo ");
                Console.WriteLine("Digite 5 para sair ");
                this.num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("====================================================");
                switch(num1)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Como deseja visualizar os contatos ?");
                        Console.WriteLine();
                        Console.WriteLine("Digite 1 para visualizar total");
                        Console.WriteLine("Digite 2 para visualizar parcial");
                        Console.WriteLine();
                        this.num2 = Int32.Parse(Console.ReadLine());
                        switch(num2)
                        {
                            case 1:
                                Console.Clear();
                                Contato[] Lista1 = new Contato[Constantes.Total];
                                Agenda Agb = new Agenda();
                                Agb.MostrarAgendaTotal(Lista1);
                                break;
                            case 2:
                                Console.Clear();
                                Contato[] Lista2 = new Contato[Constantes.Total];
                                Agenda Aga = new Agenda();
                                Aga.MostrarAgendaMeio(Lista2);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Codigo invalido!");
                                return 1;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Como deseja visualizar os contatos ?");
                        Console.WriteLine();
                        Console.WriteLine("Digite 1 para visualizar total");
                        Console.WriteLine("Digite 2 para visualizar parcial");
                        Console.WriteLine();
                        this.num2 = Int32.Parse(Console.ReadLine());
                        switch (num2)
                        {
                            case 1:
                                Console.Clear();
                                Contato[] Lista1 = new Contato[Constantes.Total];
                                Agenda Agb = new Agenda();
                                Agb.MostrarMenores18Total(Lista1);
                                break;
                            case 2:
                                Console.Clear();
                                Contato[] Lista2 = new Contato[Constantes.Total];
                                Agenda Aga = new Agenda();
                                Aga.MostrarMenores18Meio(Lista2);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Codigo invalido!");
                                return 1;
                               
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Como deseja visualizar os contatos ?");
                        Console.WriteLine();
                        Console.WriteLine("Digite 1 para visualizar total");
                        Console.WriteLine("Digite 2 para visualizar parcial");
                        Console.WriteLine();
                        this.num2 = Int32.Parse(Console.ReadLine());
                        switch (num2)
                        {
                            case 1:
                                Console.Clear();
                                Contato[] Lista1 = new Contato[Constantes.Total];
                                Agenda Agb = new Agenda();
                                Agb.MostrarMenores12Total(Lista1);
                                break;
                            case 2:
                                Console.Clear();
                                Contato[] Lista2 = new Contato[Constantes.Total];
                                Agenda Aga = new Agenda();
                                Aga.MostrarMenores12Meio(Lista2);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Codigo invalido!");
                                return 1;
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Como deseja visualizar os contatos ?");
                        Console.WriteLine();
                        Console.WriteLine("Digite 1 para visualizar total");
                        Console.WriteLine("Digite 2 para visualizar parcial");
                        Console.WriteLine();
                        this.num2 = Int32.Parse(Console.ReadLine());
                        switch (num2)
                        {
                            case 1:
                                Console.Clear();
                                Contato[] Lista1 = new Contato[Constantes.Total];
                                Agenda Agb = new Agenda();
                                Agb.MostrarContatoNovoTotal(Lista1);
                                break;
                            case 2:
                                Console.Clear();
                                Contato[] Lista2 = new Contato[Constantes.Total];
                                Agenda Aga = new Agenda();
                                Aga.MostrarContatoNovoMeio(Lista2);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Codigo invalido!");
                                return 1;
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Fechando o programa...");
                        Console.WriteLine();
                        return 0;
                    default:
                        Console.Clear();
                        Console.WriteLine("Código invalido!");
                        return 1;
                }
            }
        }
    }
    
        
    
    class Program
    {
        static void Main(string[] args)
        {
            Contato[] Lista = new Contato[Constantes.Total];

            Agenda Ag = new Agenda();
            Lobby Lb = new Lobby();

      
            Ag.Inicializa(Lista);
            Ag.LerAgenda(Lista);
            Lb.Menu(Lista);
        }
    }
}
