using System;

namespace q2
{
    class Program
    {
       static void Main(string[] args)
        {
           
            int x = GetInt(" Enter an Integer :");
            PrintMessage(x.ToString());


            int y = GetInt(" Enter an Integer :");
            PrintMessage(y.ToString());

            if (x == y)
            { Console.WriteLine(" The given two intergers are equal"); }
            else
            { Console.WriteLine(" The given two intergers are not equal"); }
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
