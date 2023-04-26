using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    public class FizzBuzz
    {
        public int number { get; set; }

        public string ShowResult(int number)
        {
            if (number % 3 == 0)
            {
                return $"Fizz";
            }
            return $"test";
        }
    }
}
