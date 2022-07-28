using System;

namespace q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age = GetInt(" Enter Age :");
            PrintMessage(Age.ToString());

            if (Age >= 18)
            { Console.WriteLine(" The Candidate is eligible to vote"); }
            else
            { Console.WriteLine(" The Candidate is not eligible to vote"); }
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
