using System;

namespace q14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year = GetInt(" Enter an Year :");
            PrintMessage(Year.ToString());
            Console.WriteLine(IsLeapYear(Year));
        }
         public static bool IsTypicalLeapYear(int Year)
        { return Year % 4 == 0; }
        public static bool IsATypicalYear(int Year)
        { return Year % 100 == 0 && Year % 400 != 0; }
        public static bool IsLeapYear(int Year)
        { return IsTypicalLeapYear(Year) && (IsATypicalYear(Year)); }

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
