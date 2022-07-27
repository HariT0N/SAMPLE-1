using System;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
             int X = GetInt(" Enter an Integer :");
            PrintMessage(X.ToString());
            if (X > 0)
            { 
                Console.WriteLine(" Positive");
                 }
            else if (X == 0)
            { 
                Console.WriteLine(" Zero "); 
                }
            else
            { 
                Console.WriteLine(" Negative");
                 }
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
