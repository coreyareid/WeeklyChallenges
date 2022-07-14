using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z');
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double min = 0;
            double max = 10;
            foreach (double num in numbers.ToList())
            {
                if (num > min)
                {
                    min = num;
                }
                if (num < max)
                {
                    max = num;
                }
            }
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers == null ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = Sum(numbers.ToArray());
            return sum % 2 == 0 ? false : true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int countOdds = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    countOdds++;
                }
            }
             return countOdds;
        }
    }
}
