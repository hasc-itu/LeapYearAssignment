using System;

namespace LeapYear
{
  public class LeapYearHelper
  {
    public bool IsLeapYear(int year)
    {
      // Rules are:
      // year cannot be below 1582 
      // year has to be divisible by and not divisible by 100, except when it is divisible by 400
      if (year < 1582) throw new InvalidLeapYearException("Leap year cannot be below 1582");
      return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0); 
    }
  }


  public class InvalidLeapYearException : Exception
  {
    public InvalidLeapYearException(string message) : base(message) {}
  }
}
