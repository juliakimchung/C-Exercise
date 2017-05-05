using System;
namespace FitnessFrog
{
  class Program
  {
      static void Main()
        
      {
        var runningTotal = 0.0;
        
        
        while(true)
        {
        
            // Prompt user for minutes exercised 
            Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
            var entry = Console.ReadLine();
            if (entry.ToLower() =="quit")
            {
              break;
            }
            
            try
            {
                var minutes = double.Parse(entry);
                if (minutes <= 0)
                {
                  Console.WriteLine(minutes + " Is not a valid number");
                  continue;
                }
                else if(minutes <= 10)
                {
                  Console.WriteLine("Better than nothing, am I right?");
                }
                else if (minutes <= 30)
                {
                  Console.WriteLine("Way to go hot stuff!");
                  
                }
                else if (minutes <= 40)
                {
                  Console.WriteLine("You must be a ninja!");
                }
                else if (minutes <= 60)
                {
                  Console.WriteLine("You rock!");
                }
                else 
                {
                  Console.WriteLine("OK Now you are just shoing off!");
                }
            
    
                runningTotal += minutes;
                
                  // Add minutes exercised to total 
                
                  // Display total minutes exercised to the screen 
                Console.WriteLine("You've entered " + runningTotal  + "minutes");
              } 
              // Repeat until user quits 
              
                
         
                
	          catch(FormatException)
	          {
	            Console.WriteLine("That is not valid input");
	            continue;
	          }
          }
          
          Console.WriteLine("Goodbye");
      }
  }
}
 