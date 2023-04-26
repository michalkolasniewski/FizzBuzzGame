using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizz = new FizzBuzz();

            Console.WriteLine("\nZagrajmy!");
            Console.WriteLine("\nProszę, podaj dowolną liczbę.");
            
            while (true)
            {
                var userNumber = GetNumber();
                Console.WriteLine(fizz.ShowResult(userNumber));
                Console.WriteLine("\nPodaj kolejną liczbę. Jeżeli chcesz wyjść, to wpisz \"K\" ");
            }
        }

        private static int GetNumber()
        {

            while (true)
            {
                var value = Console.ReadLine();
                if (value.ToUpper() == "K")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(value, out int number))
                {
                    Console.WriteLine("Podaj prawidłową liczbę");
                    continue;
                }
                return number;
            }
        }
    }
}
