using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there!  What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine(name + ", your age is " + age);


        }
    }
}
