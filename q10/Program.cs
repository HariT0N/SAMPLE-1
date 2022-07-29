using System;

namespace q10
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
            int g = GetInt(" Enter the Fourth number :");
            PrintMessage(g.ToString());

            Console.WriteLine(" the largest of four numbers is :" + Largest4(d, e, f, g));
        }
         public static int Largest4(int d, int e, int f, int g)
        {
            int largest = d;
            if (e > largest)
            { largest = e; }
            if (f > largest)
            { largest = f; }
            if (g > largest)
            { largest = g; }

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
