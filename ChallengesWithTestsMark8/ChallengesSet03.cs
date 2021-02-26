using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool item in vals) // iterate through array
            {
                if (!item) return true;  // if item is false return true
            }
            return false; 
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false; bool hasLower = false; bool hasDigit = false;
            for (int i = 0; i < password.Length && !(hasUpper && hasLower && hasDigit); i++)
            {
                char c = password[i];
                if (!hasUpper) hasUpper = char.IsUpper(c);
                if (!hasLower) hasLower = char.IsLower(c);
                if (!hasDigit) hasDigit = char.IsDigit(c);
            }
            return hasUpper && hasLower && hasDigit;




        } 

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {                     
            
            try {
                return (dividend / divisor);
            }
            catch (DivideByZeroException) 
            {
                return 0;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length -1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0) 
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
                words[i] = words[i].ToUpper();
        }
    }
}
