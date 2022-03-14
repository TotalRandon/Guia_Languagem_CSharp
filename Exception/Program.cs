using System;

namespace focac
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int A;

            while(true)
            {
                try
                {
                    Console.WriteLine("Digite um numero");
                    A = int.Parse(Console.ReadLine());
                    return;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite apenas numeros inteiros!");
                    Console.WriteLine("");
                }
            }
        }
    }
}
