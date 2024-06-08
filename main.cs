using System;

 class Program {
   
   const double baserate = 200;
   const double hour = 150;
   const double mile = 2;
   
  public static void Main (string[] args) {
    
    Console.WriteLine("Enter Number of Hours Worked:");
    String hours = Console.ReadLine();
    Console.WriteLine("Enter Number of Miles:");
    String miles = Console.ReadLine();
    double total = (baserate)+ (hour * double.Parse(hours)) + (mile * double.Parse(miles));
     Console.WriteLine("Total: " + total.ToString("c"));
    }
}