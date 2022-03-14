using System;

namespace Q10.exessoes
{
    class ExcecaoAcimaDeCem : Exception
    {
        public void Excecao()
        {
            Console.WriteLine("O valor da soma nao valem 100");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            float a, box = 0;

            while(true)
            {
                try
                {
                    Console.WriteLine("Digite 5 numeros para somar ate 100");
                    for(int i = 0; i < 5; i++)
                    {
                        a = float.Parse(Console.ReadLine());
                        box = box + a;
                    }
                    if(box != 100) {  } else { return; }
                }

                catch(ExcecaoAcimaDeCem)
                {
                    throw;
                }
            }
        }
    }
}
