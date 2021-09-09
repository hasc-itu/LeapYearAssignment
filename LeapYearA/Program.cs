using System;

namespace LeapYear
{
  class Program {

    public static void Main(string[] args)
    {
      Console.WriteLine("Enter a year to check if it is a leap year:");
      
      string yearStr = Console.ReadLine();
      int year = Convert.ToInt32(yearStr);

      LeapYearHelper helper = new LeapYearHelper();
      
      Console.WriteLine(helper.IsLeapYear(year) ? "yay" : "nay");
      
    }

  }
}