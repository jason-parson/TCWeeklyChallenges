using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Markup;

namespace WeeklyChallenges
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
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

            var sum = numbers.Sum();

            if (sum % 2 != 0)
            {
                return true;

            }          
            else
            {
                return sum % 2 != 0;
            }
        


            //if (numbers == null)
            //{
            //    return false;
            //}
            //if (numbers.Count() == 0)
            //{

            //    return false;
            //}
            //var sum = numbers.Sum();
            //return (sum % 2 != 0);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
                var upperCase = false;
                var lowerCase = false;
                var isNumber = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsLower(password[i]))
                    {
                        lowerCase = true;
                    }

                    if (char.IsUpper(password[i]))
                    {
                        upperCase = true;
                    }
                    if (char.IsNumber(password[i]))
                    {
                        isNumber = true;
                    }
                if (upperCase == true && lowerCase && isNumber) 
                {
                    return true; 
                }
                }
            return false;

        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            var division = dividend / divisor;

            return division;





        }

        public int LastMinusFirst(int[] nums)
        {
            var subtract = nums.Last() - nums.First();

            return subtract;
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
            {
                 words[i] = words[i].ToUpper();

            }
        }
        }
    }

