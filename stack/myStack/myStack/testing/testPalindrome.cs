using System;
using Xunit;

public class PalindromeTests
{
    [Fact]
    public void TestIsPalindrome()
    {
        // Arrange
        string palindrome = "rentner";
        string nonPalindrome = "hello";

        // Act
        bool isPalindrome1 = IsPalindrome(palindrome);
        bool isPalindrome2 = IsPalindrome(nonPalindrome);

        // Assert
        Assert.True(isPalindrome1);
        Assert.False(isPalindrome2);
    }
}
