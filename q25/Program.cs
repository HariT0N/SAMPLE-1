using System;

namespace q25
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("MENU FOR SIMPLE CALCULATOR:");
            Console.WriteLine(" ");
            Console.WriteLine("Press 1 for addition");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for division");
            Console.WriteLine("Press 5 for modulo division");
            Console.WriteLine(" ");

            float a = GetFloat("Enter the first value a: ");
            PrintMessage(a.ToString());
            float b = GetFloat("Enter the second value b: ");
            PrintMessage(b.ToString());

            int ch = GetInt("Enter the choice: ");
            PrintMessage(ch.ToString());

            if (ch == 1)
            {
                float c = a + b;
                Console.WriteLine("The addition of two numbers is: " + c);
            }
            else if (ch == 2)
            {
                float d = a - b;
                Console.WriteLine("The subtraction of two numbers is: " + d);
            }
            else if (ch == 3)
            {
                float e = a * b;
                Console.WriteLine("The multiplication of two numbers is: " + e);
            }
            else if (ch == 4)
            {
                float f = a / b;
                Console.WriteLine("The division of two numbers is: " + f);
            }
            else if (ch == 5)
            {
                float g = a % b;
                Console.WriteLine("The modulo division of two numbers is: " + g);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }
           public static int GetInt(string message)
    
          {  
            PrintMessage(message);
            int temp = int.Parse(Console.ReadLine());
            return temp;
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