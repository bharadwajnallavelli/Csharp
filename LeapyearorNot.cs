using System;

namespace programs
{
    class LeapyearorNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check whether the entered year is Leap year or not!!!");
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            if(year % 4 == 0)
            {
                Console.WriteLine("{0} year is Leap year", year);
            }
            else
            {
                Console.WriteLine("{0} year is not a Leap year", year);
            }
        }
    }
}
