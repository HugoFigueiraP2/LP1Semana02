using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of shots: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int turn = 0;

            while (turn<n)
            {   
                ++turn;

                if (turn % 5 == 0 && turn % 3 == 0)
                {
                    Console.WriteLine($"{turn}: Magic Fire! Eletric Fire!");
                    continue;
                }

                else if (turn % 3 == 0)
                {
                    Console.WriteLine($"{turn}: Magic Fire! ");
                    continue;
                }

                else if (turn % 5 == 0)
                {
                    Console.WriteLine($"{turn}: Eletric Fire! ");
                    continue;
                }

                else
                {
                    Console.WriteLine($"{turn}: Normal fire :/");
                    continue;
                }


            }
        }
    }
}
