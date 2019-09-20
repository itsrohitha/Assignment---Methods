using System;

namespace Class_Project___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser ();
            Console.ReadKey();
            
        }

        public static void GreetUser()
        {
            Console.WriteLine("Please enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input + "!");
        }
    }
}
