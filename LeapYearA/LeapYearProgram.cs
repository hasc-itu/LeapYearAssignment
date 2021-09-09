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

      // Get description from input
      string description = this.GetDescriptionFromInput();

      Console.WriteLine(description);
    }

    public string GetDescriptionFromInput() {
      int year = this.inputHandler.GetInputAsInt();

      try {
        
        return this.GetDescriptionFromYear(year);

      } catch(InvalidLeapYearException exception) {
        Console.WriteLine("Invalid year: " + exception.Message);
        Console.WriteLine("Please try again:");
        return this.GetDescriptionFromInput();
      }
    }

    // Returns respective string if leap year or not
    public string GetDescriptionFromYear(int year) {
      return this.leapYearHelper.IsLeapYear(year) ? "yay" : "nay";
    }

  }

}