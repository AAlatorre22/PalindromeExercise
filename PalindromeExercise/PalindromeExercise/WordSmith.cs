using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {


        public bool IsAPalindrome(string palin)
        {
            if ((palin == null) || (palin.Length == 0))
            {
                return false;
            }

            var reversedStr = new string(palin.ToCharArray().Reverse().ToArray());

            if (reversedStr == palin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }






    }
}
