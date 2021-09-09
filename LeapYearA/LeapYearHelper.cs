using System;

namespace LeapYear
{
  public class LeapYearHelper
  {
    public bool IsLeapYear(int year)
    {
      // Rules are:
      // "year" has to be divisible by and not divisible by 100, except when it is divisible by 400 
      return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0); 
    }
  }
}
