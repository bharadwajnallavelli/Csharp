using System;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber, temp;
            Console.WriteLine("we are swapping the numbers");
            Console.WriteLine("Enter the number 1");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Before Swapping the numbers");
            Console.WriteLine("Number 1 is {0} and number 2 is {1}", firstnumber,secondnumber);
            Console.WriteLine("After Swapping the numbers");
            temp = firstnumber;
            firstnumber = secondnumber;
            secondnumber = temp;
            Console.WriteLine("Number 1 is {0} and number 2 is {1}",firstnumber,secondnumber);
        }
    }
}


// sample output:

// we are swapping the numbers
// Enter the number 1
// 5
// Enter the number 2
// 6
// Before Swapping the numbers
// Number 1 is 5 and number 2 is 6
// After Swapping the numbers
// Number 1 is 6 and number 2 is 5
// Press any key to continue . . .