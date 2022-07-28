using System;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(" enter the 1st floating point: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine(" enter the 2nd floating point: ");
            float b = float.Parse(Console.ReadLine());

            if (a == b)
            { Console.WriteLine(" The given two floating points are equal"); }
            else
            { Console.WriteLine(" The given two floating points are not equal"); } 
        }
         public static float GetFloat(string message)
         {
            PrintMessage(message);
            float temp = float.Parse(Console.ReadLine());
            return temp;
        }
         public static void PrintMessage(string message)
          {
            Console.WriteLine(message);
          }
        
       
    }
}
