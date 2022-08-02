using System;

namespace q26
{
    class Program
    {
        static void Main(string[] args)
        {
                      char letter = GetChar("enter the alphabate");
            PrintMessage(letter.ToString());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("It is a consonant");
            }

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
