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
                    continue;
                }
                else if (question == "Which is the temperature of the Moon?")
                {
                    Console.WriteLine("During the day, the temperature on the Moon can reach up to 127 degrees Celsius.");
                    Console.WriteLine("During the night, it can drop to around -173 degrees Celsius!");
                    continue;
                }
                else if (question == "Planet Mercury as ice?")
                {
                    Console.WriteLine("Yes, there is evidence of ice on Mercury, and this was confirmed by data from the MESSENGER mission in 2012.");
                    continue;

                }
                else if(question == "EXIT")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("I don't understand...");
                }


            }






        }
    }
}
