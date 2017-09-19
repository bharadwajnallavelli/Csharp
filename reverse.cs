using System;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0, num;
            Console.WriteLine("Enter a integer Number : ");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                reverse = reverse * 10;
                reverse = reverse + (num % 10);
                num = num / 10;

            }
            Console.WriteLine("The reverse of the number is {0}",reverse);
        }
    }
}


// sample output
// Enter a integer Number :
// 123
// The reverse of the number is 321