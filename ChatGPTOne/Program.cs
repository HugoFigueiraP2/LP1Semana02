using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question;
            while (true)
            {
                Console.Write("Place your question:");
                question = Console.ReadLine();

                if (question == "In which galaxy do we live?")
                {
                    Console.WriteLine("Via lactea");
                    continue;
                }
                else if (question == "How many constellations exists?")
                {
                    Console.WriteLine("There are 88 constellations officially recognized by the IAU");
                }

                





            }






        }
    }
}
