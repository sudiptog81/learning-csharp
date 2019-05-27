using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of the circle: ");

            const float Pi = 3.14f;
            int Radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Area: {Pi * (Radius * Radius)}");

            Console.ReadKey();
        }
    }
}
