using System;

namespace q15
{
    class Program
    {
        static void Main(string[] args)
        {
             int H = GetInt(" Enter the Height :");
            PrintMessage(H.ToString());

               Console.WriteLine(H <= 150 ?(H <= 100 ? " Short" :"Medium"): "Tall");

          
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
