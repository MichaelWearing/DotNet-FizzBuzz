using System;

namespace FizzBuzzer
{
    public class Single
    {
        public string FizzThis(int number)
        {
            if (isFizzBuzz(number))
            {
                return "FizzBuzz";
            }
            else if (IsFizz(number))
            {
                return "Fizz";
            }
            else if (IsBuzz(number))
            {
                return "Buzz";
            }
            return number.ToString();
        }

        private static bool isFizzBuzz(int number) => number % 3 == 0 && number % 5 == 0;

        private static bool IsBuzz(int number) => number % 5 == 0;

        private static bool IsFizz(int number) => number % 3 == 0;
    }
}
