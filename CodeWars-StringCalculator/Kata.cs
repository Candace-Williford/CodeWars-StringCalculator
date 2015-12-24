using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_StringCalculator
{
    public static class Kata
    {
        public static int AddStrings(string numbers)
        {
            int total = 0;

            string[] parsedNumbers = numbers.Split(',');

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                total += Int32.Parse(parsedNumbers[i]);
            }

            return total;
        }
    }
}

//You start work at a new company that receives data monthly in a feed. The feed is 
//fairly old and all of the data comes through as a string.

//You are required to create a function that sums the list of comma seperated 
//numbers that arrive in a string and return the result as an int:

//AddStrings("12, 5, 3");  //should return: 20

//The string passed into your function will only contain numbers in string format 
//and can contain any number of comma seperated integers.
