using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("To check Even or Odd");
            Console.WriteLine("Enter the integer!");
            string enterednumber = Console.ReadLine();
            bool response = int.TryParse(enterednumber, out number);
            if(response == false)
            {
                Console.WriteLine("you have not entered correct form of integer");
            }
            else
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine("Entered Number {0} is Even", enterednumber);
                }
                else
                {
                    Console.WriteLine("Entered number {0} is odd", enterednumber);
                }
            }
            Console.ReadLine();

        }
    }
}
