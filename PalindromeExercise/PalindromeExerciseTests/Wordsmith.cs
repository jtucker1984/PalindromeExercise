using System;
namespace PalindromeExerciseTests
{
    public  class Wordsmith
    {
        public bool IsAPalindrome(string myString)
        {
            int length = myString.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (myString[i] != myString[length - i - 1])
                    return false;
            }
            return true;
        }



    }
}
  