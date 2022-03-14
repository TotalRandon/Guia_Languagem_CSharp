using System;

namespace Q9.exessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            try
            {
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = i;
                } // laço para preencher o array 
                for (int i = 0; i <= x.Length; i++)
                {
                    Console.WriteLine(x[i]);
                } // laço para mostrar o array
            }
            catch(IndexOutOfRangeException)
            {
                
            }
        }
    }
}// IndexOutOfRangeException
