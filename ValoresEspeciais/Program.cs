using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            uint i = uint.MaxValue;
            Console.WriteLine(i + 1);

            float x = 2 * float.MaxValue;
            float y = float.MaxValue + 1;
            Console.WriteLine(x);
            Console.WriteLine(y);

            

            float smallValue = 1e-38f;
            float result = smallValue / 1e20f;
            Console.WriteLine(result); 

            
            
        }
    }
}
