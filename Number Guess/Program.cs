using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int Value = random.Next(1, 100);

            int Guess = 0;

            Console.WriteLine("Guess a number between 1-100.");

            while (Guess != Value)
            {
                Guess = int.Parse(Console.ReadLine());

                if (Guess < Value)
                {
                    Console.WriteLine("No, the number is higher than " + Guess + ".");
                }
                else if (Guess > Value)
                {
                    Console.WriteLine("No, the number is lower than " + Guess + ".");
                }

            }

            Console.WriteLine("Well done! The answer was " + Value);
            Console.ReadLine();
        }
    }
}
