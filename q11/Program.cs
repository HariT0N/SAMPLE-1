using System;

namespace q11
{
    class Program
    {
        static void Main(string[] args)
        {

            int angle1 = GetInt(" Enter the angle1 :");
            PrintMessage(angle1.ToString());
            int angle2 = GetInt(" Enter the angle2 :");
            PrintMessage(angle2.ToString());
            int angle3 = GetInt(" Enter the angle3 :");
            PrintMessage(angle3.ToString());
           System.Console.WriteLine(" the sum of three angles is : " + Triangle(angle1, angle2, angle3));
            
        }
         public static double Triangle (int angle1, int angle2, int angle3)
        {
            int sum = angle1 + angle2 + angle3;
            if (sum == 180)
            { Console.WriteLine(" The three angles can form a Triangle "); }
            else
            { Console.WriteLine(" The Three angles cannot form a Triangle "); }
            return sum;
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

