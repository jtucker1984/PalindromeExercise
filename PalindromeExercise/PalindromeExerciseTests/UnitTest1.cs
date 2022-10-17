using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("cop",false)]
       
        public void PalindromeTest1(string word,bool expected)
        {
            var wordSmith = new Wordsmith();
            var actual = wordSmith.IsAPalindrome(word);
            Assert.Equal(expected, actual);

        }
    }
}
