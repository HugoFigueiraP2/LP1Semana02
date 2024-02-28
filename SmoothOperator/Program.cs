using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insire número inteiro não-negativo: ");
            byte n = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"{--n}");
            Console.WriteLine($"{++n}");
            
        }
    }
}
