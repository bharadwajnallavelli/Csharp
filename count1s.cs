using System;

namespace programs
{
    class countnumberof1s
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Count the number of 1's you entered!!");
            Console.WriteLine("Enter the number of numbers you want to enter (example: 4 or 5 or 6 ....)");
            int enterednumber = int.Parse(Console.ReadLine());
            while(enterednumber != 0)
            {
                Console.WriteLine("enter the number");
                int eval = int.Parse(Console.ReadLine());
                if(eval == 1)
                {
                    count++;
                    enterednumber--;
                }
                else
                {
                    enterednumber--;
                }
            }
            Console.WriteLine("total number of 1's is {0} ", count);
        }
    }
}
