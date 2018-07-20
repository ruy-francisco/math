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

            var currentGcd = GetForTwoIntegers(numbers[0], numbers[1]);

            for (int i = 1; i < numbers.Length; i++)
            {
                currentGcd = GetForTwoIntegers(currentGcd, numbers[i]);
            }

            return currentGcd;
        }

        public int GetForTwoIntegers(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                throw new ArgumentException("The intergers must to be greater than 0.");
            }

            if (first >= second)
            {
                var quotient = (int)first / second;
                var remainder = (int)first % second;
                first = second;
                second = remainder;

                while (remainder > 0)
                {
                    quotient = (int)first / second;
                    remainder = (int)first % second;
                    first = second;
                    second = remainder;
                }

                return first;
            }

            return GetForTwoIntegers(second, first);
        }
    }
}