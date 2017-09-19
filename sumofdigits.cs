using System;

namespace sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num;
            Console.WriteLine("Enter a integer Number : ");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                sum += (num % 10);
                num = num / 10;

            }
            Console.WriteLine("The sum of the number is {0}",sum);
        }
    }
}

// sampleOutput
// Enter a integer Number :
// 45
// The sum of the number is 9