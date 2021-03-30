using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myAge = 43;
            Console.WriteLine("Hello there!  My name is Pedrito.  What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hi, " + name + ". What is your age?");
            string age = Console.ReadLine();
            int ageNum = Int32.Parse(age);
            if (ageNum > myAge)
            {
                Console.WriteLine(name + ", you are older than me");
            }
            else
            {
                Console.WriteLine("You are younger than me, " + name);
            }

            var today = DateTime.Today;
            Console.WriteLine("Today is " + today.ToString("dd/MM/yy"));
            int year = today.Year;
            Console.WriteLine("In what year were you born?");
            string birthYear = Console.ReadLine();
            int birthYearNum = Int32.Parse(birthYear);
            int currentAge = year - birthYearNum;
            Console.WriteLine("You are " + currentAge + " years old.");

            Console.WriteLine("Let's play a little game.  I will tell you which number is the highest.");
            Console.WriteLine("Give me the first number: ");
            string firstNumber = Console.ReadLine();
            Console.WriteLine("Give me the second number:");
            string secondNumber = Console.ReadLine();
            int num1 = Int32.Parse(firstNumber);
            int num2 = Int32.Parse(secondNumber);
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is the greatest number");
            }
            else if (num2 > num1)

            {
                Console.WriteLine(num2 + " is the greatest number");
            }
            else
            {
                Console.WriteLine("You have entered the same number twice!");
            }






        }
    }
}
