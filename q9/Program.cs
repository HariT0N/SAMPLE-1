using System;

namespace q9
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

            Console.WriteLine(" the smallest of three numbers is :" + smallest3(d, e, f));
        }
        public static int smallest3(int d, int e, int f)
        {
            int smallest = d;
            if (e < smallest)
            {smallest = e; }
            if (f < smallest)
            { smallest = f; }
            return smallest;

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
