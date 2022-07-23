using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 1; i <numbers.Length; i++)
            {
                if (numbers[i -1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> fourthNums = new List<double>();
            double[] myArr = new double[] { };
            if (elements == null)
            {
                return myArr;
            }
            for (int i =3; i < elements.Count; i += 4)
            {
                fourthNums.Add(elements[i]);
            }
            return fourthNums.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i +1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
