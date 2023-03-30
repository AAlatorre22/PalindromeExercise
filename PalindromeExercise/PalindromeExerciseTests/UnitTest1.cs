using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("madam", true)]
        [InlineData("radar", true)]
        [InlineData(null, false)]
        [InlineData("", false)]
        public void Test1(string input, bool expected)
        {
            //Arrange
            var palindrome = new WordSmith(); 
            //Act
            var actual = palindrome.IsAPalindrome(input);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
