using System;

namespace q23
{
    class Program
    {
        static void Main(string[] args)
        {            
            int SPrice = GetInt("Enter the Selling price: ");
            PrintMessage(SPrice.ToString());
            int CPrice = GetInt("Enter the Cost price: ");
            PrintMessage(CPrice.ToString());

            if ((SPrice - CPrice) > 0)
            {
                Console.WriteLine("It is a Profit");
            }
            else
            {
                Console.WriteLine("It is a Loss");
            }

          
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
