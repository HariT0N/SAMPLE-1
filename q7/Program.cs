using System;

namespace q7
{
    class Program
    {
        static void Main(string[] args)
        {
             float height = GetFloat(" enter the Height in centimetre:");
            PrintMessage(height.ToString());

            if (height <= 100)
            { Console.WriteLine(" Short "); }
            if (height > 100 && height < 150)
            { Console.WriteLine(" Medium "); }
            if (height >= 150)
            { Console.WriteLine(" Tall "); }
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
