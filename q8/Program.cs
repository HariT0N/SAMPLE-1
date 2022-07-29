using System;

namespace q8
{
    class Program
    {
        static void Main(string[] args)
        {
             int d = GetInt(" Enter the first number :");
            PrintMessage(d.ToString());
            int e = GetInt(" Enter the second number :");
            PrintMessage(e.ToString());
            int f = GetInt(" Enter the third number :");
            PrintMessage(f.ToString());

             Console.WriteLine(" the largest of three numbers is :" + Largest3(d, e, f));
        }
          public static int Largest3 (int d, int e, int f)
           {
            int largest = d;
            if (  e > largest)
            { largest = e; }
            if (  f > largest)
            { largest = f; }
            return largest;

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
