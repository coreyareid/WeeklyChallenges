using System;
using System.Collections.Generic;
using System.Linq;
namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if(vals[i] != true)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            bool oddNums = false;

            foreach (var num in numbers)
            {
                sum += num;
            }
            if (sum % 2 != 0)
            {
                oddNums = true;
            }

            return oddNums;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber) ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            var firstLetter = val[0];
            return firstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            var lastLetter = val[val.Length - 1];
            return lastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            var divided = dividend / divisor;
            return divided;
        }

        public int LastMinusFirst(int[] nums)
        {
            var minusFirst = nums[nums.Length - 1] - nums[0];
            return minusFirst;
        }

        public int[] GetOddsBelow100()
        {
            List<int> myList = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    myList.Add(i);
                }
            }
            int[] myArray = new int[myList.Count];
            for (int x = 0; x < myList.Count; x++)
            {
                myArray[x] = myList[x];
            }

            return myArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
