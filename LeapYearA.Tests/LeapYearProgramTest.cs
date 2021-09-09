using System;
using Xunit;

namespace LeapYear.Tests
{
  public class LeapYearProgramTest
  {
    [Theory]
    [InlineData(1596)]
    [InlineData(1612)]
    [InlineData(1616)]
    public void ReturnsYayOnLeapYear(int year)
    {
      // Arrange
      string expected = "yay";
      LeapYearProgram prog = new LeapYearProgram();

      // Act
      string actual = prog.GetDescriptionFromYear(year);

      // Assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1617)]
    [InlineData(1635)]
    [InlineData(1719)]
    public void ReturnsNayOnNonLeapYear(int year)
    {
      // Arrange
      string expected = "nay";
      LeapYearProgram prog = new LeapYearProgram();

      // Act
      string actual = prog.GetDescriptionFromYear(year);

      // Assert
      Assert.Equal(expected, actual);
    }
  }
}