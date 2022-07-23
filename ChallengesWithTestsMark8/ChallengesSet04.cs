using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens += numbers[i];
                }
                if (numbers[i] % 2 != 0)
                {
                    evens -= numbers[i];
                }
            }

            return evens;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {

            List<string> strList = new List<string>();
            strList.Add(str1);
            strList.Add(str2);
            strList.Add(str3);
            strList.Add(str4);
            int strLength = str1.Length;
            for (int i = 0; i < strList.Count; i++)
            {
                if (strLength > strList[i].Length)
                {
                    strLength = strList[i].Length;
                }
            }
            return strLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numberList = new List<int>();
            numberList.Add(number1);
            numberList.Add(number2);
            numberList.Add(number3);
            numberList.Add(number4);
            return numberList.AsQueryable().Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength1 + sideLength3 > sideLength3;
        }

        public bool IsStringANumber(string input)
        {
            double num = 0;
            return double.TryParse(input, out num);
            
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var objects = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if(objs[i] == null)
                {
                    objects++;
                }
            }
            return objects > (objs.Length / 2) ? true : false;
        }

        public double AverageEvens(int[] numbers)
        {
            List<int> evenNums = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNums.Add(number);
                }
            }
            if (numbers == null || evenNums == null)
            {
                return 0;
            }

            if (evenNums.Count == 0)
            {
                return 0;
            }
            return evenNums.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                number = 1;
            }

            for (int i = number - 1; i >= 1; i--)
            {
                if (i > 0)
                {
                    i = Math.Abs(i);
                }
                number *= i;
            }
            return number;
        }
    }
}
