using System;
using PierresBakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("We offer Fresh Baked Bread and our Cinnamon Pastry. For our Fresh Baked Bread, there is currently on sale for $5 each and we have a special of buy 2 get 1 free. Our Cinnamon Pastry is $2 each and are Buy 3 get 1 free.");
      Console.WriteLine("How many of our Fresh Baked Bread would you like?");
      string orderBread = Console.ReadLine();  
      Console.WriteLine("How many of our Cinnamon Pastry would you like?");
      string orderPastry = Console.ReadLine();  
      int numberBread = int.Parse(orderBread);  
      int numberPastry = int.Parse(orderPastry);  
      TotalPrice recieve = new TotalPrice(numberBread, numberPastry);
      Console.WriteLine("Your order of " + numberBread + " Fresh Baked Bread and " + numberPastry + " Cinnamon Pastyhas been recieved.");
      ConfirmOrder(order);

    }

    // static void ConfirmOrEditTriangle(Triangle tri)
    // {
    //   Console.WriteLine("Please confirm that you entered in your triangle correctly:");
    //   Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
    //   Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
    //   Console.WriteLine($"Side 3 has a length of {tri.GetSide3()}.");
    //   Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
    //   string userInput = Console.ReadLine();  
    //   if (userInput == "yes")
    //   {
    //     CheckTriangleType(tri);
    //   }
    //   else
    //   {
    //     Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
    //     Console.WriteLine("Please enter a number:");
    //     string stringNumber1 = Console.ReadLine();  
    //     Console.WriteLine("Enter another number:");
    //     string stringNumber2 = Console.ReadLine();  
    //     Console.WriteLine("Enter a third number:");
    //     string stringNumber3 = Console.ReadLine();  
    //     tri.Side1 = int.Parse(stringNumber1);  
    //     tri.Side2 = int.Parse(stringNumber2);  
    //     tri.SetSide3(int.Parse(stringNumber3)); 
    //     ConfirmOrEditTriangle(tri);
    //   }
    // }

    // static void CheckTriangleType(Triangle tri)
    // {
    //   string result = tri.CheckType();
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("Your result is: " + result + ".");
    //   Console.WriteLine("-----------------------------------------");
    //   Console.WriteLine("What's next?");
    //   Console.WriteLine("Would you like to check a new triangle (new)?");
    //   Console.WriteLine("Please enter 'new' to check the type of a new triangle. To exit, enter any key.");
    //   string userResponse = Console.ReadLine(); 
    //   if (userResponse == "new" || userResponse == "New")
    //   {
    //     Main();
    //   }
    //   else
    //   {
    //     Console.WriteLine("Goodbye!");
    //   }
    // }
  }
}