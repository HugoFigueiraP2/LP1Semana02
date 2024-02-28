using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduz a altura do cilindro: ");
            float altura_user = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Introduz o raio do cilindro: ");
            float raio_user = Convert.ToSingle(Console.ReadLine());

            float volume = MathF.PI * MathF.Pow(raio_user, 2) * altura_user;
            float Area_Superficie = 2 * MathF.PI * raio_user * (raio_user + altura_user);

            Console.WriteLine($"O Volume é {volume} e a Area de superficie é {Area_Superficie}!");

        }
    }
}
