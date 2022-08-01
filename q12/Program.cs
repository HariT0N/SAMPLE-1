using System;

namespace q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = GetInt(" Enter a number :");
            PrintMessage(N.ToString());

            System.Console.WriteLine(N >= 0?(N==0?"zero":"Positive"):"Negative");


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
