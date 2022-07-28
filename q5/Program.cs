using System;

namespace q5
{
    class Program
    {
        static void Main(string[] args)
        {
             int Year = GetInt(" Enter a Year :");
            PrintMessage(Year.ToString());

            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            { Console.WriteLine(Year + " is a Leap Year"); }
            else
            { Console.WriteLine(Year + " is not a Leap Year"); }
        }
         
             public static int GetInt(string message)
    
          {  
            PrintMessage(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
          }
          public static void PrintMessage(string message)
          {
            Console.WriteLine(message);
          }
        
    }
}
