using System;

namespace LeapYear {

    // Class for input handling
  public class InputHandler
  {
    // Returns input as string
    public int GetInputAsInt()
    {
      // Read input string
      string input = Console.ReadLine();

      try {
        // Attempt to convert string to int  
        return Convert.ToInt32(input);
      } catch(Exception) {
        Console.WriteLine("A number was expected. Please try again:");
        // If not an int, recursively try again
        return this.GetInputAsInt();
      }
    }

  }


}