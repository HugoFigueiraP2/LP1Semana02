using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Tipo int - (Minimo): {int.MinValue} || (Máximo) : {int.MaxValue}");
            Console.WriteLine($"Tipo short - (Minimo): {short.MinValue} || (Máximo) : {short.MaxValue}");
            Console.WriteLine($"Tipo long - (Minimo): {long.MinValue} || (Máximo) : {long.MaxValue}");
            Console.WriteLine($"Tipo float - (Minimo): {float.MinValue} || (Máximo) : {float.MaxValue}");
            Console.WriteLine($"Tipo float - (Infinito Positivo): {float.PositiveInfinity} || (Infinito Negativo) : {float.NegativeInfinity}");
            Console.WriteLine($"Tipo float - (NaN): {float.NaN}");
            Console.WriteLine($"Tipo double - (Minimo): {double.MinValue} || (Máximo) : {double.MaxValue}");
            Console.WriteLine($"Tipo double - (Infinito Positivo): {double.PositiveInfinity} || (Infinito Negativo) : {double.NegativeInfinity}");
            Console.WriteLine($"Tipo double - (NaN): {double.NaN}");
            Console.WriteLine($"Tipo decimal - (Minimo): {decimal.MinValue} || (Máximo) : {decimal.MaxValue}");
            
        }
    }
}
