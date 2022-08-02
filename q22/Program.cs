using System;

namespace q22
{
    class Program
    {
        static void Main(string[] args)
        {
           char row = GetChar("Enter the row value (a to h): ");
            PrintMessage(row.ToString());
            int column = GetInt("Enter the column value (1 to 8): ");
            PrintMessage(column.ToString());
             int sum = row + column;



            if ((sum) % 2 == 0)
            {
                Console.WriteLine("The colour of the chess box is black");
            }
            else
            {
                Console.WriteLine("The colour of the chess box is white");
            }

        }
           public static int GetInt(string message)
    
          {  
            PrintMessage(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
          }
           public static char GetChar(string message)
    
          {  
            PrintMessage(message);
            char temp = char.Parse(Console.ReadLine());
            return temp;
          }
          public static void PrintMessage(string message)
          {
            Console.WriteLine(message);

    }
}
}
