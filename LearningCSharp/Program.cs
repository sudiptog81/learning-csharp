using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // No Casting Reqired
                byte b = 1;
                int i = b;
                Console.WriteLine(i);
            }

            {
                // Casting Int32 to Byte
                int i = 1;
                byte b = (byte)i;
                Console.WriteLine(b);
            }

            {
                // Overflow causes data loss
                int i = 1000;
                byte b = (byte)i;
                Console.WriteLine(b);
            }

            {
                string number = "1234";
                // Cannot Cast Non-Compatible Types
                // int i = (int)number;
                int i = Convert.ToInt32(number);
                Console.WriteLine(i);
            }

            {
                // Handling Exceptions
                try
                {
                    Console.WriteLine("Enter a number:");
                    string number = Console.ReadLine();
                    byte b = Convert.ToByte(number);
                    Console.WriteLine(b);
                }
                catch (Exception)
                {
                    Console.WriteLine("String could not be converted to a byte :(");
                }

                try
                {
                    Console.WriteLine("Enter a boolean:");
                    string boolean = Console.ReadLine();
                    bool b = Convert.ToBoolean(boolean);
                    Console.WriteLine(b);
                }
                catch (Exception)
                {
                    Console.WriteLine("String could not be converted to a bool :(");
                }
            }

            Console.ReadKey();
        }
    }
}
