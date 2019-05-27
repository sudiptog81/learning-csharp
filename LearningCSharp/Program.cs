using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int    : {0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Byte   : {0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Float  : {0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Decimal: {0} {1}", decimal.MinValue, decimal.MaxValue);

            Console.ReadKey();
        }
    }
}
