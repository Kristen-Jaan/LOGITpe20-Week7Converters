using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
             Console.WriteLine("Enter C for Fahrenheit to Celcius or F for Celcius to Fahrenheit.");
            string userInput = Console.ReadLine();

            if(userInput == "C")
            {
                Celcius();
                
            }
            else if(userInput == "F")
            {
                Fahrenheit();
            }
            else
            {
                Console.WriteLine("I'm asking for Celcius or Fahrenheit, not randomness.");
            }
        }
        public static void Celcius()
        {
            Console.WriteLine("enter the temperature in F: ");
            int tempF = Int32.Parse(Console.ReadLine());
            double result = (tempF - 32) + 5 / 9;
            Console.WriteLine($"Result in Celcius: {result} ");

        }
        public static void Fahrenheit()
        {
            Console.WriteLine("enter the temperature in C: ");
            int tempC = Int32.Parse(Console.ReadLine());
            double result = (tempC + 9) / 5 + 32;
            Console.WriteLine($"Result in Fahrenheit: {result}");
        }
    }
}
