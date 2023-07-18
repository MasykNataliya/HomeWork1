using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
              bool result;
               result = (number % 2 == 0);
            return result;
        } 
            

        /* TODO: Receives a string as input and returns true if the string contains only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            int New = input.Distinct().Count();
            int New1= input.Length;
            if ( New1==New)

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* TODO: Receives an integer as input and returns true if the number is divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if (number % (5 * 7) == 0 && number != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /* TODO: Performs the specified arithmetic operation (char input paramether) on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            double result=0.0;
            switch (operation)
            {
                case '-':
                   result=( number1 - number2);
                   
                   break;
                case '+':
                   result = (number1 + number2);
                      break;
                case '*':
                    result =  (number1 * number2);
                    
                    break;
                case '/':
                    result = (number1 / number2); 
                        break;
                default:
                    Console.WriteLine("No such operation un the list");
                    break;
            }
            return result;
        }

        /* TODO: Receives an integer as input and returns "Positive" if the number is positive, "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if(number < 0) return "Negative";
                   
              else if (number > 0) return "Positive";
                  else  return "Zero";
                   
           
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome, false otherwise. */
        public static bool IsPalindrome(string input)
        {
            string input2 = new string(input.Reverse().ToArray());
        if (input == input2) return true;
        else return false;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year, false otherwise. */
        public static bool IsLeapYear(int year)
        {
        bool result;
            result = ((year % 4 == 0&& year % 100 != 0)|| (year % 400 == 0 ));
            return result;
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, false otherwise. */
        public static bool IsVowel(char character)
        {
            string character1 = character.ToString().ToLower();
            if (character1 == "a" || character1 == "e" || character1 == "i" || character1 == "o" || character1 == "u")
                return true;
            else
                return false;
                }

       

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)

        { int QuantityOfIndexes = binaryNumber.Length;
            string revBinaryNumber = new string (binaryNumber.Reverse().ToArray());
            int result=0;
            for (int i = QuantityOfIndexes; i >=0; i--) 
            { double DoubleIndex = Double.Parse(revBinaryNumber.Substring(QuantityOfIndexes - i, 1));
                double inPow;
                if (DoubleIndex > 0)
                { inPow = Math.Pow(2, Convert.ToDouble(QuantityOfIndexes - i)); }
                else inPow =0.0;
                result  += Convert.ToInt32(inPow);
              
            }
            return result;  }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            throw new NotImplementedException();
        }

        //Convert.ToInt32(bin_strng, 2)
    
    
    
    }
}
