using System;

namespace q16
{
    class Program
    {
        static void Main(string[] args)
        {
              int Mark = GetInt(" Enter the Marks:");
            PrintMessage(Mark.ToString());

            if (Mark >= 90)
            { Console.WriteLine("A Grade"); }
            if (Mark < 90 && Mark >= 80)
            { Console.WriteLine("B Grade"); }
            if (Mark < 80 && Mark >=70 )
            { Console.WriteLine("C Grade"); }
            if (Mark < 70 && Mark >= 60)
            { Console.WriteLine("D Grade"); }
            if (Mark < 60 && Mark >= 45) 
            { Console.WriteLine("E Grade"); }
            if (Mark < 45)
            { Console.WriteLine("F Grade(Fail"); }
          
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
