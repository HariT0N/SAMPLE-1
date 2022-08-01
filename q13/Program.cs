using System;

namespace q13
{
    class Program
    {
        static void Main(string[] args)
        {
             int N = GetInt(" Enter the value of N:");
            PrintMessage(N.ToString());
            Console.WriteLine(GetDay(N));



        }
         
            
        public static string GetDay (int N)
        
        {
            string day = "";
            switch (N%7)
            { default :
                day = "Not Valid";
                break;
                
                case 1:
                day = "Monday";
                break;
                case 2:
                day = "Tuesday";
                break;
                case 3:
                day = "Wednesday";
                break;
                case 4:
                day = "Thusday";
                break;
                case 5:
                day = "Friday";
                break;
                case 6:
                day = "Saturday";
                break;
                case 7:
                day = "Sunday";
                break;


          }
            return day;
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

