using System;

namespace DevChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int number=1; number<101; number++)
            {
                string printable = "{0} ";

                if (number % 3 == 0) { printable += "Fizz "; }
                if (number % 5 == 0) { printable += "Buzz "; }

                printable = printable.Remove(printable.Length - 1);

                Console.WriteLine(printable, number);
            }

            Console.ReadKey();
        }
    }
}
