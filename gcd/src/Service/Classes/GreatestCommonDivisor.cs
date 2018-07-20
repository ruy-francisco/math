using System;
using Service.Contracts;

namespace Service.Classes
{
    public class GreatestCommonDivisor : IGreatestCommonDivisor
    {
        public int GetForNIntegers(int[] numbers)
        {
            if (numbers.Length < 2)
            {
                throw new ArgumentException("You should pass at least 2 numbers.");
            }

            return 0;
        }

        public int GetForTwoIntegers(int first, int second) => 
            GetForNIntegers(new int[] { first, second });
    }
}