using System;
using Xunit;

namespace LeapYear.Tests
{
  public class LeapYearHelperTest
  {
    [Theory]
    [InlineData(1584)]
    [InlineData(1588)]
    [InlineData(1592)]
    public void LeapYearIfDivisibleByFour(int year)
    {
      // Arrange
      LeapYearHelper helper = new LeapYearHelper();

      // Act
      bool isLeapYear = helper.IsLeapYear(year);

      // Assert
      Assert.True(isLeapYear, "Expected value to be a leap year");
    }

    [Theory]
    [InlineData(1585)]
    [InlineData(1586)]
    [InlineData(1597)]
    public void FailsIfNotDivisibleByFour(int year)
    {
      // Arrange
      LeapYearHelper helper = new LeapYearHelper();

      // Act
      bool isLeapYear = helper.IsLeapYear(year);

      // Assert
      Assert.False(isLeapYear, "Expected value not to be a leap year");
    }

    [Theory]
    [InlineData(1700)]
    [InlineData(1800)]
    [InlineData(1900)]
    public void FailsIfDivisibleBy100(int year)
    {
      // Arrange
      LeapYearHelper helper = new LeapYearHelper();

      // Act
      bool isLeapYear = helper.IsLeapYear(year);

      // Assert
      Assert.False(isLeapYear, "Expected value not to be a leap year, since it is divisible by 100");
    }

    [Theory]
    [InlineData(1600)]
    [InlineData(2000)]
    [InlineData(2400)]
    public void LeapYearIfDivisibleBy400(int year)
    {
      // Arrange
      LeapYearHelper helper = new LeapYearHelper();

      // Act
      bool isLeapYear = helper.IsLeapYear(year);

      // Assert
      Assert.True(isLeapYear, "Expected value to be a leap year since it is divisible by 400");
    }

    [Theory]
    [InlineData(-5254)]
    [InlineData(-27)]
    [InlineData(254)]
    [InlineData(1200)]
    [InlineData(1581)]
    public void ThrowsErrorIfBelow1582(int year)
    {
      // Arrange
      LeapYearHelper helper = new LeapYearHelper();

      // Act & Assert
      Assert.Throws<InvalidLeapYearException>(() => helper.IsLeapYear(year));
    }
  }
}
