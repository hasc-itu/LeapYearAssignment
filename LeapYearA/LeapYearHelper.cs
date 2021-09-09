using System;

namespace LeapYear
{
  public class LeapYearHelper
  {
    public bool IsLeapYear(int year)
    {
      this.ThrowIfInvalidYear(year);
      // Rules are:
      // "year" has to be divisible by and not divisible by 100, except when it is divisible by 400 
      return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0); 
    }

    public void ThrowIfInvalidYear(int year)
    {
      if (year < 1582) throw new InvalidLeapYearException("Leap year cannot be below 1582");
    }
  }


  public class InvalidLeapYearException : Exception
  {
    public InvalidLeapYearException(string message) : base(message) {}
  }
}
