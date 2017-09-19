using System;

namespace binarytriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastint = 1;
            Console.WriteLine("Enter the number of rows");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if(lastint==0)
                    {
                        Console.Write("1");
                        lastint = 1;
                    }
                    else{
                        Console.Write("0");
                        lastint = 0;
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}



// sample output
// Enter the number of rows
// 7

// 0

// 10

// 101

// 0101

// 01010

// 101010

// 1010101