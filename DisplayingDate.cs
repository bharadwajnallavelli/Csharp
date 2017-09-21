using System;

namespace programs
{
    class DisplayingDate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Displaying date in different formats");
            Console.WriteLine("today's date and time is {0} ", DateTime.Now);
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("yyyy-MM-dd"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("dd-MM-yyyy"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("MM-dd-yyyy"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("yyyy-MMM-dd"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("d/M/y"));
            Console.WriteLine("Date in another format {0} ", DateTime.Now.ToString("dd-MMM-yyyy"));
        }
    }
}
