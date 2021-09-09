using System;

namespace LeapYear {

  public class LeapYearProgram
  {
    private InputHandler inputHandler;
    private LeapYearHelper leapYearHelper;

    public LeapYearProgram() {
      this.inputHandler = new InputHandler();  
      this.leapYearHelper = new LeapYearHelper();  
    }

    // Main function
    public void run()
    {

      // Start
      Console.WriteLine("Enter a year to check if it is a leap year:");

      // Get input
      int year = this.inputHandler.GetInputAsInt();

      // Get description
      string description = this.GetDescriptionFromYear(year);
      Console.WriteLine(description);
    }

    // Returns respective string if leap year or not
    public string GetDescriptionFromYear(int year) {
      return this.leapYearHelper.IsLeapYear(year) ? "yay" : "nay";
    }

  }

}