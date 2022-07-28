using System;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = GetInt(" Enter an Integer :");
            PrintMessage(i.ToString());

            if (i % 2 == 0)
            { Console.WriteLine(" The Number is Even"); }
            else
            { Console.WriteLine(" The Number is Odd"); }
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
