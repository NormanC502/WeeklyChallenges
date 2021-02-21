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
            var i = vals.Length;
                if (i % 2 == 0)
                    return true;
                else
                    return false;

        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null) 
            {
                return 0;
            }
            double minimum = 0;
            double maximum = 0;
            double sum = 0;
            foreach (double num in numbers) 
            {
                minimum = numbers.Min();
                maximum = numbers.Max();
                sum = minimum + maximum;
            }
            return sum;
            
        }   

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length) 
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
            //int sum = numbers.Sum(); using Sum method instead of numbers.Length value adding with iteration throung collection
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {                
                if (numbers[i] % 2 == 0)
                {
                     sum += numbers[i];
                    
                }
                    
            }
            return sum;

            // return numbers.Where(x => x % 2 == 0).Sum(); using Ling with Where numbers are divisible by 2 and Sum method.
        }
        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);    // returns true statement if numbers not divisble by 2        
        }           
          
        

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else 
            {
                return number / 2;
            }
        }
    }
}
