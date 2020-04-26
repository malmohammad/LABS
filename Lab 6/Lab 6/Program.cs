using System;

namespace Lab_6
{
    class Program
    {
        public static void Main(string[] args)
        
            
        {
            Console.WriteLine("Welcome to Grand Circus dice game!");
            do
            {

                int size;

                do
                {
                    Console.WriteLine("What size die would you like to roll?");
                } while (!int.TryParse(Console.ReadLine(), out size));

                Console.WriteLine("Die Rolled: " + Randomizer(size) + " and " + Randomizer(size));

                Console.WriteLine("Would you like to roll the die again?");
            } while (Console.ReadLine().ToLower() == "y");
                

        }    

        public static int Randomizer(int size)
        {
            var random = new Random();
            return random.Next(1, size + 1);
        }
        
    }
}
