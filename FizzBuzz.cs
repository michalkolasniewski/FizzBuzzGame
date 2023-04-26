using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public string ShowResult(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return $"FizzBuzz";

            else if (number % 5 == 0) return $"Buzz";
            
            else if (number % 3 == 0) return $"Fizz";

            return $"Podana liczba: {number}";
        }
    }
}
